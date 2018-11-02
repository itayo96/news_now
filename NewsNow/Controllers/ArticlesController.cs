using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using NewsNow.Models;
using ML;

namespace NewsNow.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly NewsNowContext _context;
        private readonly IHostingEnvironment _env;

        private readonly string _articlesTransitionDataPath;

        public ArticlesController(NewsNowContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;

            // If working in Visual Studio, make sure the 'Copy to Output Directory'
            // property of the file is set to 'Copy always'
            _articlesTransitionDataPath = System.IO.Path.Combine(_env.WebRootPath, "ml", "articles-transition-data.txt");
        }

        // GET: Articles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Articles.ToListAsync());
        }

        public async Task<IActionResult> Browse()
        {
            return View(await _context.Articles.ToListAsync());
        }

        // GET: Articles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.Include(a => a.Category).FirstOrDefaultAsync(m => m.ArticleId == id);

            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        public async Task<IActionResult> Comments(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comments = await _context.Comments.Where(c => c.ArticleId == id.Value).ToListAsync();

            if (comments == null)
            {
                return NotFound();
            }

            return Json(comments);
        }

        public async Task<IActionResult> GetRelatedArticles(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            const int NUM_OF_RELATED_ARTICLES = 3;
            var relatedArticles = new List<Article>();

            try
            {
                int mlRelatedArticle = MachineLearning.GetRelatedArticle(_articlesTransitionDataPath, id.Value);

                if (mlRelatedArticle != id.Value)
                {
                    var article = await _context.Articles.FirstAsync(c => c.ArticleId == mlRelatedArticle);

                    if (article != null)
                    {
                        relatedArticles.Add(article);

                        // Try to find a related article to the related article
                        int mlRelatedToRelatedArticle = MachineLearning.GetRelatedArticle(_articlesTransitionDataPath, mlRelatedArticle);

                        if (mlRelatedToRelatedArticle != mlRelatedArticle && mlRelatedToRelatedArticle != id.Value)
                        {
                            article = await _context.Articles.FirstAsync(c => c.ArticleId == mlRelatedToRelatedArticle);

                            if (article != null)
                            {
                                relatedArticles.Add(article);
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                // It's just mean that there is no data yet for this article
            }

            int articlesCount = _context.Articles.Count();
            Random random = new Random();

            // Fill the rest of the related articles with random articles, in order to
            // have the option for diversity (and by that make better predictions in the future)
            while (relatedArticles.Count() < NUM_OF_RELATED_ARTICLES)
            {
                int randomArticleId = random.Next(1, articlesCount);

                if (randomArticleId != id.Value && !relatedArticles.Exists(c => c.ArticleId == randomArticleId))
                {
                    var randomArticle = await _context.Articles.FirstAsync(c => c.ArticleId == randomArticleId);

                    if (randomArticle != null)
                    {
                        relatedArticles.Add(randomArticle);
                    }
                }
            }

            return Json(relatedArticles);
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Header,Summery,Content,HomeImageUrl,CategoryId,Location,IsShowMap")] Article articleModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(articleModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(articleModel);
        }

        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }

            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");

            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArticleId,Header,Summery,Content,HomeImageUrl,CategoryId,Location,IsShowMap")] Article article)
        {
            if (id != article.ArticleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Articles.Attach(article);
                    _context.Entry(article).Property(x => x.Content).IsModified = true;
                    _context.Entry(article).Property(x => x.Header).IsModified = true;
                    _context.Entry(article).Property(x => x.Summery).IsModified = true;
                    _context.Entry(article).Property(x => x.HomeImageUrl).IsModified = true;
                    _context.Entry(article).Property(x => x.CategoryId).IsModified = true;
                    _context.Entry(article).Property(x => x.Location).IsModified = true;
                    _context.Entry(article).Property(x => x.IsShowMap).IsModified = true;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.ArticleId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }

        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .FirstOrDefaultAsync(m => m.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            // TODO: Remove all the lines in the articles-transition-data.txt (_articlesTransitionDataPath) that contains this article id
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.ArticleId == id);
        }
    }
}

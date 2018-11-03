using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewsNow.Models;

namespace NewsNow.Controllers
{
    public class ArticlesSearchModel
    {
        public string CategoryId { get; set; }
        public string Header { get; set; }
        public string Summery { get; set; }
        public DateTime? DateCreated { get; set; }
    }

    public class CommentsSearchModel
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public int ArticleId { get; set; }
    }

    public class TotalSearchModel
    {
        public String SearchType { get; set; }
        public ArticlesSearchModel Articles { get; set; }
        public CommentsSearchModel Comments { get; set; }
    }

    public class ArticlesFilter
    {
        private readonly NewsNowContext _context;

        public ArticlesFilter(NewsNowContext context)
        {
            _context = context;
        }

        public IQueryable<Article> GetArticles(ArticlesSearchModel searchModel)
        {
            var result = _context.Articles.AsQueryable();

            if (searchModel != null)
            {
                if (!String.IsNullOrWhiteSpace(searchModel.CategoryId))
                    result = result.Where(x => x.CategoryId == Int32.Parse(searchModel.CategoryId));
                if (!String.IsNullOrWhiteSpace(searchModel.Header))
                    result = result.Where(x => x.Header.Contains(searchModel.Header));
                if (!String.IsNullOrWhiteSpace(searchModel.Summery))
                    result = result.Where(x => x.Summery.Contains(searchModel.Summery));
                if (searchModel.DateCreated.HasValue)
                    result = result.Where(x => x.DateCreated.Value.Date == searchModel.DateCreated.Value.Date);
            }

            return result;
        }
    }

    public class CommentsFilter
    {
        private readonly NewsNowContext _context;

        public CommentsFilter(NewsNowContext context)
        {
            _context = context;
        }

        public IQueryable<Comment> GetComments(CommentsSearchModel searchModel)
        {
            var result = _context.Comments.AsQueryable();

            if (searchModel != null)
            {
                if (!String.IsNullOrWhiteSpace(searchModel.Author))
                    result = result.Where(x => x.Author.Contains(searchModel.Author));
                if (!String.IsNullOrWhiteSpace(searchModel.Content))
                    result = result.Where(x => x.Content.Contains(searchModel.Content));
                if (!String.IsNullOrWhiteSpace(searchModel.ArticleId.ToString()))
                    result = result.Where(x => x.Article.ArticleId == searchModel.ArticleId);
            }

            return result;
        }
    }

    public class SearchController : Controller
    {
        private readonly NewsNowContext _context;
        private ArticlesFilter _articlesFilter;
        private CommentsFilter _commentsFilter;

        public SearchController(NewsNowContext context)
        {
            _context = context;
            _articlesFilter = new ArticlesFilter(context);
            _commentsFilter = new CommentsFilter(context);
        }

        public async Task<IActionResult> SearchViewModel(TotalSearchModel sm)
        {
            if (sm.SearchType == "Articles")
            {
                var model = _articlesFilter.GetArticles(sm.Articles);
                return View(model);
            }
            else
            {
                var model = _commentsFilter.GetComments(sm.Comments);
                return View(model);
            }
        }

        public async Task<IActionResult> Index()
        {
            return View(new Tuple<IEnumerable<Article>, IEnumerable<Comment>>(null, null));
        }

        // GET: Articles
        [HttpGet]
        public async Task<IActionResult> Index(ArticlesSearchModel searchModel)
        {
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", searchModel.CategoryId);    // preselect item in selectlist by categoryId param

            var model = _articlesFilter.GetArticles(searchModel);
            return View("Index", new Tuple<IEnumerable<Article>, IEnumerable<Comment>>(model.Take(50), null));
        }

        // GET: Comments
        [HttpGet]
        public async Task<IActionResult> Index2(CommentsSearchModel searchModel)
        {
            var model = _commentsFilter.GetComments(searchModel);
            return View("Index", new Tuple<IEnumerable<Article>, IEnumerable<Comment>>(null, model.Take(50)));
        }
    }
}

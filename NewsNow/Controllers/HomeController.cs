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
    public class HomeController : Controller
    {
        private readonly NewsNowContext _context;

        public HomeController(NewsNowContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            Dictionary<Category, List<Article>> categories = new Dictionary<Category, List<Article>>();

            foreach (Category c in _context.Categories)
            {
                categories.Add(c, await GetFeatured(c).ToListAsync());
            }

            ViewData["Categories"] = categories;

            ViewData["MainArticle"] = null;
            ViewData["MainArticleCategory"] = null;

            if (_context.Articles.Any())
            {
                var mainArticle = await _context.Articles.FirstAsync();
                ViewData["MainArticle"] = mainArticle;
                ViewData["MainArticleCategory"] = await _context.Categories
                    .FirstOrDefaultAsync(c => c.CategoryId == mainArticle.CategoryId);
            }

            // TODO: Actually calculate the featured articles
            ViewData["Articles"] = await _context.Articles.ToListAsync();
            ViewData["Featured"] = await _context.Articles.Skip(1).Take(2).ToListAsync();
            ViewData["Recent"] = await _context.Articles.OrderByDescending(x => x.DateCreated).Take(3).ToListAsync();

            return View();
        }

        public IQueryable<Article> GetFeatured(Category category)
        {
            return _context.Entry(category).Collection(p => p.Articles).Query().Take(4);
        }
    }
}

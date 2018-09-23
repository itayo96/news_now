using System;
using System.Collections.Generic;
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

            /*foreach (Article m in _context.Articles)
            {
                _context.Entry(m).Reference(p => p.Category).Load();
                var x = m.Category.Name;
            }*/

            ViewData["Categories"] = categories;
            ViewData["MainArticle"] = await _context.Articles.FindAsync(1);
            ViewData["Featured"] = await _context.Articles.Take(6).ToListAsync();
            ViewData["Articles"] = await _context.Articles.ToListAsync();

            return View();
        }

        public IQueryable<Article> GetFeatured(Category category)
        {
            return _context.Entry(category).Collection(p => p.Articles).Query().Take(4);
        }
    }
}

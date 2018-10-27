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

    public class SearchController : Controller
    {
        private readonly NewsNowContext _context;

        public SearchController(NewsNowContext context)
        {
            _context = context;
        }

        // GET: Articles
        public async Task<IActionResult> Index(string categoryId)
        {
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", categoryId);    // preselect item in selectlist by categoryId param

            if (String.IsNullOrWhiteSpace(categoryId))
            {
                return View();
            }

            var result = _context.Articles.Where(x => x.CategoryId == Int32.Parse(categoryId)).Take(50);

            return View(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewsNow.Models;
using Newtonsoft.Json;

namespace NewsNow.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly NewsNowContext _context;

        public StatisticsController(NewsNowContext context)
        {
            _context = context;
        }

        // GET: Statistics
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Comments()
        {
            var monthlyComments = await _context.Comments.GroupBy(x => new { x.DatePosted.Year, x.DatePosted.Month }).ToListAsync();

            var statistics = monthlyComments.Select(monthGroup => new {
                month = monthGroup.First().DatePosted.Month.ToString() + '/' + monthGroup.First().DatePosted.Year.ToString(),
                comments = monthGroup.Count()
            }).ToList();

            return Json(statistics);
        }

        public async Task<IActionResult> Articles()
        {
            var articlesPerCategory = await _context.Articles.Join(_context.Categories,
                category => category.CategoryId,
                article => article.CategoryId,
                (article, category) => new Article()
                {
                    ArticleId = article.ArticleId,
                    CategoryId = category.CategoryId,
                    Category = category
                }).GroupBy(x => x.CategoryId).ToListAsync();

            var statistics = articlesPerCategory.Select(categoryArticles => new
            {
                label = categoryArticles.First().Category.Name,
                color = categoryArticles.First().Category.HexColor,
                value = categoryArticles.Count()
            }).ToList();

            return Json(statistics);
        }

        public async Task<IActionResult> Locations()
        {
            var locations = await _context.Articles.Select(article => article.Location).ToListAsync();

            return Json(locations);
        }
    }
}

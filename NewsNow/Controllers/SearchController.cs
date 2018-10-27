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


    public class SearchController : Controller
    {
        private readonly NewsNowContext _context;
        private ArticlesFilter _filter;

        public SearchController(NewsNowContext context)
        {
            _context = context;
            _filter = new ArticlesFilter(context);
        }

        // GET: Articles
        public async Task<IActionResult> Index(ArticlesSearchModel searchModel)
        {
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", searchModel.CategoryId);    // preselect item in selectlist by categoryId param

            var model = _filter.GetArticles(searchModel);
            return View(model.Take(50));
        }
    }
}

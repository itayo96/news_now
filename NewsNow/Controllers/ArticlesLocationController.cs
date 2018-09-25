using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewsNow.Models;

namespace NewsNow.Controllers
{
    public class ArticlesLocationController : Controller
    {
        private readonly NewsNowContext _context;

        public ArticlesLocationController(NewsNowContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetLocations()
        {
            var articles = _context.Articles.ToList();
            var locations = new List<string>();

            foreach (var article in articles)
            {
                locations.Add(article.Location);
            }

            return Json(locations);
        }
    }
}

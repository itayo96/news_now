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
            var locations = new List<PointF>()
            {
                new PointF(12.505353f,55.335292f),
                 new PointF(13.505353f,55.485292f),
                  new PointF(13.655353f,55.665292f)
            };
            return Json(locations);
        }
    }
}

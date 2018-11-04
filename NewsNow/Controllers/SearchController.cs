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
    public class SearchController : Controller
    {
        private readonly NewsNowContext _context;

        public SearchController(NewsNowContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(new Tuple<IEnumerable<Article>, IEnumerable<Comment>>(null, null));
        }
    }
}

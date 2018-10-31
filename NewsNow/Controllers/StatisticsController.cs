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
            //return View(await _context.ExampleStatistics.ToListAsync());
            return View();
        }

        public async Task<IActionResult> CommentsStatistics()
        {
            string jsonData = null;

            using (StreamReader r = new StreamReader("wwwroot/assets/comments-statistics.json"))
            {
                jsonData = r.ReadToEnd();
            }

            dynamic deserializedJson = JsonConvert.DeserializeObject(jsonData);

            if (deserializedJson == null)
            {
                return NotFound();
            }

            return Json(deserializedJson);
        }

        //    // GET: Statistics/Details/5
        //    public async Task<IActionResult> Details(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var statistics = await _context.ExampleStatistics
        //            .FirstOrDefaultAsync(m => m.ID == id);
        //        if (statistics == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(statistics);
        //    }

        //    // GET: Statistics/Create
        //    public IActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: Statistics/Create
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Create([Bind("ID,EntersAmount,OldestManName")] ExampleStatisticsModel statistics)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _context.Add(statistics);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(statistics);
        //    }

        //    // GET: Statistics/Edit/5
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var statistics = await _context.ExampleStatistics.FindAsync(id);
        //        if (statistics == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(statistics);
        //    }

        //    // POST: Statistics/Edit/5
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(int id, [Bind("ID,EntersAmount,OldestManName")] ExampleStatisticsModel statistics)
        //    {
        //        if (id != statistics.ID)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(statistics);
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!StatisticsExists(statistics.ID))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(statistics);
        //    }

        //    // GET: Statistics/Delete/5
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var statistics = await _context.ExampleStatistics
        //            .FirstOrDefaultAsync(m => m.ID == id);
        //        if (statistics == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(statistics);
        //    }

        //    // POST: Statistics/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var statistics = await _context.ExampleStatistics.FindAsync(id);
        //        _context.ExampleStatistics.Remove(statistics);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool StatisticsExists(int id)
        //    {
        //        return _context.ExampleStatistics.Any(e => e.ID == id);
        //    }
    }
}

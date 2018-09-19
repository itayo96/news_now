using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsNow.Models;
using System.Text.Encodings.Web;
using System.Threading.Tasks;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace NewsNow.Controllers
{
    public class ExampleController : Controller
    {
        private readonly NewsNowContext _context;

        public ExampleController(NewsNowContext context)
        {
            _context = context;
        }

        // 
        // GET: /Example/

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ExampleStatisticsModel model)
        {
            return RedirectToAction("AddEntersAmount", "Example", new { amount = model.EntersAmount });
        }


        public async Task<IActionResult> AddEntersAmount(int amount = 1)
        {
            var statistics = await _context.ExampleStatistics.FirstOrDefaultAsync(m => m.ID == 1);
            if (statistics == null)
            {
                ExampleStatisticsModel exampleStatistics = new ExampleStatisticsModel();
                exampleStatistics.ID = 1;
                exampleStatistics.EntersAmount = amount;
                exampleStatistics.OldestManName = "Isaac Garzoon";
                _context.Add(exampleStatistics);
                await _context.SaveChangesAsync();
                statistics = exampleStatistics;
            }
            else
            {
                statistics.EntersAmount += amount;
                try
                {
                    _context.Update(statistics);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
            }

            int entersAmount = statistics.EntersAmount;
            string oldestManName = statistics.OldestManName;

            ViewData["EntersAmount"] = entersAmount;
            ViewData["OldestManName"] = oldestManName;

            return View();
        }
    }
}

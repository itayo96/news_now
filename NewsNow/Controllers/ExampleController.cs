using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace NewsNow.Controllers
{
    public class ExampleController : Controller
    {
        // 
        // GET: /Example/

        public string Index()
        {
            return "This is my default action...";
        }

        public string AddEntersAmount(int amount = 1)
        {
            return "The cuurent enters amount is: " + amount;
        }
    }
}

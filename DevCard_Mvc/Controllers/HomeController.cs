using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DevCard_Mvc.Models;

namespace DevCard_Mvc.Controllers
{
    public class HomeController : Controller
    {
      

        public HomeController(ILogger<HomeController> logger)
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult contact()
        {
            return View();
        }
        [HttpPost]
        public JsonResult contact(Contact contact)
        {
            var Name = contact.Name; 
            return Json(Ok());
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

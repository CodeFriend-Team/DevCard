using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DevCard_Mvc.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_Mvc.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Services> _services = new List<Services>{
            new Services( 1,"طلایی"),
            new Services( 2,"نقره ای"),
            new Services( 3,"الماس"),
            new Services( 4,"برنز"),
        };

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult contact()
        {
            var contact = new Contact
            {
                Services = new SelectList(_services,"Id","Name")
            };
            return View(contact);
        }
        [HttpPost]
        public IActionResult contact(Contact contact)
        {


            contact = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };

            if (!ModelState.IsValid)
            {
                ViewBag.Error = "اطلاعات وارد شده صحیح نیست.";
                return View(contact);                
            }
            ModelState.Clear();
        
                ViewBag.Success = "عملیات با موفقیت انجام شد.";
                return View(contact);
            
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

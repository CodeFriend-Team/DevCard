using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DevCard_Mvc.Data;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = ProjectStore.Projects();
            return View("_Projects", projects);
        }
    }
}

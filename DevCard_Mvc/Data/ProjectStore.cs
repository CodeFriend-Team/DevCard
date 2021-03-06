﻿using DevCard_Mvc.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Data
{
    public class ProjectStore
    {
        public static List<Project> Projects()
        {

            return new List<Project>
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "project-1.jpg", "Atriya"),
                new Project(2, "زودفود", "درخواست آنلاین غذا برای سراسر کشور", "project-2.jpg","ZoodFood"),
                new Project(3, "مدارس", "سیستم مدیریت یکپارچه مدارس", "project-3.jpg","MONOP"),
                new Project(4, "فضاپیما", "برنامه مدیریت فضاپیما های ناسا","project-4.jpg", "NASA"),
            };

        }
        public static Project GetProjectById(long id) {
            return Projects().FirstOrDefault(x=>x.Id == id);
        }
    }
}

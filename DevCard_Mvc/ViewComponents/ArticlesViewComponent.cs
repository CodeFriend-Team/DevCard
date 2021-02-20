using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"آموزش جاوا","یکی از بهترین زبان ها برای برنامه نویسی اندروید به حساب می آید.","blog-post-thumb-1.jpg"),
                new Article(2,"آموزش طاحی سایت با bootstrap","فریمورک بوت استرپ واکنش گرایی سایت ما رو به سادگی تامین می کنه","blog-post-thumb-2.jpg"),
                new Article(3,"آموزش  طراحی رزومه حرفه ای","فریمورک بوت استرپ واکنش گرایی سایت ما رو به سادگی تامین می کنه","blog-post-thumb-3.jpg")

            };
            return View("_Articles",articles);
        }
    }
}

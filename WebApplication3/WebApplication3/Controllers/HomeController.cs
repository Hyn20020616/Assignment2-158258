using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new IndexContentModel
            {
                AccordionImages = new List<string>
                {
                    "/Content/1.jpg",
                    "/Content/3.jpg",
                    "/Content/4.jpg",
                    "/Content/shoufengqinphoto1.jpg",

                },
                SlideImages = new List<string>
                {
                    "/Content/slide01.png",
                    "/Content/slide02.png",
                    "/Content/slide03.png",
                    "/Content/slide04.png",
                    "/Content/slide05.png",
                    "/Content/slide06.png",
                    "/Content/slide07.png",
                    "/Content/slide08.png",
                    "/Content/slide09.png",
                    "/Content/slide10.png",
                    "/Content/slide11.png",
                    "/Content/slide12.png",

                }
            };
            return View(model);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
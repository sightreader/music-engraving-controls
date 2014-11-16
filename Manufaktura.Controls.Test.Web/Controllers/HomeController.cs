using Manufaktura.Controls.Model;
using Manufaktura.Controls.Rendering.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Manufaktura.Controls.Test.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "sfsef";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public static MvcHtmlString RenderIncipitTest()
        {
            return null;
        }
    }
}
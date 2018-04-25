using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Test.Web.Models;
using System.Web.Mvc;

namespace Manufaktura.Controls.Test.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var fontMetadataPath = Server.MapPath("~/fonts/bravura_metadata.json");
            var useSmufl = true;

            var vm = new HomeViewModel();
            if (useSmufl)
            {
                var fontMetadata = System.IO.File.ReadAllText(fontMetadataPath);
                vm.Settings.LoadSMuFLFont(fontMetadata, "Bravura", 20, "/fonts/Bravura.otf");
            }

            //var serverPath = Server.MapPath("~/Content/036 Bogurodzica[1].xml");
            //var serverPath = Server.MapPath("~/Content/010 DWOK tom 25, s. 120, nr 273.xml");
            //var serverPath = Server.MapPath("~/Content/Kyrie.Salamon2.xml");
            var serverPath = Server.MapPath("~/Content/JohannChristophBachFull3.0.xml");
            //var serverPath = Server.MapPath("~/Content/030 Oj, zabujały 67 I nr 214.xml");
            //var serverPath = Server.MapPath("~/Content/0014 Larum w obozie.xml");
            //var serverPath = Server.MapPath("~/Content/Dzidzm.xml");
            vm.SampleScore = System.IO.File.ReadAllText(serverPath).ToScore();
            return View(vm);
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
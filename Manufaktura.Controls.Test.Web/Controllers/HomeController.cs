using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Test.Web.Models;
using System.Web.Mvc;

namespace Manufaktura.Controls.Test.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var vm = new HomeViewModel();
            var serverPath = Server.MapPath("~/Content/0117 DWOK tom 9, s. 238 nr 96.xml");
            //var serverPath = Server.MapPath("~/Content/010 DWOK tom 25, s. 120, nr 273.xml");
            //var serverPath = Server.MapPath("~/Content/JohannChristophBachFull3.0.xml");
            //var serverPath = Server.MapPath("~/Content/030 Oj, zabujały 67 I nr 214.xml");
			//var serverPath = Server.MapPath("~/Content/0014 Larum w obozie.xml");
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
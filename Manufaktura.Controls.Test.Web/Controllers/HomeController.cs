using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.SMuFL;
using Manufaktura.Controls.Test.Web.Models;
using System.Linq;
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
                var fontProfile = SMuFLMusicFont.CreateFromJsonString(System.IO.File.ReadAllText(fontMetadataPath));
                fontProfile.SetFontSize(Model.Fonts.MusicFontStyles.MusicFont, 20);
                vm.Settings.SetMusicFont(fontProfile, "Bravura", "/fonts/Bravura.otf");
            }

            //var serverPath = Server.MapPath("~/Content/036 Bogurodzica[1].xml");
            //var serverPath = Server.MapPath("~/Content/010 DWOK tom 25, s. 120, nr 273.xml");
            //var serverPath = Server.MapPath("~/Content/Kyrie.Salamon2.xml");
            var serverPath = Server.MapPath("~/Content/JohannChristophBachFull3.0.xml");
            //var serverPath = Server.MapPath("~/Content/030 Oj, zabujały 67 I nr 214.xml");
            //var serverPath = Server.MapPath("~/Content/0014 Larum w obozie.xml");
            //var serverPath = Server.MapPath("~/Content/Dzidzm.xml");
            vm.SampleScore = System.IO.File.ReadAllText(serverPath).ToScore();
            foreach (var note in vm.SampleScore.FirstStaff.Elements.OfType<Note>().Take(5))
            {
                note.CustomColor = Color.Red;
            }
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
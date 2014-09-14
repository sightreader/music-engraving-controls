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
            StringBuilder sb = new StringBuilder();
            HtmlCanvasScoreRenderer renderer = new HtmlCanvasScoreRenderer(sb);
            Score score = new Score();
            Staff staff = new Staff();
            score.Staves.Add(staff);
            staff.Elements.Add(new Clef(ClefType.GClef, 2));
            staff.Elements.Add(new Note("G", 0, 4, MusicalSymbolDuration.Quarter, VerticalDirection.Up, NoteTieType.None, new List<NoteBeamType>() { NoteBeamType.Single }));
            renderer.Render(score);
            sb.AppendLine("</script>");
            return MvcHtmlString.Create(sb.ToString());
        }
    }
}
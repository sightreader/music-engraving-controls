using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Manufaktura.Controls.Test.Web.Startup))]
namespace Manufaktura.Controls.Test.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

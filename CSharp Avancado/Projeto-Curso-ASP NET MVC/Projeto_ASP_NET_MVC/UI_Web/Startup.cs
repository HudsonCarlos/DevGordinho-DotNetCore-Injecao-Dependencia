using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UI_Web.Startup))]
namespace UI_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

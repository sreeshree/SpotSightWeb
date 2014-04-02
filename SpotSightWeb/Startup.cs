using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpotSightWeb.Startup))]
namespace SpotSightWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

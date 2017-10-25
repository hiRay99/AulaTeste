using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPaginaMestre.Startup))]
namespace WebAppPaginaMestre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

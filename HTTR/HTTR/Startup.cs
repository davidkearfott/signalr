using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HTTR.Startup))]
namespace HTTR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}

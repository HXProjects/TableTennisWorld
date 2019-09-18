using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TTW.Startup))]
namespace TTW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

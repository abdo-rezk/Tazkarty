using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tazkarty.Startup))]
namespace Tazkarty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

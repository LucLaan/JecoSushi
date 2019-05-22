using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JecoSushi.Startup))]
namespace JecoSushi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

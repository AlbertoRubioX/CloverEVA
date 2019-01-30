using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloverEVA.Startup))]
namespace CloverEVA
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proyecto1.Startup))]
namespace Proyecto1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
           ConfigureAuth(app);
        }
    }
}

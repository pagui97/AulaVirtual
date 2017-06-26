using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AulaVirtual.Startup))]
namespace AulaVirtual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

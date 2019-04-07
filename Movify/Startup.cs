using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movify.Startup))]
namespace Movify
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

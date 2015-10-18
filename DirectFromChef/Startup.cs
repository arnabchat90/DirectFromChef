using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DirectFromChef.Startup))]
namespace DirectFromChef
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

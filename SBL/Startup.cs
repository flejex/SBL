using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SBL.Startup))]
namespace SBL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LadyD.Startup))]
namespace LadyD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

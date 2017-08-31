using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCArchitect.Startup))]
namespace PCArchitect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

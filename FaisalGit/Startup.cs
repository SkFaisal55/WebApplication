using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FaisalGit.Startup))]
namespace FaisalGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

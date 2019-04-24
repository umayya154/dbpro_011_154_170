using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBLabProject.Startup))]
namespace DBLabProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

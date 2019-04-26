using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DB3.Startup))]
namespace DB3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

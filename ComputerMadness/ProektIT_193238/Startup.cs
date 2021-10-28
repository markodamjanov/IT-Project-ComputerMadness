using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProektIT_193238.Startup))]
namespace ProektIT_193238
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

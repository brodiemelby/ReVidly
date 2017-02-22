using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReVidly.Startup))]
namespace ReVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcoRaf.Startup))]
namespace AcoRaf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

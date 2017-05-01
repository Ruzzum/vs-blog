using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogMusical.Startup))]
namespace BlogMusical
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

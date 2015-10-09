using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCThingumy.Startup))]
namespace MVCThingumy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

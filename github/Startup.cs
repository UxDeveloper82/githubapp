using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(github.Startup))]
namespace github
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

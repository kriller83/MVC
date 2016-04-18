using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLabb1.Startup))]
namespace MVCLabb1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

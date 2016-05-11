using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestKod.Startup))]
namespace TestKod
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxWebbApplication.Startup))]
namespace AjaxWebbApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

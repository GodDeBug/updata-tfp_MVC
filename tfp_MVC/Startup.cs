using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tfp_MVC.Startup))]
namespace tfp_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

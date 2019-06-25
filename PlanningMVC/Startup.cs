using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlanningMVC.Startup))]
namespace PlanningMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

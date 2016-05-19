using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(adCars.Startup))]
namespace adCars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

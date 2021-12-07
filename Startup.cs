using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoffeeApp.Startup))]
namespace CoffeeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

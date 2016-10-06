using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MacRecipe.Startup))]
namespace MacRecipe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

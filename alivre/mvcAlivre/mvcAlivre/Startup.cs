using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcAlivre.Startup))]
namespace mvcAlivre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeadingAndGoverning.Startup))]
namespace LeadingAndGoverning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

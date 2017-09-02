using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningAndGoverning.Startup))]
namespace LearningAndGoverning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

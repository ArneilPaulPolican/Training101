using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(training102.Startup))]
namespace training102
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

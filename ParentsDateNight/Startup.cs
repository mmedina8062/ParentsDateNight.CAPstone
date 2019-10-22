using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParentsDateNight.Startup))]
namespace ParentsDateNight
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

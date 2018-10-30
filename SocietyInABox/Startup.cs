using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocietyInABox.Startup))]
namespace SocietyInABox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

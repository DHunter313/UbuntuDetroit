using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UbuntuDetroit.Startup))]
namespace UbuntuDetroit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iPhoneRepair.Startup))]
namespace iPhoneRepair
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

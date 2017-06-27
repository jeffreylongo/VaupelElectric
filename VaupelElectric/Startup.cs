using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VaupelElectric.Startup))]
namespace VaupelElectric
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

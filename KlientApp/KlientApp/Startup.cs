using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KlientApp.Startup))]
namespace KlientApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

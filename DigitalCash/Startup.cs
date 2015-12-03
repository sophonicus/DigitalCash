using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigitalCash.Startup))]
namespace DigitalCash
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

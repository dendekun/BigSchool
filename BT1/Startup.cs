using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BT1.Startup))]
namespace BT1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerOrdersUI.Startup))]
namespace CustomerOrdersUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

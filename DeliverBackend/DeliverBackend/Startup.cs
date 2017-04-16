using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeliverBackend.Startup))]
namespace DeliverBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

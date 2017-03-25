using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DeliverBackend.Startup))]

namespace DeliverBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
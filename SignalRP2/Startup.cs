using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRP2.Startup))]

namespace SignalRP2
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }


        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}

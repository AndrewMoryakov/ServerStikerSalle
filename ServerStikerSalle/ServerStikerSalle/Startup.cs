using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServerStikerSalle.Startup))]
namespace ServerStikerSalle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

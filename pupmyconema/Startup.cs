using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pupmyconema.Startup))]
namespace pupmyconema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

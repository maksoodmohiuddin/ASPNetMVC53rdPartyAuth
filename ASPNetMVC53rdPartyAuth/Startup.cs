using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNetMVC53rdPartyAuth.Startup))]
namespace ASPNetMVC53rdPartyAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

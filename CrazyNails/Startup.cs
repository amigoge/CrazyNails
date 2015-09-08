using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrazyNails.Startup))]
namespace CrazyNails
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

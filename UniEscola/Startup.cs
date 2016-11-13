using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniEscola.Startup))]
namespace UniEscola
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LivrariaB.Startup))]
namespace LivrariaB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

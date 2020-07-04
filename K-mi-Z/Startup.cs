using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(K_mi_Z.Startup))]
namespace K_mi_Z
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

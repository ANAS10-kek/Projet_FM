using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projet_FM.Startup))]
namespace Projet_FM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

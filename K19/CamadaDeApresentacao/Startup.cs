using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CamadaDeApresentacao.Startup))]
namespace CamadaDeApresentacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

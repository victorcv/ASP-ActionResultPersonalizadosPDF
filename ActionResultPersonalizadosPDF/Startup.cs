using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ActionResultPersonalizadosPDF.Startup))]
namespace ActionResultPersonalizadosPDF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

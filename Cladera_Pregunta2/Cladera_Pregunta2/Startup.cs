using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cladera_Pregunta2.Startup))]
namespace Cladera_Pregunta2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

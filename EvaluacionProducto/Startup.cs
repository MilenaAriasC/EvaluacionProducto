using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EvaluacionProducto.Startup))]
namespace EvaluacionProducto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

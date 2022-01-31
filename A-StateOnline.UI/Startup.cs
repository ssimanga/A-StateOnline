using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A_StateOnline.UI.Startup))]
namespace A_StateOnline.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

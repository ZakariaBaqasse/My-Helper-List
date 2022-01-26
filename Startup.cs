using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyHelper.Startup))]
namespace MyHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

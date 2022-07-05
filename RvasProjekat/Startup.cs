using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RvasProjekat.Startup))]
namespace RvasProjekat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

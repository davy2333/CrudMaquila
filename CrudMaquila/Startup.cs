using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudMaquila.Startup))]
namespace CrudMaquila
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

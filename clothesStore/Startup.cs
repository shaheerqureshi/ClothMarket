using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(clothesStore.Startup))]
namespace clothesStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

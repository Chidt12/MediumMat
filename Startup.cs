using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MatBlog.Startup))]
namespace MatBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

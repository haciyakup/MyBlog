using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My_Blog_MVC.Startup))]
namespace My_Blog_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

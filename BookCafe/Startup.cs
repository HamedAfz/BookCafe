using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookCafe.Startup))]
namespace BookCafe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhanThanhNhan_2080600532.Startup))]
namespace PhanThanhNhan_2080600532
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811063256_NguyenGiaBao_BigSchool.Startup))]
namespace _1811063256_NguyenGiaBao_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

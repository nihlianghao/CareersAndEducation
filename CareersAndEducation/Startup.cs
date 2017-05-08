using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CareersAndEducation.Startup))]
namespace CareersAndEducation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

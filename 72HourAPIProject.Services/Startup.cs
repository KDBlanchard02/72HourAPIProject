using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(_72HourAPIProject.Services.StartupOwin))]

namespace _72HourAPIProject.Services
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}

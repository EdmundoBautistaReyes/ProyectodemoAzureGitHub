using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppDemoAzureGitHub.Startup))]
namespace AppDemoAzureGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

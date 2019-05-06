using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(React.NET_WebForms_Working_Version_.Startup))]
namespace React.NET_WebForms_Working_Version_
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

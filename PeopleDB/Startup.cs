using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeopleDB.Startup))]
namespace PeopleDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

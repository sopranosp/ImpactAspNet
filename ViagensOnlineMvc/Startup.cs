using System;

using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using ViagensOnlineMvc.Models;

[assembly: OwinStartup(typeof(ViagensOnlineMvc.Startup))]

namespace ViagensOnlineMvc
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Para obter mais informações sobre como configurar seu aplicativo, visite https://go.microsoft.com/fwlink/?LinkID=316888

            app.UseCookieAuthentication(
                new CookieAuthenticationOptions
                {
                    AuthenticationType = Cookie.ViagensOnlineCookieAuthentication.ToString(),
                    LoginPath = new PathString("/Login")


                }
                );
        }
    }
}

using Microsoft.Owin;
using Owin;
using ProductManagement.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup(typeof(Startup))]
namespace ProductManagement.WebApi
{
    public partial class Startup
    {
        public HttpConfiguration HttpConfiguration { get; set; }

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);

            app.UseWebApi(config);
            HttpConfiguration = config;
        }
    }
}
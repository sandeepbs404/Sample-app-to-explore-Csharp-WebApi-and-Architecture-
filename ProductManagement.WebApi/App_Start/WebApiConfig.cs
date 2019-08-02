using Newtonsoft.Json.Converters;
using ProductManagement.WebApi.App_Start.DependencyInjection;
using ProductManagement.WebApi.Filter;
using System.Web.Http;

namespace ProductManagement.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            ConfigFormatters(config);
            ConfigFilters(config);
            // Web API routes
            ConfigRoutes(config);

            AutofacConfiguration.Configure(config);

        }

        private static void ConfigRoutes(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void ConfigFormatters(HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            config.Formatters.JsonFormatter.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            //Configure Date Time
            config.Formatters.JsonFormatter.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
            config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new StringEnumConverter());
        }

        private static void ConfigFilters(HttpConfiguration config)
        {
            config.Filters.Add(new ModelValidationErrorHandlerFilterAttribute());
            config.Filters.Add(new ExceptionHandlerAttribute());
            config.Filters.Add(new CustomAuthorizationFilterAttribute());
        }
    }
}

using Autofac;
using Autofac.Integration.WebApi;
using ProductManagement.Service.Products.BusinessLogic.Service;
using ProductManagement.Service.Products.Data;
using System.Reflection;
using System.Web.Http;

namespace ProductManagement.WebApi.App_Start.DependencyInjection
{
    public static class AutofacConfiguration
    {
        public static void Configure(HttpConfiguration config)
        {
            //IContainer container = null;
            //var builder = new ContainerBuilder();
            //var assembly = Assembly.GetCallingAssembly();
            //var webapiassembly = Assembly.GetAssembly(typeof(AutofacConfiguration));
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterAssemblyModules(assembly);
            //builder.RegisterAssemblyModules(webapiassembly);

            //container = builder.Build();
            //builder = new ContainerBuilder();
            //builder.RegisterInstance(container).As<IContainer>();
            //builder.Update(container);

            var builder = new ContainerBuilder();
            //var config = new HttpConfiguration();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetCallingAssembly());
            builder.RegisterType<ProductService>().As<IProductService>();

            //builder.RegisterAssemblyTypes(Assembly.GetAssembly( typeof(IProductService))
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
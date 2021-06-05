using AdventureWorksSales.Core;
using AdventureWorksSales.Core.DataManager;
using AdventureWorksSales.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace AdventureWorksSales.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {


        protected void Application_Start()
        {
            var container = new UnityContainer();
            container.RegisterType<IProductRepository, ProductManager>();
            container.RegisterType<IProductCategoryRepository, ProductCategoryManager>();
            container.RegisterType<ISalesOrderRepository, SalesOrderManager>();

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

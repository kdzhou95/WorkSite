using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkSite.DependencyResolution
{
    public static class BootStrapper
    {
        public static ServiceContainer ConfigureLightInject()
        {
            var container = new ServiceContainer();
            container.EnableMvc();
            container.RegisterControllers(typeof(Controllers.HomeController).Assembly);
            container.EnableAnnotatedPropertyInjection();

            DependencyLoader.Register(container);

            return container;
        }
    }
}
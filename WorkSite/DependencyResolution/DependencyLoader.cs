using LightInject;
using WorkSite.Clients;

namespace WorkSite.DependencyResolution
{
    public static class DependencyLoader
    {
        public static void Register(IServiceContainer container)
        {
            container.Register<IDataClient, DataClient>(new PerContainerLifetime());
        }
    }
}
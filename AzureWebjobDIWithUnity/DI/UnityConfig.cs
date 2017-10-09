namespace AzureWebjobDIWithUnity.DI
{
    using System;
    using Logic;
    using Microsoft.Practices.Unity;

    public class UnityConfig
    {
        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return Container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IMessageLogic, MessageLogic>();
        }

    }
}

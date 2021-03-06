﻿namespace AzureWebjobDIWithUnity.DI
{
    using Microsoft.Azure.WebJobs.Host;
    using Microsoft.Practices.Unity;

    public class UnityActivator : IJobActivator
    {
        private readonly IUnityContainer _container;

        public UnityActivator(IUnityContainer container)
        {
            _container = container;
        }

        public T CreateInstance<T>()
        {
            return _container.Resolve<T>();
        }
    }
}

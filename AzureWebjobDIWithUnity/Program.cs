namespace AzureWebjobDIWithUnity
{
    using DI;
    using Microsoft.Azure.WebJobs;

    class Program
    {
        static void Main()
        {
            var config = new JobHostConfiguration
            {
               JobActivator = new UnityActivator(UnityConfig.GetConfiguredContainer())
            };

            var host = new JobHost(config);
            
            host.RunAndBlock();
        }
    }
}

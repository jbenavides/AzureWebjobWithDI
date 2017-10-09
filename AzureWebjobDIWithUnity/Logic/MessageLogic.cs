namespace AzureWebjobDIWithUnity.Logic
{
    public class MessageLogic : IMessageLogic
    {
        public string GetMessage(string name)
        {
            return $"Hello {name}";
        }
    }
}

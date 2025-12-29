using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace DependencyInjectionDemo.Components.Demos.StateManagement.Services
{
    public class StateService
    {

        private List<string> _messages = new();

        public event Action? OnChange;

        public void AddMessage(string msg)
        {
            _messages.Add(msg);
            NotifyMessagesChangedAsync();
        }

        public IEnumerable<string> GetMessages() => _messages;

        private void NotifyMessagesChangedAsync() => OnChange?.Invoke();        

    }
}

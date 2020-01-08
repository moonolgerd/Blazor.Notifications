using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazor.Notifications
{
    public class NotificationService
    {
        private readonly IJSRuntime runtime;

        public NotificationService(IJSRuntime runtime) => this.runtime = runtime;

        public ValueTask<string> CreateAsync(string title) => runtime.InvokeAsync<string>("notifyMe", title);

        public ValueTask<string> CreateAsync(string title, NotificationOptions options) => 
            runtime.InvokeAsync<string>("notifyMe", title, options);
    }
}

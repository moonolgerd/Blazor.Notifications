using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Notifications
{
    public static class NotificationsExtensions
    {
        public static IServiceCollection AddNotifications(this IServiceCollection services) => 
            services.AddScoped<NotificationService>();
    }
}

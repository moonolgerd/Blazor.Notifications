using System;

namespace Blazor.Notifications
{
    public class NotificationOptions
    {
        public string Badge { get; set; }
        public string Body { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }
        public string Lang { get; set; }
        public bool RequireInteraction { get; set; }
        public bool Silent { get; set; }
        public string Tag { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}

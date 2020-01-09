![](https://github.com/moonolgerd/Blazor.Notifications/workflows/.NET%20Core/badge.svg)
[![Package Version](https://img.shields.io/nuget/v/BlazorNotifications.svg)](https://www.nuget.org/packages/BlazorNotifications/)

# Blazor Notifications

Blazor Server Class Library for sending Web Notifications

## Usage

Add to *Startup.cs*

```c#
public void ConfigureServices(IServiceCollection services)
{
    services.AddNotifications();
}
```

Add to *_Host.cshtml*

```html
<script src="_content/Blazor.Notifications/notifier.js"></script>
```

Add to your razor file

```c#
@inject Blazor.Notifications.NotificationService NotificationService
```

Raise a notification

```c#
await NotificationService.CreateAsync("Hello from Blazor Notifier");
```

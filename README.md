![](https://github.com/moonolgerd/Blazor.Notifications/workflows/.NET%20Core/badge.svg)
[![Package Version](https://img.shields.io/nuget/v/BlazorNotifications.svg)](https://www.nuget.org/packages/BlazorNotifications/)

# Blazor Notifications

Blazor Class Library for sending Web Notifications

## Usage

### Blazor.Server

Add to *Startup.cs*

```c#
public void ConfigureServices(IServiceCollection services)
{
    services.AddNotifications();
}
```

### Blazor.WebAssembly

Add to *Program.cs*
```c#
public static async Task Main(string[] args)
{
    builder.Services.AddNotifications();
}
```
### Blazor.Server

Add to *_Host.cshtml*

```html
<script src="_content/BlazorNotifications/notifier.js"></script>
```

### Blazor.WebAssembly

Add to *wwwroot/index.html*

```html
<script src="_content/BlazorNotifications/notifier.js"></script>
```

Add to your .razor file

```c#
@inject Blazor.Notifications.NotificationService NotificationService
```

Raise a notification

```c#
await NotificationService.CreateAsync("Hello from Blazor Notifier");
```

using Messenger.Domain.Interfaces.Services;
using Messenger.Infra;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection();
        DependencyInjectionConfig.ConfigureDependencies(serviceProvider);

        using (var serviceProviderScope = serviceProvider.BuildServiceProvider())
        {
            var emailService = serviceProviderScope.GetRequiredService<IEmailService>();
        }
    }
}

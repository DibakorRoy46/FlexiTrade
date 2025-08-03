
using Microsoft.Extensions.DependencyInjection;

namespace FlexiTrade.Core
{
    public static class DependencyInjectiion
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            // Register core services here
            // Example: services.AddSingleton<ICoreService, CoreService>();
            return services;
        }
    }
}

using FlexiTrade.Core.RepositoryContracts;
using FlexiTrade.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FlexiTrade.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            // Register infrastructure services here
            // Example: services.AddSingleton<IMyService, MyService>();
            return services;
        }
    }
}

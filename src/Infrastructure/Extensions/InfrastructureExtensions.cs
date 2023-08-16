using Microsoft.Extensions.DependencyInjection;
using TaskManager.Application.Data;
using TaskManager.Infrastructure.Repositories;

namespace TaskManager.Infrastructure.Extensions
{
    public static class InfrastructureExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITaskItemRepository,TaskItemRepository>();
        }
    }
}

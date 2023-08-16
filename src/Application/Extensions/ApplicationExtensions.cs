using Microsoft.Extensions.DependencyInjection;
using TaskManager.Application.UseCases.AddTask;
using TaskManager.Application.UseCases.GetAllTask;
using TaskManager.Application.UseCases.RemoveTask;

namespace TaskManager.Application.Extensions
{
    public static class ApplicationExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddTransient<AddTaskItemUseCase>();
            services.AddTransient<GetAllTaskItemUseCase>();
            services.AddTransient<RemoveTaskUseCase>();
        }
    }
}

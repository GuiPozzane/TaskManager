using TaskManager.Domain.Entities;

namespace TaskManager.Application.Data
{
    public interface ITaskItemRepository
    {
        Task AddTaskAsync(TaskItem task);

        Task RemoveTaskAsync(int taskItemId);

        Task<List<TaskItem>> GetAllTasksAsync();
    }
}

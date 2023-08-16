using TaskManager.Application.Data;
using TaskManager.Domain.Entities;

namespace TaskManager.Infrastructure.Repositories
{
    public class TaskItemRepository : ITaskItemRepository
    {
        private Lazy<List<TaskItem>> _tasks;
        public TaskItemRepository() 
        {
            _tasks = new Lazy<List<TaskItem>>();
        }
        public Task AddTaskAsync(TaskItem task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));

            _tasks.Value.Add(task);
            return Task.CompletedTask;
        }

        public Task RemoveTaskAsync(int taskId)
        {
            var taskToRemove = _tasks.Value.Find(t => t.Id == taskId);
            if (taskToRemove != null)
            {
                _tasks.Value.Remove(taskToRemove);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Task<List<TaskItem>> GetAllTasksAsync()
        {
            return Task.FromResult(_tasks.Value);
        }
    }
}

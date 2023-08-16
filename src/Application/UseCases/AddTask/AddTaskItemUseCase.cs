using TaskManager.Application.Data;
using TaskManager.Domain.Entities;

namespace TaskManager.Application.UseCases.AddTask
{
    public class AddTaskItemUseCase
    {
        private ITaskItemRepository _taskItemRepository;

        public AddTaskItemUseCase(ITaskItemRepository taskItemRepository)
        {
            _taskItemRepository = taskItemRepository;
         }
        public Task ExecuteAsync(TaskItem item)
        {
            if (item.Id == 0)
            {
                throw new Exception();
            }
            return _taskItemRepository.AddTaskAsync(item);
        }
    }
}

using TaskManager.Application.Data;
using TaskManager.Domain.Entities;

namespace TaskManager.Application.UseCases.GetAllTask
{
    public class GetAllTaskItemUseCase
    {
        private ITaskItemRepository _taskItemRepository;

        public GetAllTaskItemUseCase(ITaskItemRepository taskItemRepository)
        {
            _taskItemRepository = taskItemRepository;
        }
        public Task<List<TaskItem>> GetAsync()
        {
            return _taskItemRepository.GetAllTasksAsync();
        }
    }
}

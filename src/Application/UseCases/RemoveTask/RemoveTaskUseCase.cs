using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Data;

namespace TaskManager.Application.UseCases.RemoveTask
{
    public class RemoveTaskUseCase
    {
        private ITaskItemRepository _taskItemRepository;

        public RemoveTaskUseCase(ITaskItemRepository taskItemRepository)
        {
            _taskItemRepository = taskItemRepository;
        }
        public Task ExecuteAsync(int taskItemId)
        {
            return _taskItemRepository.RemoveTaskAsync(taskItemId);
        }
    }
}

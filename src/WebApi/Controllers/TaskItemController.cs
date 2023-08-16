using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.AddTask;
using TaskManager.Application.UseCases.GetAllTask;
using TaskManager.Application.UseCases.RemoveTask;
using TaskManager.Domain.Entities;

namespace TaskManager.WebApi.Controllers
{
    [Route("api/taskitem")]
    [ApiController]
    public class TaskItemController : ControllerBase
    {
        public TaskItemController()
        {
                
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTaskItemsAsync([FromServices] GetAllTaskItemUseCase getAllTaskUseCase) 
        {
            return Ok(await getAllTaskUseCase.GetAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddItemAsync([FromServices] AddTaskItemUseCase addTaskItemUseCase, [FromBody] TaskItem taskItem)
        {
            await addTaskItemUseCase.ExecuteAsync(taskItem);
            return StatusCode(StatusCodes.Status201Created,taskItem.Id);
        }
        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> RemoveItemAsync([FromServices] RemoveTaskUseCase removeTaskUseCase, [FromRoute] int id)
        {
            await removeTaskUseCase.ExecuteAsync(id);
            return Ok();
        }
    }
}

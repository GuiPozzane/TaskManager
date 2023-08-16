using AutoFixture;
using Moq;
using TaskManager.Application.Data;
using TaskManager.Application.UseCases.AddTask;
using TaskManager.Domain.Entities;
using Xunit;

namespace TaskManager.UnitTest.Tests.Application
{
    public class AddTaskItemUseCaseTests
    {
        private readonly Fixture _fixture;
        private readonly AddTaskItemUseCase _addTaskItemUseCase;
        private readonly Mock<ITaskItemRepository> _taskItemRepository;
        public AddTaskItemUseCaseTests()
        {
            _fixture = new Fixture();
            _taskItemRepository = new Mock<ITaskItemRepository>();
            _addTaskItemUseCase = new AddTaskItemUseCase(_taskItemRepository.Object);
        }
        [Fact]
        public void Should_AddTaskItemWithSuccess()
        {
            //Arrange
            var task = new TaskItem(
                1,
                _fixture.Create<string>(),
                _fixture.Create<bool>());
            //Act
            _addTaskItemUseCase.ExecuteAsync(task);
            //Assert
            _taskItemRepository.Verify(z=> z.AddTaskAsync(task));
        }
    }
}

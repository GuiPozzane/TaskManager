namespace TaskManager.Domain.Entities
{
    public class TaskItem
    {
        public TaskItem(int id, string title, bool isCompleted)
        {
            Id = id;
            Title = title;
            IsCompleted = isCompleted;
        }

        public int Id { get; init; }
        public string Title { get; init; }
        public bool IsCompleted { get; init; }
    }
}

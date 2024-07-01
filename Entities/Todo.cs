namespace TodoList.Entities
{
    public class Todo
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
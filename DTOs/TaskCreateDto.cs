namespace TaskManagement.DTOs
{
    public class TaskCreateDto
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime DayStart { get; set; }
        public DateTime Deadline { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
    }
}

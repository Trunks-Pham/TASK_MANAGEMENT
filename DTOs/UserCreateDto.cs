namespace TaskManagement.DTOs
{
    public class UserCreateDto
    {
        public string FullName { get; set; } = string.Empty;
        public DateTime? DayOfBirth { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}

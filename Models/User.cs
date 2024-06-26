namespace TaskManagement.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }=string.Empty;
        public DateTime? DayOfBirth { get; set; }
        public string Email { get; set; }=string.Empty;
        public string Phone { get; set; }=string.Empty;
        public int Number { get; set; }
        
        public ICollection<Task>? Tasks { get; set; }
    }
}

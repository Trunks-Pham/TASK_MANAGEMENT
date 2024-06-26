using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TaskManagement.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public string Content { get; set; }=string.Empty;
        public DateTime DayStart { get; set; }
        public DateTime Deadline { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }  // Đây là khóa ngoại đến User

        public User? User { get; set; }   // Đây là đối tượng User liên kết với Task
    }
}



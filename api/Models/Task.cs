using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Task
    {   
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public String TaskName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
    }
}
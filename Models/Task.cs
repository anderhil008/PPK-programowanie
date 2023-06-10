using MessagePack;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskContent { get; set; }
        public string UserId { get; set; }
        public bool IsCompleted { get; set; }
    }
}

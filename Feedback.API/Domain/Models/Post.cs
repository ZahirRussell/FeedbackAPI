using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.API.Domain.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
       public User User { get; set; }

        public DateTime PostTime { get; set; }
        public IList<Comment> Comments { get; set; } = new List<Comment>();
    }
}

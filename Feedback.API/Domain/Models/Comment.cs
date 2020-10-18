using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.API.Domain.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        //public int Likes { get; set; }
        //public int DisLikes { get; set; }
        public IList<Like> likes { get; set; } = new List<Like>();
        public IList<DisLike> dislikes { get; set; } = new List<DisLike>();
    }
}

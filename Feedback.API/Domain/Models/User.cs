using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.API.Domain.Models
{
    public class User
    {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }

        public IList<Comment> Comments { get; set; } = new List<Comment>();
        public IList<Like> Likes { get; set; } = new List<Like>();
        public IList<DisLike> DisLikes { get; set; } = new List<DisLike>();



    }
}

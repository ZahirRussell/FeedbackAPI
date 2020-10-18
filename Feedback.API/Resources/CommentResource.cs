using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.API.Domain.Models
{
    public class CommentResource
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Post { get; set; }
        public string User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.API.Domain.Models
{
    public class DisLikeResource
    {
        public int Id { get; set; }

        public string Comment { get; set; }
        public string User { get; set; }
    }
}

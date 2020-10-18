using Feedback.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.API.Domain.Services
{
   public interface IUserService
    {
        Task<IEnumerable<User>> ListAsync();
    }
}

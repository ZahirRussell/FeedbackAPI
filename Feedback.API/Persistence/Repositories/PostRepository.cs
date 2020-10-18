using Feedback.API.Domain.Models;
using Feedback.API.Domain.Repositories;
using Feedback.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.API.Persistence.Repositories
{
    public class PostRepository:BaseRepository,IPostRepository
    {
        public PostRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Post>> ListAsync()
        {
            return await _context.Posts.ToListAsync();
        }

    }
}

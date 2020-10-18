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
    public class LikeRepository:BaseRepository,ILikeRepository
    {
        public LikeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Like>> ListAsync()
        {
            return await _context.Likes.ToListAsync();
        }

    }
}

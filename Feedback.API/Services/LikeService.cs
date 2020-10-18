using Feedback.API.Domain.Models;
using Feedback.API.Domain.Repositories;
using Feedback.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.API.Services
{
    public class LikeService:ILikeService
    {
        private readonly ILikeRepository _likeRepository;

        public LikeService(ILikeRepository likeRepository)
        {
            this._likeRepository = likeRepository;
        }

        public async Task<IEnumerable<Like>> ListAsync()
        {
            return await _likeRepository.ListAsync();
        }
    }
}

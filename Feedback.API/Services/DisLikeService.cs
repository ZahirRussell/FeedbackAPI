using Feedback.API.Domain.Models;
using Feedback.API.Domain.Repositories;
using Feedback.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.API.Services
{
    public class DisLikeService:IDisLikeService
    {
        private readonly IDisLikeRepository _disLikeRepository;

        public DisLikeService(IDisLikeRepository disLikeRepository)
        {
            this._disLikeRepository = disLikeRepository;
        }

        public async Task<IEnumerable<DisLike>> ListAsync()
        {
            return await _disLikeRepository.ListAsync();
        }
    }
}

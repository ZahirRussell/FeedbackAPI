using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feedback.API.Domain.Models;
using Feedback.API.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Feedback.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public async Task<IEnumerable<Post>> GetAllAsync()
        {
            var posts = await _postService.ListAsync();
            return posts;
        }
    }
}

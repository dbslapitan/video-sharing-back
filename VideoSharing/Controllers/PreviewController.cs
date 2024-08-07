using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VideoSharing.DTOs;
using VideoSharing.Models;
using VideoSharing.Services;

namespace VideoSharing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreviewController : ControllerBase
    {
        PreviewService _service;
        private readonly IMapper _mapper;

        public PreviewController(PreviewService service, IMapper mapper) 
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VideoDetailDto>>> GetAll()
        {
            var result = await _service.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<VideoDetailDto>>(result));
        }

        [HttpGet]
        [Route("Trending")]
        public async Task<ActionResult<IEnumerable<VideoDetailDto>>> GetTrending()
        {
            var result = await _service.GetTrendingAsync();
            return Ok(_mapper.Map<IEnumerable<VideoDetailDto>>(result));
        }

        [HttpGet]
        [Route("Recommendations")]
        public async Task<ActionResult<IEnumerable<VideoDetailDto>>> GetRecommendations()
        {
            var result = await _service.GetRecommendationsAsync();
            return Ok(_mapper.Map<IEnumerable<VideoDetailDto>>(result));
        }

        [HttpGet]
        [Route("Bookmarks/{id}")]
        public async Task<ActionResult<IEnumerable<int>>> GetBookmarks(int id)
        {
            var result = await _service.GetBookmarksAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("Bookmarks")]
        public IActionResult PostBookmark(Bookmark bookmark)
        {
            _service.AddBookmark(bookmark);
            return Created();
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Http;
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
        public IEnumerable<VideoDetailDto> GetAll()
        {
            var result = _service.GetAll();
            return _mapper.Map<IEnumerable<VideoDetailDto>>(result);
        }

        [HttpGet]
        [Route("Trending")]
        public IEnumerable<Video> GetTrending()
        {
            return _service.GetAll();
        }
    }
}

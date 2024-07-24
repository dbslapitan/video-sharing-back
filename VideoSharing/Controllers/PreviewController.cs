using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoSharing.Models;
using VideoSharing.Services;

namespace VideoSharing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreviewController : ControllerBase
    {
        PreviewService _service;

        public PreviewController(PreviewService service) 
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Video> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("Trending")]
        public IEnumerable<Video> GetTrending()
        {
            return _service.GetAll();
        }
    }
}

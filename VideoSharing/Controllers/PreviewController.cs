using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoSharing.DTOs;
using VideoSharing.Models;
using VideoSharing.Services;
using Amazon.S3;
using Amazon.S3.Model;
using System.Data.Entity.Core.Objects;
using Amazon;

namespace VideoSharing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreviewController : ControllerBase
    {
        PreviewService _service;
        private readonly IMapper _mapper;
        private readonly IAmazonS3 _s3Client;

        public PreviewController(PreviewService service, IMapper mapper, IAmazonS3 s3Client) 
        {
            _service = service;
            _mapper = mapper;
            _s3Client = s3Client;
        }

        [HttpGet]
        public IEnumerable<VideoDetailDto> GetAll()
        {
            var result = _service.GetAll();

            return _mapper.Map<IEnumerable<VideoDetailDto>>(result);
        }

        [HttpGet]
        [Route("Trending")]
        public IEnumerable<VideoDetailDto> GetTrending()
        {
            var result = _service.GetTrending();
            return _mapper.Map<IEnumerable<VideoDetailDto>>(result);
        }

        [HttpGet]
        [Route("Recommendations")]
        public IEnumerable<VideoDetailDto> GetRecommendations()
        {
            var result = _service.GetRecommendations();
            return _mapper.Map<IEnumerable<VideoDetailDto>>(result);
        }
    }
}

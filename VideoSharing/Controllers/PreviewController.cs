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
            try
            {
                var request = new GetPreSignedUrlRequest()
                {
                    BucketName = "video-sharing-preview",
                    Key = "112.jpg",
                    Expires = DateTime.UtcNow.AddHours(2)
                };
                string signedUrl = _s3Client.GetPreSignedURL(request);
            }
            catch (AmazonS3Exception ex)
            {
                Console.WriteLine($"Error:'{ex.Message}'");
            }

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

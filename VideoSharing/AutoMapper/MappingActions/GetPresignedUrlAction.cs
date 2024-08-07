using Amazon.S3;
using Amazon.S3.Model;
using AutoMapper;
using VideoSharing.DTOs;
using VideoSharing.Models;

namespace VideoSharing.AutoMapper.MappingActions
{
    public class GetPresignedUrlAction : IMappingAction<Video, VideoDetailDto>
    {
        private readonly IAmazonS3 _amazonS3;

        public GetPresignedUrlAction(IAmazonS3 amazonS3)
        {
            _amazonS3 = amazonS3;
        }

        public void Process(Video video, VideoDetailDto videoDetailDto, ResolutionContext resolutionContext) 
        {
            try
            {
                var request = new GetPreSignedUrlRequest()
                {
                    BucketName = "video-sharing-preview",
                    Key = video.Filename,
                    Expires = DateTime.UtcNow.AddHours(2)
                };
                videoDetailDto.Source = _amazonS3.GetPreSignedURL(request);
            }
            catch (AmazonS3Exception ex)
            {
                Console.WriteLine(ex.Message);
                videoDetailDto.Source = string.Empty;
            }
        }
    }
}

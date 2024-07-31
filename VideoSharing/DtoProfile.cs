using AutoMapper;
using VideoSharing.DTOs;
using VideoSharing.Models;

namespace VideoSharing
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            CreateMap<Video, VideoDetailDto>().ForMember(dto => dto.Username, opt => opt.MapFrom(video => video.User!.Username));
        }
    }
}

using AutoMapper;
using VideoSharing.AutoMapper.MappingActions;
using VideoSharing.DTOs;
using VideoSharing.Models;

namespace VideoSharing.AutoMapper.Profiles
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            CreateMap<Video, VideoDetailDto>()
                .ForMember(dto => dto.Source, opt => opt.Ignore())
                .ForMember(dto => dto.Username, opt => opt.MapFrom(video => video.User!.Username))
                .AfterMap<GetPresignedUrlAction>();

            CreateMap<Bookmark, BookmarkMinDto>().ReverseMap();
        }
    }
}

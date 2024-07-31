using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VideoSharing.Data;
using VideoSharing.DTOs;
using VideoSharing.Models;

namespace VideoSharing.Services
{
    public class PreviewService
    {
        private readonly VideoSharingContext _context;
        private readonly IMapper _mapper;

        public PreviewService(VideoSharingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Video> GetAll()
        {
            return _context.Videos.Include(p => p.User).ToList();
        }
    }
}

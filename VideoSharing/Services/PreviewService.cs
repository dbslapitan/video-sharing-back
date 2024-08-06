using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VideoSharing.Data;
using VideoSharing.DTOs;
using VideoSharing.Models;

namespace VideoSharing.Services
{
    public class PreviewService
    {
        private readonly int[] trending = [0, 1, 2, 3, 4];
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

        public IEnumerable<Video> GetTrending() 
        {
            return _context.Videos.Where(video => trending.Contains(video.Id)).Include(video => video.User).ToList();
        }

        public IEnumerable<Video> GetRecommendations()
        {
            return _context.Videos.Where(video => !trending.Contains(video.Id)).Include(video => video.User).ToList();
        }

        public IEnumerable<int> GetBookmarks(int id)
        {
            return _context.Bookmarks.Where(bookmark => bookmark.UserId == id).Select(bookmark => bookmark.VideoId).ToList();
        }
    }
}

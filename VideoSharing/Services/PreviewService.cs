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

        public async Task<IEnumerable<Video>> GetAllAsync()
        {
            return await _context.Videos.Include(p => p.User).ToListAsync();
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

        public void AddBookmark(Bookmark bookmark)
        {
            var checkBookmark = _context.Bookmarks.Where(db => db.UserId == bookmark.UserId && db.VideoId == bookmark.VideoId).FirstOrDefault();
            if (checkBookmark is null)
            {
                _context.Bookmarks.Add(bookmark);
            }
        }
    }
}

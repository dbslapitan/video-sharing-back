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

        public async Task<IEnumerable<Video>> GetTrendingAsync() 
        {
            return await _context.Videos.Where(video => trending.Contains(video.Id)).AsNoTracking().Include(video => video.User).ToListAsync();
        }

        public async Task<IEnumerable<Video>> GetRecommendationsAsync()
        {
            return await _context.Videos.Where(video => !trending.Contains(video.Id)).AsNoTracking().Include(video => video.User).ToListAsync();
        }

        public async  Task<IEnumerable<int>> GetBookmarksAsync(int id)
        {
            return await _context.Bookmarks.Where(bookmark => bookmark.UserId == id).AsNoTracking().Select(bookmark => bookmark.VideoId).ToListAsync();
        }

        public async Task ChangeBookmarkAsync(BookmarkMinDto bookmark)
        {
            var checkBookmark = await _context.Bookmarks.Where(db => db.UserId == bookmark.UserId && db.VideoId == bookmark.VideoId).FirstOrDefaultAsync();
            if (checkBookmark is null)
            {
                _context.Bookmarks.Add(_mapper.Map<BookmarkMinDto, Bookmark>(bookmark));
            }
            else
            {
                _context.Bookmarks.Remove(checkBookmark);
            }

            await _context.SaveChangesAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using VideoSharing.Data;
using VideoSharing.Models;

namespace VideoSharing.Services
{
    public class PreviewService
    {
        private readonly VideoSharingContext _context;

        public PreviewService(VideoSharingContext context)
        {
            _context = context;
        }

        public IEnumerable<Video> GetAll()
        {
            return _context.Videos.Include(p => p.User).ToList();
        }
    }
}

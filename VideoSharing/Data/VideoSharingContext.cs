using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using VideoSharing.Models;

namespace VideoSharing.Data
{
    public class VideoSharingContext : DbContext
    {

        public VideoSharingContext(DbContextOptions<VideoSharingContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}

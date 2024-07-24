using System.ComponentModel.DataAnnotations;

namespace VideoSharing.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string? Username { get; set; }

        public ICollection<Video>? Bookmarks { get; set; }

    }
}

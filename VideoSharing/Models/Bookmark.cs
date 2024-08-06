using System.ComponentModel.DataAnnotations;

namespace VideoSharing.Models
{
    public class Bookmark
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int VideoId { get; set; }

        public User? User { get; }

        public Video? Video { get; }
    }
}

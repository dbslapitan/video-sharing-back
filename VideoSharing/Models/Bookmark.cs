using System.ComponentModel.DataAnnotations;

namespace VideoSharing.Models
{
    public class Bookmark
    {

        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int VideoId { get; set; }

        public User? User { get; }

        public Video? Video { get; }
    }
}

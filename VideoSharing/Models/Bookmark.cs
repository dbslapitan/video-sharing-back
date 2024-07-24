namespace VideoSharing.Models
{
    public class Bookmark
    {
        public int UserId { get; set; }
        public int VideoId { get; set; }
        public User? User { get; set; }
        public Video? Video { get; set; }
    }
}

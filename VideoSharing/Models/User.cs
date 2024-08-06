using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VideoSharing.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string? Username { get; set; }

    }
}

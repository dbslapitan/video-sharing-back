﻿using System.ComponentModel.DataAnnotations;
using VideoSharing.Models;

namespace VideoSharing.DTOs
{
    public class VideoDetailDto
    {
        public int Id { get; set; }

        public String? Username { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; } = null;

        [Length(4, 4)]
        public int? Year { get; set; }

        [Required]
        public string? Category { get; set; }

        [Required]
        public string? Rating { get; set; }

        [Required]
        public string? Source { get; set; }
    }
}

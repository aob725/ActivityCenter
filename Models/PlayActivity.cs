using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ActivityCenter.Models
{
    public class PlayActivity
    {
        [Key]
        public int PlayActivityId {get; set;}
        [Required]
        public string Title {get; set;}
        [Required]
        [FutureDate]
        public DateTime Time {get; set;}
        [Required]
        public int Duration {get; set;}
        [Required]
        public string Description {get; set;}
        public int UserId {get; set;}
        public User Organizer {get; set;}
        public List<PlayDate> Friends {get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
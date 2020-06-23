using System.ComponentModel.DataAnnotations;

namespace ActivityCenter.Models
{
    public class PlayDate
    {
        [Key]
        public int PlayDateId {get; set;}

        public int UserId {get; set;}
        public int PlayActivityId {get; set;}
        public User Person {get; set;}
        public PlayActivity Activity {get; set;}
    }
}
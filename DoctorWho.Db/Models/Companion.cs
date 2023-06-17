using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db.Models
{
    public class Companion
    {
        public Companion() {
            CompanionName = "";
            WhoPlayed = "";
            Episodes= new List<Episode>();
        }
        [Key]
        public int CompanionId { get; set; }
        [MaxLength(100)]
        public string CompanionName { get; set; }
        public string WhoPlayed { get; set; }
        public List<Episode> Episodes { get; set;}
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CompanionId { get; set; }
        [MaxLength(100)]
        public string CompanionName { get; set; }
        public string WhoPlayed { get; set; }
        public List<Episode> Episodes { get; set;}
    }
}
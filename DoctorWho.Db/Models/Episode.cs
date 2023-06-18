using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Db.Models
{
    public class Episode
    {
        public Episode()
        {
            EpisodeType=string.Empty;
            Title = string.Empty;
            Notes= string.Empty;
            Enemies=new List<Enemy>();
            Companions=new List<Companion>();   
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        [MaxLength(100)]
        public string EpisodeType { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public DateTime EpisodeDate { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public string Notes { get; set; }
        public List<Enemy> Enemies {  get; set; }
        public List<Companion> Companions { get; set; }



    }
}

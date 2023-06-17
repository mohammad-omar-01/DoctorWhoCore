using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db.Models
{
    public class Enemy
    {
        public Enemy()
        {
            EnemyName = string.Empty; ;
            EnemyDescription= string.Empty;
            Episodes = new List<Episode>();

        }
        [Key]
        public int EnemyId { get; set; }
        [MaxLength(50)]
        public string EnemyName { get; set; }
        [MaxLength(100)]
        public string EnemyDescription { get; set;}
        public List<Episode> Episodes { get; set;}
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int EnemyId { get; set; }
        [MaxLength(50)]
        public string EnemyName { get; set; }
        public string EnemyDescription { get; set;}
        public List<Episode> Episodes { get; set;}
    }
}
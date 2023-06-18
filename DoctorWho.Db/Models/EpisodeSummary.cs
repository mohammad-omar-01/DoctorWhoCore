using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Models
{
    public class EpisodeSummary
    {
        public string AuthorName { get; set; } = string.Empty;
        public string DoctorName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string CompainonNames { get; set; } = string.Empty; 
        public string EnemyNames { get; set; }= string.Empty;
    }

}

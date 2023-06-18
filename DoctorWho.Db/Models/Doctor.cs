using DoctorWho.Db.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Doctor
{
    public Doctor()
    {
        DoctorName = "";
        Episodes= new List<Episode>();  
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int DoctorId { get; set; }
    public int DoctorNumber { get; set; }
    [MaxLength(100)]
    public string DoctorName { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime FirstEpisodeDate { get; set; }
    public DateTime LastEpisodeDate { get; set; }
    public List<Episode> Episodes { get; set; }
}

using DoctorWho.Db.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Author
{
    public Author()
    {
        Episodes = new List<Episode>();
        AuthorName = "";
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AuthorId { get; set; }

    [MaxLength(50)]
    public string AuthorName { get; set; }
    public List<Episode> Episodes { get; set; }
}

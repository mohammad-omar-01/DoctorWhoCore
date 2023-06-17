using DoctorWho.Db.Models;
using System.ComponentModel.DataAnnotations;

public class Author
{
    public Author()
    {
        Episodes = new List<Episode>();
        AuthorName = "";
    }

    [Key]
    public int AuthorId { get; set; }

    [MaxLength(50)]
    public string AuthorName { get; set; }
    public List<Episode> Episodes { get; set; }
}

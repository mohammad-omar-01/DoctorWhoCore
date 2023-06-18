using DoctorWho.Db;
using DoctorWho.Db.Repositories;

DoctorWhoCoreContext context = new DoctorWhoCoreContext();

AuthorRepository authorRepository = new AuthorRepository(context);
var result=authorRepository.GetAllAuthors();
foreach (var author in result) { 
Console.WriteLine(author.AuthorName);

}



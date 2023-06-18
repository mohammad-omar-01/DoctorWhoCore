using DoctorWho.Db.Models;
using System.Collections.Generic;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository
    {
        private readonly DoctorWhoCoreContext Context;

        public AuthorRepository(DoctorWhoCoreContext context)
        {
            Context = context;
        }

        public List<Author> GetAllAuthors()
        {
            return Context.Authors.ToList();
        }

        public Author GetAuthorById(int authorId)
        {
            return Context.Authors.Find(authorId);
        }

        public void CreateAuthor(Author author)
        {
            Context.Authors.Add(author);
            Context.SaveChanges();
        }

        public void UpdateAuthor(Author author)
        {
            Context.Authors.Update(author);
            Context.SaveChanges();
        }

        public void DeleteAuthor(int authorId)
        {
            var author = Context.Authors.Find(authorId);
            if (author != null)
            {
                Context.Authors.Remove(author);
                Context.SaveChanges();
            }
        }
    }
}

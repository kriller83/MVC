using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace UpprepningExam
{
    public static class HelperClass
    {
        public static List<Author> listAllAuthors()
        {
            using (var ctx = new BooksEntities())
            {
                List<Author> allAuthors = ctx.Authors.ToList();
                return allAuthors;
            }
        }

        public static List<Title> listAllTitles()
        {
            using (var ctx = new BooksEntities())
            {
                List<Title> allTitles = ctx.Titles.ToList();
                return allTitles;
            }
        }

        public static List<Author> SearchForAuthors(string searchInput)
        {
            using (var ctx = new BooksEntities())
            {
                List<Author> searchAuthors =
                    ctx.Authors.Where(e => e.FirstName.StartsWith(searchInput) || e.LastName.StartsWith(searchInput))
                        .ToList();
                return searchAuthors;
            }
        }
        public static void deleteAuthor(int authorId)
        {
            using (var ctx = new BooksEntities())
            {
                Author deletedAuthor = ctx.Authors.Find(authorId);

                if (authorId != null)
                {
                    ctx.Authors.Remove(deletedAuthor);
                    ctx.SaveChanges();
                }
            }
        }
    }
}

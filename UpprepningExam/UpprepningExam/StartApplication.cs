using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpprepningExam
{
   public class StartApplication
   {
       public void Start()
       {
            Console.WriteLine("1. List all authors");
            Console.WriteLine("2. List all books");
            Console.WriteLine("3. Search author");
            Console.WriteLine("4. Remove auhtor");
           string choice = Console.ReadLine();

           if (choice == "1")
           {
               Console.WriteLine("List Author");
               List<Author> listAuthor = HelperClass.ListAllAuthors();
               foreach (Author author in listAuthor)
               {
                   Console.WriteLine("Author:" + author.FirstName + author.LastName);
               }
           }
           if (choice == "2")
           {
               Console.WriteLine("List all Books");
               List<Title> listTitles = HelperClass.ListAllTitles();
               foreach (Title title in listTitles)
               {
                   Console.WriteLine("Title:" + title.Title1 );
               }
           }
           if (choice == "3")
           {
               Console.WriteLine("Search author");
               string searchInput = Console.ReadLine();
               List<Author> listAuthors = HelperClass.SearchForAuthors(searchInput);
               foreach (Author author in listAuthors)
               {
                   Console.WriteLine("Firstname:" + author.FirstName + "lastname:" + author.LastName);
               }
           }
           if (choice == "4")
           {
               int authorId;
                Console.WriteLine("ID of author to delete");
               authorId = int.Parse(Console.ReadLine());

                HelperClass.DeleteAuthor(authorId);

               if (authorId != null)
               {
                   Console.WriteLine("Author deleted");
               }
               else
               {
                   Console.WriteLine("author not found");
               }

           }

       }
   }
}

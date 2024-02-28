using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    static class LinqToSqlSample
    {
        public static void InsertAuthor(Author author)
        {
            using (var dataBook = new DataBookStoreDataContext())
            {
                if (author != null)
                {
                    //insert
                    dataBook.Authors.InsertOnSubmit(author);

                    try
                    {
                        dataBook.SubmitChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        //...
                    }
                }
            }
        }

        public static void UpdateAuthor(int authorId)
        {
            using (var dataBook = new DataBookStoreDataContext())
            {
                //insert
                Author author = dataBook.Authors.Single(x => x.AuthorID == authorId);
                if (author != null)
                {
                    author.AuthorAddress = "Nam Tu Liem, Cau Giay, Ha Noi";
                    try
                    {
                        dataBook.SubmitChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        //...
                    }
                }
            }
        }

        public static void DeleteAuthor(int authorId)
        {
            using (var dataBook = new DataBookStoreDataContext())
            {
                //get author with id
                Author author = dataBook.Authors.Single(x => x.AuthorID == authorId);
                if (author != null)
                {
                    dataBook.Authors.DeleteOnSubmit(author);
                    try
                    {
                        dataBook.SubmitChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        //...
                    }
                }
            }
        }

        public static void PrintAuthors()
        {
            using (var dataBook = new DataBookStoreDataContext())
            {
                //get authors
                var authors = dataBook.Authors.ToList();
                if (authors.Count > 0)
                {
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("ID       |   Ten tac gia\t\t|   Email\t\t|   Diachi");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
                    foreach(var a in authors)
                    {
                        Console.WriteLine("{0,5}    |   {1,-20}\t| {2,-10}\t| {3,20}    ", a.AuthorID, a.AuthorName, a.AuthorEmail, a.AuthorAddress);
                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
                    }
                }
            }
        }

         public static void GetAuthorsByStoreProcedure()
        {
            using(var dataBook = new DataBookStoreDataContext())
            {
                var authors = dataBook.sp_SelectAllAuthor();
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("ID       |   Ten tac gia\t\t|   Email\t\t|   Diachi");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
                foreach (var a in authors)
                {
                    Console.WriteLine("{0,5}    |   {1,-20}\t| {2,-10}\t| {3,20}    ", a.AuthorID, a.AuthorName, a.AuthorEmail, a.AuthorAddress);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    static class LinqToSqlSample
    {
        public static void InsertData(Author author)
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
    }
}

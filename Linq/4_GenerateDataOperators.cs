using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    static class GenerateDataOperators
    {
        public static List<int> RangeMethod(int numberOfElement)
        {
            return Enumerable.Range(10, numberOfElement).ToList(); // sinh ra numberOfElement phan tu tang dan tu 10
        }

        public static List<int> RepeatMethod(int numberOfElement)
        {
            return Enumerable.Repeat(10, numberOfElement).ToList(); // sinh ra numberOfElement phan tu 10
        }

        public static void EmptyMethod()
        {
            var collection1 = Enumerable.Empty<string>();
            var collection2 = Enumerable.Empty<Student>();

            Console.WriteLine("Count: {0}", collection1.Count());
            Console.WriteLine("Type: {0}", collection1.GetType().Name);

            Console.WriteLine("Count: {0}", collection2.Count());
            Console.WriteLine("Type: {0}", collection2.GetType().Name);
        }

        public static void PrintList(List<int> list)
        {
            Console.WriteLine("List:");
            for (int i=0; i<list.Count; i++)
            {
                Console.WriteLine("Index: " + i + " - Value: " + list[i]);
            }
            Console.WriteLine("---");
        }
    }
}

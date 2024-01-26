using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    static class CollectionOperators
    {
        // luu y Student la kieu phuc tap, khong the so sanh 2 doi tuong nhu kieu native
        // nen can cai dat lop StudentComparer, lop nay implement IEqualityComparer<Student> de compare 2 objects
        public static List<Student> UnionMethod(IList<Student> x, IList<Student> y)
        {
            return x.Union(y, new StudentComparer()).ToList(); // lay nhung phan tu khac nhau tu 2 tap hop
        }

        public static List<Student> IntersectMethod(IList<Student> x, IList<Student> y)
        {
            return x.Intersect(y, new StudentComparer()).ToList(); // lay nhung phan tu giong nhau tu 2 tap hop
        }

        public static List<Student> DistinctMethod(IList<Student> x)
        {
            return x.Distinct(new StudentComparer()).ToList(); // lay nhung phan tu khong trung nhau trong x
        }

        public static List<Student> ExceptMethod(IList<Student> x, IList<Student> y)
        {
            return x.Except(y, new StudentComparer()).ToList(); // lay nhung phan tu co trong x ma ko co trong y
        }

        public static void PrintStudentList(List<Student> students)
        {
            Console.WriteLine("Student list:");
            foreach (var s in students)
            {
                Console.WriteLine(s.StudentId + " - " + s.StudentName);
            }
            Console.WriteLine("---");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    static class PartitionOperators
    {
        public static List<Student> SkipMethod(IList<Student> x)
        {
            return x.Skip(2).ToList(); // bo qua 2 phan tu dau tien va tra ve phan con lai
        }

        public static List<Student> SkipWhileMethod(IList<Student> x)
        {
            return x.SkipWhile(s => s.StudentName.Length >= 4).ToList(); // bo qua cac student dau tien co name >=4 va tra ve phan con lai
        }

        public static List<Student> SkipWhileMethod_2(IList<Student> x)
        {
            return x.SkipWhile((s,i) => s.StudentName.Length >= i).ToList(); // bo qua cac student dau tien co name >= index cua mang va tra ve phan con lai
        }

        public static List<Student> TakeMethod(IList<Student> x)
        {
            return x.Take(2).ToList(); // lay 2 phan tu dau tien
        }

        public static List<Student> TakeWhileMethod(IList<Student> x)
        {
            return x.TakeWhile(s => s.StudentName.Length >= 4).ToList(); // lay cac student dau tien co name >= 4
        }

        public static List<Student> TakeWhileMethod_2(IList<Student> x)
        {
            return x.TakeWhile((s, i) => s.StudentName.Length >= i).ToList(); // lay cac student dau tien co name >= index cua mang
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

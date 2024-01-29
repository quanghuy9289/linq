using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    static class ConvertOperators
    {
        public static void ReportTypeProperty<T>(T obj)
        {
            Console.WriteLine("Compile-time type: {0}", typeof(T).Name);
            Console.WriteLine("Actual Type: {0}", obj.GetType().Name);
        }

        public static void AsEnumerableMethod(IList<Student> students)
        {
            ReportTypeProperty(students);
            ReportTypeProperty(students.AsEnumerable());
        }

        public static void AsQueryableMethod(IList<Student> students)
        {
            ReportTypeProperty(students);
            ReportTypeProperty(students.AsQueryable());
        }

        public static void ToArrayMethod(IList<String> list)
        {
            ReportTypeProperty(list);
            ReportTypeProperty(list.ToArray());
        }

        public static void ToListMethod(IList<String> list)
        {
            ReportTypeProperty(list);
            ReportTypeProperty(list.ToList());
        }

        public static void ToDictionaryMethod(IList<Student> students)
        {
            var studentDic = students.ToDictionary<Student, int>(s => s.StudentId);

            foreach(var s in studentDic)
            {
                Console.WriteLine("Key: {0} - Value: {1}", s.Key, s.Value.StudentName);
            }
        }

        public static void CastMethod(IList<Student> students)
        {
            ReportTypeProperty(students);
            ReportTypeProperty(students.Cast<Student>());
        }
    }
}

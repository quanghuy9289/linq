using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class SampleExtensionClass
    {
        // phuong thuc mo rộng cho lớp String
        public static string Reverse (this string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // phuong thuc mo rộng cho lớp IQueryable<T> của System.Linq
        public static string GetStudentName(this IQueryable<Student> source)
        {
            return source.First().StudentName;
        }

        public static bool IsTeenage(Student s)
        {
            return s.Age > 12 && s.Age < 18;
        }

        // phuong thuc mo rộng cho lớp IQueryable<T> của System.Linq
        public static string GetTeenageStudentName(this IQueryable<Student> source, Func<Student, bool> predicate)
        {
            var student = source.First(s => predicate.Invoke(s));
            return student.StudentName;
        }
    }
}

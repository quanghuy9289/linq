using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.AggregateFunctions
{
    class AggregateFunctions
    {
        public static string ListToString()
        {
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            var str = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            return str;
        }

        public static string ListStudentToString(IList<Student> students)
        {
            var res = students.Aggregate<Student, string>(
                "Student names: ", // seed value
                (str, s) => str += s.StudentName + ", ");

            return res;
        }

        public static string ListStudentToStringRemoveLastComma(IList<Student> students)
        {
            var res = students.Aggregate<Student, string, string>(
                "Student names: ", // seed value
                (str, s) => str += s.StudentName + ", ",
                str => str = str.Substring(0, str.Length - 2));

            return res;
        }

        public static int TotalStudentAge(IList<Student> students)
        {
            var res = students.Aggregate<Student, int>(
                0, // seed value
                (age, s) => age += s.Age);

            return res;
        }
    }
}

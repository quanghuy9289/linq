using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Linq
{
    static class Exercise
    {
        public static void SelectAndWhereMultipleTime(IList<Student> students)
        {
            // giong phep AND
            var studentNames = students.Where(s => s.Age > 18).Select(s => s)
                                        .Where(st => st.StandardId > 0).Select(s => s.StudentName);
            PrintList(studentNames.ToList());
        }

        public static void BuildAnonymousStudent(IList<Student> students)
        {
            var teenStudentsName = students.Where(s => s.Age > 12 && s.Age < 20).Select(s => new { StudentName = s.StudentName });

            teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
        }

        public static void GroupStudentByStandardId(IList<Student> students)
        {
            var studentsGroupByStandard = students.Where(s => s.StandardId > 0).GroupBy(s => s.StandardId).Select(g => new { g.Key, g });

            foreach(var group in studentsGroupByStandard)
            {
                Console.WriteLine("Standard Id {0}:", group.Key);
                group.g.ToList().ForEach(s => Console.WriteLine(s.StudentName));
            }
        }

        public static void LeftJoin(IList<Student> students, IList<Standard> standards)
        {
            var studentsGroupByStandard = from stad in standards
                                          join s in students
                                          on stad.StandardId equals s.StandardId
                                          into sg
                                          select new
                                          {
                                              StandardName = stad.StandardName,
                                              Students = sg
                                          };

            foreach (var group in studentsGroupByStandard)
            {
                Console.WriteLine("Standard Name {0}:", group.StandardName);
                group.Students.ToList().ForEach(s => Console.WriteLine(s.StudentName));
            }
        }
        public static void LeftJoinWithOrder(IList<Student> students, IList<Standard> standards)
        {
            var studentsList = from stad in standards
                                          join s in students
                                          on stad.StandardId equals s.StandardId
                                          into sg
                                            from std_grp in sg
                                            orderby stad.StandardName, std_grp.StudentName
                                            select new
                                            {
                                                StandardName = stad.StandardName,
                                                StudentName = std_grp.StudentName
                                            };

            foreach (var st in studentsList)
            {
                Console.WriteLine("Standard Name {0}. Student Name: {1}", st.StandardName, st.StudentName);
            }
        }

        private static void PrintList(List<string> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}

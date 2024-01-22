using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student collection
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentId = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 15 }
            };
            IList<Student> studentList1 = new List<Student>()
            {
            };


            Console.WriteLine(AggregateFunctions.AggregateFunctions.ListToString());
            Console.WriteLine(AggregateFunctions.AggregateFunctions.ListStudentToString(studentList));
            Console.WriteLine(AggregateFunctions.AggregateFunctions.ListStudentToStringRemoveLastComma(studentList1));
            Console.WriteLine(AggregateFunctions.AggregateFunctions.TotalStudentAge(studentList));
            Console.Read();
        }

    }
}

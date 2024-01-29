using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Student collection
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "John", Age = 13},
                new Student() { StudentId = 2, StudentName = "Moin", Age = 21 },
                new Student() { StudentId = 3, StudentName = "Bill", Age = 18 },
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20},
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 15 },
                new Student() { StudentId = 3, StudentName = "Bill", Age = 18 },
            };
            IList<Student> studentList2 = new List<Student>()
            {
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 18 },
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 15 }
            };

            // -------------- ham aggregate --------------
            //Console.WriteLine(AggregateFunctions.AggregateFunctions.ListToString());
            //Console.WriteLine(AggregateFunctions.AggregateFunctions.ListStudentToString(studentList));
            //Console.WriteLine(AggregateFunctions.AggregateFunctions.ListStudentToStringRemoveLastComma(studentList1));
            //Console.WriteLine(AggregateFunctions.AggregateFunctions.TotalStudentAge(studentList));

            // -------------- toan tu dinh luong --------------
            //Console.WriteLine(AggregateFunctions.AggregateFunctions.IsStudentExist(studentList, new Student(3, "Bill", 19)));

            // -------------- toan tu tap hop --------------
            //CollectionOperators.PrintStudentList(CollectionOperators.UnionMethod(studentList, studentList2));
            //CollectionOperators.PrintStudentList(CollectionOperators.IntersectMethod(studentList, studentList2));
            //CollectionOperators.PrintStudentList(CollectionOperators.DistinctMethod(studentList));
            //CollectionOperators.PrintStudentList(CollectionOperators.ExceptMethod(studentList, studentList2));

            // -------------- toan tu phan vung --------------
            //CollectionOperators.PrintStudentList(PartitionOperators.SkipMethod(studentList));
            //CollectionOperators.PrintStudentList(PartitionOperators.SkipWhileMethod(studentList));
            //CollectionOperators.PrintStudentList(PartitionOperators.SkipWhileMethod_2(studentList));
            //CollectionOperators.PrintStudentList(PartitionOperators.TakeMethod(studentList));
            //CollectionOperators.PrintStudentList(PartitionOperators.TakeWhileMethod(studentList));
            //CollectionOperators.PrintStudentList(PartitionOperators.TakeWhileMethod_2(studentList));

            // -------------- toan tu phan vung --------------
            //GenerateDataOperators.PrintList(GenerateDataOperators.RangeMethod(numberOfElement: 5));
            //GenerateDataOperators.PrintList(GenerateDataOperators.RepeatMethod(numberOfElement: 5));
            //GenerateDataOperators.EmptyMethod();

            // -------------- toan tu phan vung --------------
            //ConvertOperators.AsEnumerableMethod(studentList);
            //ConvertOperators.AsQueryableMethod(studentList);
            //ConvertOperators.ToArrayMethod(new List<string>() { "One", "Two", "Three", "Four" });
            //ConvertOperators.ToListMethod(new List<string>() { "One", "Two", "Three", "Four" });
            //ConvertOperators.ToDictionaryMethod(studentList2);
            ConvertOperators.CastMethod(studentList);
            Console.Read();
        }

    }
}

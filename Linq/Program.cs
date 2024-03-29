﻿using System;
using System.Collections.Generic;
using System.Configuration;
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
            //ConvertOperators.CastMethod(studentList);

            // -------------- xu li chuoi --------------
            //string source = @"LINQ extends the language by the addition of query expressions, " +
            //                @" which are akin to SQL statements, and can be used to conveniently extract and " +
            //                @" process data from arrays, enumerable classes, XML documents, relational databases, " +
            //                @" and third-party data sources.";
            //LinqToHandleString.CountApperance(source, "to"); // dem xem tu "to" xuat hien bao nhieu lan trong chuoi source
            //LinqToHandleString.CountNumberOfWordInSource(source); // dem so tu trong doan van ban

            //string text = @"A person can love a god or a person. Love can also " +
            //            @"be a virtue representing human kindness. Here is what we know. " +
            //            @"Interpersonal love refers to love between human beings. " +
            //            @"Since the lust and attraction stages are both considered temporary.";

            //LinqToHandleString.FindSentencesContainsArrayWords(text, new string[] { "love", "human"}); // tim cac cau co chua love va human

            //string aString = "JPL3UE1F--NK78-L2QW-34T";
            //LinqToHandleString.GetNumberInString(aString);
            //LinqToHandleString.GetTheFirstPart(aString, separator: '-');
            //LinqToHandleString.LinqWithRegularExpression();

            //List<string> matrix = new List<string>() { "6, 5, 7, 0", "1, 9, 2, 3", "5, 9, 2, 1" };
            //LinqToHandleString.SortDescMatrixDataInColumnByColumnIndex(matrix, columnIndex: 1);

            //string csvInFile = @"students.csv";
            //string csvOutFile = @"sortedStudents.csv";
            //LinqToHandleString.SortCSVData(csvInFile, csvOutFile);



            // -------------- Exercise --------------
            // Student collection
            IList<Student> students = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "John", Age = 18, StandardId = 1},
                new Student() { StudentId = 2, StudentName = "Steve", Age = 21, StandardId = 1 },
                new Student() { StudentId = 3, StudentName = "Bill", Age = 18, StandardId = 1 },
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20, StandardId = 2},
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 15, StandardId = 2 },
                new Student() { StudentId = 3, StudentName = "Bill", Age = 20 },
            };

            IList<Standard> standardList = new List<Standard>()
            {
                new Standard(){ StandardId = 1, StandardName="Standard 1"},
                new Standard(){ StandardId = 2, StandardName="Standard 2"},
                new Standard(){ StandardId = 3, StandardName="Standard 3"}
            };

            //Exercise.SelectAndWhereMultipleTime(students);
            //Exercise.BuildAnonymousStudent(students);
            //Exercise.GroupStudentByStandardId(students);
            //Exercise.LeftJoin(students, standardList);
            //Exercise.LeftJoinWithOrder(students, standardList);

            // -------------- LINQ to SQL --------------
            Author author1 = new Author()
            {
                AuthorName = "Nguyen Anh Dung",
                AuthorEmail = "sbook@gmail.com",
                AuthorAddress = "Binh Phuoc, Thu Duc, tp Ho Chi Minh"
            };
            Author author2 = new Author()
            {
                AuthorName = "Nguyen Duy Tuan",
                AuthorEmail = "gotino@gmail.com",
                AuthorAddress = "Cau Giay, Ha Noi"
            };
            //LinqToSqlSample.InsertAuthor(author2);

            //LinqToSqlSample.UpdateAuthor(2); // update author with Id=2
            //LinqToSqlSample.PrintAuthors();
            //LinqToSqlSample.DeleteAuthor(2);
            //LinqToSqlSample.GetAuthorsByStoreProcedure();

            // -------------- Extension method --------------
            string s = "Hello";
            Console.WriteLine("Reverse of {0} is: {1}", s, s.Reverse());

            IQueryable<Student> query = students.AsQueryable<Student>();
            Console.WriteLine("First student name: {0}", query.GetStudentName());
            Console.WriteLine("First teenage student name: {0}", query.GetTeenageStudentName(SampleExtensionClass.IsTeenage));
            Console.Read();
        }

    }
}

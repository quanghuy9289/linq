using System;
using System.Collections.Generic;

namespace Linq
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public Student() { }
        public Student(int id, string name, int age)
        {
            StudentId = id;
            StudentName = name;
            Age = age;
        }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentId == y.StudentId
                && x.StudentName.ToLower().Equals(y.StudentName.ToLower())
                && x.Age == y.Age)
            {
                return true;
            }

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentId.GetHashCode();
        }
    }
}

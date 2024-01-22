using System;

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

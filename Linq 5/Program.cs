﻿using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

        // LINQ Query Syntax to find out teenager students
        var teenAgerStudent = from s in studentList
                              where s.Age > 12 && s.Age < 20
                              select s;

        // method syntax
        var some = studentList.Where(n => n.Age > 12 && n.Age < 20);
        
        Console.WriteLine("Teenage Students:");

        foreach (Student std in teenAgerStudent)
        {
            Console.WriteLine(std.StudentName);
         
        }
       
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}
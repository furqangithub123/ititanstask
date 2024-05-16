using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ititans_App1;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            
            // Call the stored procedure
            var studentService = new StudentService(context);
            var studentsList = studentService.GetStudents();

            // Display the result
            Console.WriteLine("Students List");
            foreach (var student in studentsList)
            {
                Console.WriteLine($"StudentId: { student.StudentID }, Student Name: { student.Name }");
            }
        }
    }
}


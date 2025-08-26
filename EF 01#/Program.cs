using EF_01_.Context;
using EF_01_.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
namespace Demo
{
    public class Program 
    {
        public static void Main()
        {
            ITIContext context = new ITIContext();

            using (var cont = new ITIContext())
            {

                var newStudent = new Student()
                {
                    Id = 1,
                    FName = "Mazen",
                    LName = "Fady",
                    Address = "Cairo",
                    Age = 22,
                    Dep_Id = 1
                };
                cont.Students.Add(newStudent);
                cont.SaveChanges();
                Console.WriteLine("Strudent Added ");

                var students = cont.Students.ToList();
                Console.WriteLine("All Students");
                foreach (var S in students)
                {
                    Console.WriteLine($"ID :{S.Id} Fname :{S.FName} Lname : {S.LName} Address: {S.Address} Age : {S.Age} Dep_Id : {S.Dep_Id} ");
                }

                var studentupdate = cont.Students.FirstOrDefault(s => s.Id == 1);
                if (studentupdate != null)
                {
                    studentupdate.Address = "Alex";
                    cont.SaveChanges();
                    Console.WriteLine("Student Updated");
                }

                var studentdelete = cont.Students.FirstOrDefault(s => s.Id == 1);
                if (studentdelete != null)
                {
                    cont.Students.Remove(studentdelete);
                    cont.SaveChanges();
                    Console.WriteLine("Student Deleted");

                }
            }
        }
    
    }




}

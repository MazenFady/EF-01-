using EF_01_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01_.Context
{
    internal class ITIContext : DbContext
    {
        public DbSet<Student> Students {get ; set ;}
        public DbSet<Course> Courses {get ; set ;}
        public DbSet<Instructor> Instructors  {get ; set ;}
        public DbSet<Department> Departments {get ; set ;}
        public DbSet<Topic> Topics {get ; set ;}
        public DbSet<Stud_Course> Stud_Courses   {get ; set ;}
        public DbSet <Course_Inst> Course_Insts  { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = .;database = ITI ; Trusted_Connection = True ; TrustServerCertificate = True ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>(entity =>
            {
                entity.HasKey(e => new { e.inst_ID, e.Course_ID });
                entity.Property(e => e.evaluate);
            });

            modelBuilder.Entity<Stud_Course>(entity =>
            {
                entity.HasKey(e => new { e.stud_ID, e.Course_ID });
                entity.Property(e => e.Grade);

            });

        }
    }

}


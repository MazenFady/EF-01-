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
            modelBuilder.Entity<Student>(builder =>
            {
               builder.ToTable("Students")
                .HasKey(S => S.Id);
                builder.Property(S => S.FName).HasMaxLength(20).IsRequired();
                builder.Property(S => S.LName).HasMaxLength(20).IsRequired();
                builder.Property(S => S.Address).HasMaxLength(100).IsRequired();
                builder.Property(S => S.Age).IsRequired(false);
                builder.HasKey(S => S.Dep_Id);

            });
            modelBuilder.Entity<Course>(builder =>
            {
              builder.ToTable("Courses")
                .HasKey(C => C.ID);
                builder.Property(C => C.Name).HasMaxLength(20).IsRequired().IsUnicode(false);
                builder.Property(C => C.Description).HasMaxLength(100).IsRequired().IsUnicode();
                builder.Property(C => C.Duration).IsRequired();
                builder.HasKey(C => C.Top_ID);
            });
            modelBuilder.Entity<Instructor>(builder =>
            {
               builder.ToTable("Instructors")
                .HasKey(I => I.Id);
                builder.Property(I => I.Name).HasMaxLength(20).IsRequired().IsUnicode(false);
                builder.Property(I => I.Address).HasMaxLength(100).IsRequired();
                builder.Property(I => I.Bouns).HasColumnType("decimal(12,2)").IsRequired();
                builder.Property(I => I.Salary).HasColumnType("decimal(12,2)").IsRequired();
                builder.Property(I => I.HourRate).HasColumnType("decimal(12,2)").IsRequired();
                builder.HasKey(I => I.Dept_ID);
            });
            modelBuilder.Entity<Department>(builder =>
            {
                builder.ToTable("Departments")
                .HasKey(D => D.Id);
                builder.Property(D => D.Name).HasMaxLength(20).IsRequired();
                builder.Property(D => D.HiringDate).HasColumnName("HireDate");
                builder.HasKey(D => D.ins_id);
            });
            modelBuilder.Entity<Topic>(builder =>
            {
             builder.ToTable("Topics")
                .HasKey(T => T.ID);
                builder.Property(T => T.Name).HasMaxLength(20).IsRequired();    

            });


        }
    }

}


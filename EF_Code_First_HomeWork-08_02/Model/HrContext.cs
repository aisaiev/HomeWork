using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Code_First_HomeWork_08_02.Model
{
    public class HrContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<JobGrade> JobGrades { get; set; }

        public DbSet<JobHistory> JobHistories { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Region> Regions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=HrDB;Trusted_Connection=True;");
        }
    }
}

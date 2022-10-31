using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace StoredProcedure 
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // This line will tell entity framework to use stored procedures
            // when inserting, updating and deleting Employees
            modelBuilder.Entity<Employee>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
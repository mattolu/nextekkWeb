using Microsoft.EntityFrameworkCore;

namespace EmployeeWeb
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=OLUSAYOFUNMI\SQLEXPRESS;Database=EmployeeDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
using EmployeesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesAPI.Data
{
    public class EmployeesDBContext: DbContext
    {
        public EmployeesDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }


    }
}

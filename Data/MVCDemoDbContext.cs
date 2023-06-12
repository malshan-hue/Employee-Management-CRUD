using ASPNET_Employee_CRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNET_Employee_CRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

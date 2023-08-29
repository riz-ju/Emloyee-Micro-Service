using Microsoft.EntityFrameworkCore;

namespace EmloyeeService.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { 
        
        }
        public DbSet<Employee> Employees { get; set; } 
    }
}

using Microsoft.EntityFrameworkCore;

using DemoMVC.Models;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
        {
            
        }

        // Use plural naming for DbSet
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; } 
    }
}
using Microsoft.EntityFrameworkCore;

using DemoMVC.Models;
namespace DemoMVC.Data
{
    using Microsoft.EntityFrameworkCore;
    using DemoMVC.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)    
       {} 

        // Use plural naming for DbSet
        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<Student> Student { get; set; } 
        public DbSet<DemoMVC.Models.Employee> Employee { get; set; } = default!;
    }
}
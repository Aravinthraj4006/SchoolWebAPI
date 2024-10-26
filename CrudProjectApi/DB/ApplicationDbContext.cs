using CrudProjectApi.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudProjectApi.DB
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Teachers> Teachers { get; set; } 
        public DbSet<Feedback> Feedback { get; set; } 
        public DbSet<Contact> Contact { get; set; } 
    }
}

using Institution.Model;
using Microsoft.EntityFrameworkCore;

namespace Institution.Data
{
    public class ApplicationDBContext : DbContext
    {
        
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Institution.Model.Snack>? Snack { get; set; }
        
    }
}

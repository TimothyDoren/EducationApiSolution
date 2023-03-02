using Microsoft.EntityFrameworkCore;

namespace EducationApi.Models
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Major> Majors { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }
    }
}


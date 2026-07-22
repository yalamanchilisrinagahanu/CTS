using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore8.Models;

namespace EntityFrameworkCore8.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}

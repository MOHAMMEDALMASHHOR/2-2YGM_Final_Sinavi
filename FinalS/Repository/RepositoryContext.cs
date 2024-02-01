using MAYAZ203.Models;
using Microsoft.EntityFrameworkCore;

namespace MAYAZ203.Repostory;
public class RepositoryContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=School.db");
    }
}
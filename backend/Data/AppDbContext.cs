using Microsoft.EntityFrameworkCore;
using StudentManager.WebAPI.Data.Builders;
using StudentManager.WebAPI.Objects.Models;

namespace StudentManager.WebAPI.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Professor> Professors { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ProfessorBuilder.Build(modelBuilder);
        StudentBuilder.Build(modelBuilder);
    }
}

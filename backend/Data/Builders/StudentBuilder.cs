using Microsoft.EntityFrameworkCore;
using StudentManager.WebAPI.Objects.Models;

namespace StudentManager.WebAPI.Data.Builders;

public class StudentBuilder
{
    public static void Build(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasKey(p => p.Id);
        modelBuilder.Entity<Student>().Property(p => p.Name).IsRequired().HasMaxLength(100);

        modelBuilder.Entity<Student>()
            .HasData(new List<Student>
            {
                new (1, "Miguel Silva"),
                new (2, "Gabriel Oliveira")
            });
    }
}

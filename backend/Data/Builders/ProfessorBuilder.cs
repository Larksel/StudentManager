using Microsoft.EntityFrameworkCore;
using StudentManager.WebAPI.Objects.Models;

namespace StudentManager.WebAPI.Data.Builders;

public class ProfessorBuilder
{
    public static void Build(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Professor>().HasKey(p => p.Id);
        modelBuilder.Entity<Professor>().Property(p => p.Name).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<Professor>().Property(p => p.Email).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<Professor>().Property(p => p.PasswordHash).IsRequired().HasMaxLength(256);

        modelBuilder.Entity<Professor>()
            .HasData(new List<Professor>
            {
                new (1, "José Carlos", "josecarlos@gmail.com", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92")
            });
    }
}

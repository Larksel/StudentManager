using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManager.WebAPI.Objects.Models;

[Table("professor")]
public class Professor
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("passwordhash")]
    public string PasswordHash { get; set; }

    // Relacionamento muitos-para-muitos com Alunos
    public ICollection<Student> Students { get; set; }

    public Professor()
    {
        Students = [];
    }

    public Professor(int professorId, string name, string email, string passwordHash)
    {
        Id = professorId;
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Students = [];
    }
}
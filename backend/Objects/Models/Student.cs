using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManager.WebAPI.Objects.Models;

[Table("student")]
public class Student
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    // Relacionamento muitos-para-muitos com Professores
    public ICollection<Professor> Professors { get; set; }

    public Student()
    {
        Professors = [];
    }

    public Student(int studentId, string name)
    {
        Id = studentId;
        Name = name;
        Professors = [];
    }
}
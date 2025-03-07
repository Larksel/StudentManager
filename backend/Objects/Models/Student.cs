namespace StudentManager.WebAPI.Objects.Models;

public class Student
{
    public int Id { get; set; }
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
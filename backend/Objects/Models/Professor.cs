namespace StudentManager.WebAPI.Objects.Models;

public class Professor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
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
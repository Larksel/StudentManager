using System.ComponentModel.DataAnnotations;

namespace StudentManager.WebAPI.Objects.Dtos.Entities;

public class ProfessorDTO
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é requerido!")]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required(ErrorMessage = "O e-mail é requerido!")]
    [MinLength(10)]
    [MaxLength(100)]
    public string Email 
    {
        get => _email;
        set => _email = value.ToLower(); 
    }
    private string _email;

    [Required(ErrorMessage = "A senha é requerida")]
    [MinLength(8)]
    [MaxLength(100)]
    public string Password { get; set; }
}
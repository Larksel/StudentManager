using System.ComponentModel.DataAnnotations;

namespace StudentManager.WebAPI.Objects.Dtos.Entities;

public class StudentDTO
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é requerido!")]
    [MaxLength(100)]
    public string Name { get; set; }
}

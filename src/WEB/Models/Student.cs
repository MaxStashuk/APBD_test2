using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB.Models;

[Table("Student")]
public class Student
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Surname { get; set; }
    
    [Required]
    [MaxLength(250)]
    [EmailAddress]
    public string Email { get; set; }
    
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB.Models;

[Table("Record")]
public class Record
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public int LanguageId { get; set; }
    
    [ForeignKey("LanguageId")]
    public Language Language { get; set; }
    
    [Required]
    public int TaskId { get; set; }
    
    [ForeignKey("TaskId")]
    public Task Task { get; set; }
    
    [Required]
    public int StudentId { get; set; }
    
    [ForeignKey("StudentId")]
    public Student Student { get; set; }
    
    [Required]
    public long ExecutionTime { get; set; }
    
    [Required]
    public DateTime CreatedAt { get; set; }
}
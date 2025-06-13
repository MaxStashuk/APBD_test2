namespace WEB.Models.DTOs;

public class RecordResponseDTO
{
    public int id { get; set; }
    public LanguageDTO language { get; set; }
    public TaskDTO task { get; set; }
    public StudentDTO student { get; set; }
    public long executionTime { get; set; }
    public DateTime created { get; set; }
}

public class LanguageDTO
{
    public int id { get; set; }
    public string name { get; set; }
}

public class TaskDTO
{
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
}

public class StudentDTO
{
    public int id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
}
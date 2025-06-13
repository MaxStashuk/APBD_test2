using Microsoft.EntityFrameworkCore;
using WEB.Models.DTOs;
using WebApplication1.Contexts;

namespace WEB.Services;

public class RecordService : IRecordService
{
    private readonly DatabaseContext _context;

    public RecordService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<List<RecordResponseDTO>> GetAllRecords()
    {
        var records = await _context.Records
            .Include(r => r.Language)
            .Include(r => r.Task)
            .Include(r => r.Student)
            .Select(r => new RecordResponseDTO
            {
                id = r.Id,
                language = new LanguageDTO
                {
                    id = r.Language.Id,
                    name = r.Language.Name
                },
                task = new TaskDTO
                {
                    id = r.Task.Id,
                    name = r.Task.Name,
                    description = r.Task.Description
                },
                student = new StudentDTO
                {
                    id = r.Student.Id,
                    firstName = r.Student.FirstName,
                    lastName = r.Student.LastName,
                    email = r.Student.Email
                },
                executionTime = r.ExecutionTime,
                created = r.CreatedAt
            })
            .ToListAsync();
            
        return records;
    }
    
}
using WEB.Models.DTOs;

namespace WEB.Services;

public interface IRecordService
{
    public Task<List<RecordResponseDTO>> GetAllRecords();
}
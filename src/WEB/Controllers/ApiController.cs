using Microsoft.AspNetCore.Mvc;
using WEB.Services;

namespace WEB.Controllers;

[ApiController]
[Route("api/records")]
public class ApiController : ControllerBase
{
    private readonly IRecordService _service;

    public ApiController(IRecordService serv)
    {
        _service = serv;
    }

    [HttpGet("")]
    public async Task<IActionResult> GetCustomerPurchases(int id)
    {
        var result = await _service.GetAllRecords();
        

        return Ok(result);
    }
}
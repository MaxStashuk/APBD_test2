using Microsoft.AspNetCore.Mvc;
using WEB.Services;

namespace WEB.Controllers;

[ApiController]
[Route("api/records")]
public class ApiController : ControllerBase
{
    private readonly IRecordService _service;

    public CustomersController(IRecordService serv)
    {
        _service = serv;
    }

    [HttpGet("")]
    public async Task<IActionResult> GetCustomerPurchases(int id)
    {
        var result = await _customerService.GetCustomerPurchasesAsync(id);

        if (result == null)
            return NotFound($"Customer with id {id} not found");

        return Ok(result);
    }
}
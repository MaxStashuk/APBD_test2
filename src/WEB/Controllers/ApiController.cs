using Microsoft.AspNetCore.Mvc;
using WEB.Services;

namespace WEB.Controllers;

[ApiController]
[Route("api/customers")]
public class ApiController : ControllerBase
{
    private readonly IRecordService _service;

    public CustomersController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet("{id}/purchases")]
    public async Task<IActionResult> GetCustomerPurchases(int id)
    {
        var result = await _customerService.GetCustomerPurchasesAsync(id);

        if (result == null)
            return NotFound($"Customer with id {id} not found");

        return Ok(result);
    }
}
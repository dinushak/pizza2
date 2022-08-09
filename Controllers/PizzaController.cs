using Microsoft.AspNetCore.Mvc;
using System.Text;
using PizzaService.Data;
using Microsoft.EntityFrameworkCore;

namespace PizzaService.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    private readonly DataContext _context;

    public PizzaController(DataContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetPizzaOrders")]
    public async Task<ActionResult<List<PizzaOrder>>>  Get()
    {
        return Ok(await _context.PizzaOrders.ToListAsync());
    }
}

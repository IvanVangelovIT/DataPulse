using API.Data.DataBase;
using API.Data.Entities.DesignPattern.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/design-patterns")]
public class DesignPatternController : ControllerBase
{
    private readonly DataPulseContext context;

    public DesignPatternController(DataPulseContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<DesignPatternEntity>>> GetAll()
    {
        return this.Ok(await context.DesignPatterns.ToListAsync());
    }

    [HttpGet("id")]
    public async Task<ActionResult<DesignPatternEntity>> GetById([FromRoute] int id)
    {
        return this.Ok(await context.DesignPatterns.FirstOrDefaultAsync(x => x.Id == id));
    }
}

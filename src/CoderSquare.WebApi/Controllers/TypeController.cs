using CoderSquare.Application.Service.TypeServices;
using CoderSquare.Domain.DTOs.TypeModels;
using Microsoft.AspNetCore.Mvc;

namespace CoderSquare.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TypeController(ITypeService service) : ControllerBase
{
    // GET: api/types
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await service.GetAllTypeAsync());

    // GET: api/types/5
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetByIdAsync(int id)
        => Ok(await service.GetByIdTypeAsync(id));

    // POST: api/types
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] TypeCreateDto dto)
        => Ok(await service.CreatedTypeAsync(dto));

    // PUT: api/types/5
    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateAsync(int id, [FromBody] TypeUpdateDto dto)
        => Ok(await service.UpdateTypeAsync(dto, id));

    // DELETE: api/types/5
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteAsync(int id)
        => Ok(await service.DeleteTypeAsync(id));
}

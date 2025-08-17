using CoderSquare.Application.DTOs.ProblemDto;
using CoderSquare.Application.Service.ProblemServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoderSquare.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProblemController(IProblemService service) : ControllerBase
{
    [HttpGet("get-all-problems")]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await service.GetAllAsync());

    [HttpGet("get-by-id-room/{id:int}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var result = await service.GetByIsAsync(id);
        if (!result.Success)
            return NotFound(result.Message);
        return Ok(result);
    }

    [HttpPost("create-room")]
    public async Task<IActionResult> CreateAsync([FromBody] ProblemCreateDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var result = await service.CreateAsync(dto);
        if (!result.Success)
            return BadRequest(result.Message);

        return Ok(result);
    }

    [HttpPut("update-room-by-id/{id:int}")]
    public async Task<IActionResult> UpdateAsync(int id, [FromBody] ProblemCreateDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var result = await service.UpdateAsync(dto , id);
        if (!result.Success)
            return NotFound(result.Message);
        return Ok(result);
    }

    [HttpDelete("delete-room-by-id/{id:int}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await service.DeleteAsync(id);
        if (!result.Success)
            return NotFound(result.Message);
        return Ok(result);
    }
}

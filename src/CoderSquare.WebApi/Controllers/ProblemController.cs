using CoderSquare.Application.Service.ProblemServices;
using CoderSquare.Domain.DTOs.ProblemModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoderSquare.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProblemController(IProblemService service) : ControllerBase
{
    // GET: api/problems
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
        => Ok(await service.GetAllProblemAsync());

    // GET: api/problems/5
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetByIdAsync(int id)
        => Ok(await service.GetByIdProblemAsync(id));

    // GET: api/problems/by-topic/{topicName}
    [HttpGet("by-topic/{topicName}")]
    public async Task<IActionResult> GetByTopicAsync(string topicName)
        => Ok(await service.GetProblemsByTopic(topicName));

    // GET: api/problems/by-name/{problemName}
    [HttpGet("by-name/{problemName}")]
    public async Task<IActionResult> GetByNameAsync(string problemName)
        => Ok(await service.GetProblemsByName(problemName));

    // POST: api/problems
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] ProblemCreateDto dto)
        => Ok(await service.CreatedProblemAsync(dto));

    // PUT: api/problems/5
    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateAsync(int id, [FromBody] ProblemUpdateDto dto)
        => Ok(await service.UpdateProblemAsync(dto, id));

    // DELETE: api/problems/5
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteAsync(int id)
        => Ok(await service.DeleteProblemAsync(id));
}

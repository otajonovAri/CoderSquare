using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoderSquare.Application.Responses;
using CoderSquare.DataAccess.Data;
using CoderSquare.Domain.DTOs.ProblemModels;
using CoderSquare.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoderSquare.Application.Service.ProblemServices;

public class ProblemService(AppDbContext context , IMapper mapper) : IProblemService
{
    public async Task<ApiResult<IEnumerable<ProblemResponseDto>>> GetAllProblemAsync()
    {
        var problems = await context.Problems
            .ProjectTo<ProblemResponseDto>(mapper.ConfigurationProvider)
            .ToListAsync();

        return new ApiResult<IEnumerable<ProblemResponseDto>>("Success", true, problems);
    }

    public async Task<ApiResult<ProblemResponseDto>> GetByIdProblemAsync(int id)
    {
        var problem = await context.Problems.FirstOrDefaultAsync(x => x.Id == id);

        if (problem is null)
            return new ApiResult<ProblemResponseDto>("Problem Not Found", false, null!);

        return new ApiResult<ProblemResponseDto>("Success", true, mapper.Map<ProblemResponseDto>(problem));
    }

    public async Task<ApiResult<IEnumerable<ProblemResponseDto>>> GetProblemsByTopic(string topicName)
    {
        var problems = await context
            .Problems
            .Where(x => x.ProblemName == topicName)
            .ProjectTo<ProblemResponseDto>(mapper.ConfigurationProvider)
            .ToListAsync();

        return new ApiResult<IEnumerable<ProblemResponseDto>>("Success", true, problems);
    }

    public async Task<ApiResult<ProblemResponseDto>> GetProblemsByName(string problemName)
    {
        var problem = await context.Problems.FirstOrDefaultAsync(x => x.ProblemName == problemName);

        if (problem is null)
            return new ApiResult<ProblemResponseDto>("Problem Not Found", false, null!);

        return new ApiResult<ProblemResponseDto>("Success", true, mapper.Map<ProblemResponseDto>(problem));
    }

    public async Task<ApiResult<object>> CreatedProblemAsync(ProblemCreateDto dto)
    {
        var entity = mapper.Map<Problem>(dto);
        await context.Problems.AddAsync(entity);
        await context.SaveChangesAsync();
        return new ApiResult<object>("Success", true, $"{entity.Id} - Created Success Fully");
    }

    public async Task<ApiResult<object>> UpdateProblemAsync(ProblemUpdateDto dto, int id)
    {
        var problem = await context.Problems.FirstOrDefaultAsync(x => x.Id == id);

        if (problem is null) return new ApiResult<object>("Problem Not Found", false, null!);

        mapper.Map(dto, problem);
        context.Problems.Update(problem);
        await context.SaveChangesAsync();

        return new ApiResult<object>("Success", true, $"{problem.Id} - Update Success Fully");
    }

    public async Task<ApiResult<object>> DeleteProblemAsync(int id)
    {
        var problem = await context.Problems.FirstOrDefaultAsync(x => x.Id == id);

        if (problem is null)
            return new ApiResult<object>("Problem not found", false, null!);

        context.Problems.Remove(problem);
        await context.SaveChangesAsync();

        return new ApiResult<object>("Success", true, $"{problem.Id} - Deleted Success Fully");
    }
}
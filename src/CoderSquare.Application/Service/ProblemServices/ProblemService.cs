using System.Runtime.InteropServices;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoderSquare.Application.DTOs.ProblemDto;
using CoderSquare.Application.Repositories.ProblemRepository;
using CoderSquare.Application.Responses;
using CoderSquare.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoderSquare.Application.Service.ProblemServices;

public class ProblemService(IProblemRepository repo , IMapper mapper) : IProblemService
{
    public async Task<ApiResult<List<ProblemResponseDto>>> GetAllAsync()
    {
        var problems = await repo.GetAll()
            .ProjectTo<ProblemResponseDto>(mapper.ConfigurationProvider)
            .ToListAsync();

        return new ApiResult<List<ProblemResponseDto>>("Success", true, problems);
    }

    public async Task<ApiResult<ProblemResponseDto>> GetByIsAsync(int id)
    {
        var problem = await repo.GetByIdAsync(id);

        if (problem is null) 
            return new ApiResult<ProblemResponseDto>("Problem not found", false, null!);

        return new ApiResult<ProblemResponseDto>("Success", true, mapper.Map<ProblemResponseDto>(problem));
    }

    public async Task<ApiResult<object>> CreateAsync(ProblemCreateDto dto)
    {
        var entity = mapper.Map<Problem>(dto);

        await repo.AddAsync(entity);
        await repo.SaveChangesAsync();

        return new ApiResult<object>("Problem Create" , true , dto);
    }

    public async Task<ApiResult<object>> UpdateAsync(ProblemCreateDto dto, int id)
    {
        var existing = await repo.GetByIdAsync(id);

        if(existing is null)
            return new ApiResult<object>("Problem Not Found" , false , null!);

        mapper.Map(dto, existing);
        repo.Update(existing);
        await repo.SaveChangesAsync();

        return new ApiResult<object>("Problem Update", true, $"{existing.Id}");
    }

    public async Task<ApiResult<object>> DeleteAsync(int id)
    {
        var existing = await repo.GetByIdAsync(id);

        if (existing is null) return new ApiResult<object>("Problem not found", false, null!);

        repo.Delete(existing);
        await repo.SaveChangesAsync();

        return new ApiResult<object>("Problem Deleted", true , $"{existing.Id}");
    }
}
using CoderSquare.Application.DTOs.ProblemDto;
using CoderSquare.Application.Responses;

namespace CoderSquare.Application.Service.ProblemServices;

public interface IProblemService
{
    Task<ApiResult<List<ProblemResponseDto>>> GetAllAsync();
    Task<ApiResult<ProblemResponseDto>> GetByIsAsync(int id);
    Task<ApiResult<object>> CreateAsync(ProblemCreateDto dto);
    Task<ApiResult<object>> UpdateAsync(ProblemCreateDto dto, int id);
    Task<ApiResult<object>> DeleteAsync(int id);
}
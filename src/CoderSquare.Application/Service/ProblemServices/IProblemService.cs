using CoderSquare.Application.Responses;
using CoderSquare.Domain.DTOs.ProblemModels;

namespace CoderSquare.Application.Service.ProblemServices;

public interface IProblemService
{
    Task<ApiResult<IEnumerable<ProblemResponseDto>>> GetAllProblemAsync();
    Task<ApiResult<ProblemResponseDto>> GetByIdProblemAsync(int id);
    Task<ApiResult<IEnumerable<ProblemResponseDto>>> GetProblemsByTopic(string topicName);
    Task<ApiResult<ProblemResponseDto>> GetProblemsByName(string problemName);
    Task<ApiResult<object>> CreatedProblemAsync(ProblemCreateDto dto);
    Task<ApiResult<object>> UpdateProblemAsync(ProblemUpdateDto dto , int id);
    Task<ApiResult<object>> DeleteProblemAsync(int id);
}
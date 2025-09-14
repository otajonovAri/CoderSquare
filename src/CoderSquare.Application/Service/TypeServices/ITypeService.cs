using CoderSquare.Application.Responses;
using CoderSquare.Domain.DTOs.TypeModels;

namespace CoderSquare.Application.Service.TypeServices;

public interface ITypeService
{
    Task<ApiResult<IEnumerable<TypeResponseDto>>> GetAllTypeAsync();
    Task<ApiResult<TypeResponseDto>> GetByIdTypeAsync(int id);
    Task<ApiResult<object>> CreatedTypeAsync(TypeCreateDto dto);
    Task<ApiResult<object>> UpdateTypeAsync(TypeUpdateDto dto , int id);
    Task<ApiResult<object>> DeleteTypeAsync(int id);
}
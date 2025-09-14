using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoderSquare.Application.Responses;
using CoderSquare.DataAccess.Data;
using CoderSquare.Domain.DTOs.TypeModels;
using Microsoft.EntityFrameworkCore;
using Type = CoderSquare.Domain.Entities.Type;

namespace CoderSquare.Application.Service.TypeServices;

public class TypeService(AppDbContext context , IMapper mapper) : ITypeService
{
    public async Task<ApiResult<IEnumerable<TypeResponseDto>>> GetAllTypeAsync()
    {
        var types = await context.Types
            .ProjectTo<TypeResponseDto>(mapper.ConfigurationProvider)
            .ToListAsync();

        return new ApiResult<IEnumerable<TypeResponseDto>>("Success", true, types);
    }

    public async Task<ApiResult<TypeResponseDto>> GetByIdTypeAsync(int id)
    {
        var type = await context.Types.FirstOrDefaultAsync(x => x.Id == id);

        if (type is null) return new ApiResult<TypeResponseDto>("Type Not Found", false, null!);

        return new ApiResult<TypeResponseDto>("Success", true, mapper.Map<TypeResponseDto>(type));
    }

    public async Task<ApiResult<object>> CreatedTypeAsync(TypeCreateDto dto)
    {
        var entity = mapper.Map<Type>(dto);
        await context.Types.AddAsync(entity);
        await context.SaveChangesAsync();
        return new ApiResult<object>("Success", true, $"{entity.Id} - Created Success Fully");
    }

    public async Task<ApiResult<object>> UpdateTypeAsync(TypeUpdateDto dto, int id)
    {
        var entity = await context.Types.FirstOrDefaultAsync(x => x.Id == id);

        if (entity is null) return new ApiResult<object>("Type Not Found", false, null!);

        mapper.Map(dto, entity);
        context.Types.Update(entity);
        await context.SaveChangesAsync();

        return new ApiResult<object>("Success", true, $"{entity.Id} - Updated Success Fully");
    }

    public async Task<ApiResult<object>> DeleteTypeAsync(int id)
    {
        var entity = await context.Types.FirstOrDefaultAsync(x => x.Id == id);

        if (entity is null)
            return new ApiResult<object>("Not Found Types", false, null!);

        context.Types.Remove(entity);
        await context.SaveChangesAsync();

        return new ApiResult<object>("Success", true, $"{entity.Id} - Deleted Success Fully");
    }
}
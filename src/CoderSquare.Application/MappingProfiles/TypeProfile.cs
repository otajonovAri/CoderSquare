using AutoMapper;
using CoderSquare.Domain.DTOs.TypeModels;
using Type = CoderSquare.Domain.Entities.Type;

namespace CoderSquare.Application.MappingProfiles;

public class TypeProfile : Profile
{
    public TypeProfile()
    {
        CreateMap<Type, TypeResponseDto>();
        CreateMap<TypeCreateDto, Type>();
        CreateMap<TypeUpdateDto, Type>()
            .ForAllMembers(opt
                => opt.Condition((src, dest, srcMember)
                    => srcMember != null));
    }
}
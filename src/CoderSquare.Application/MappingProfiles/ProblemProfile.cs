using AutoMapper;
using CoderSquare.Domain.DTOs.ProblemModels;
using CoderSquare.Domain.Entities;

namespace CoderSquare.Application.MappingProfiles;

public class ProblemProfile : Profile
{
    public ProblemProfile()
    {
        CreateMap<Problem, ProblemResponseDto>();
        CreateMap<ProblemCreateDto, Problem>();
        CreateMap<ProblemUpdateDto , Problem>()
            .ForAllMembers(opt
                => opt.Condition((src, dest, srcMember)
                    => srcMember != null));
    }
}
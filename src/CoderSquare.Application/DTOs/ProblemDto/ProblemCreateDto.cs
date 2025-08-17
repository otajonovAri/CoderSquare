using CoderSquare.Domain.Entities;
using CoderSquare.Domain.Enum;

namespace CoderSquare.Application.DTOs.ProblemDto;

public class ProblemCreateDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Difficulty Difficulty { get; set; }
    public string Tags { get; set; }

    public long CreatorId { get; set; }
    public User Creator { get; set; }
}
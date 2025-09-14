using CoderSquare.Domain.Enum;

namespace CoderSquare.Domain.DTOs.ProblemModels;

public class ProblemUpdateDto
{
    public string ProblemName { get; set; } = null!;
    public Difficulty ProblemDifficulty { get; set; } = Difficulty.Easy;
    public string ProblemLink { get; set; } = null!;
}
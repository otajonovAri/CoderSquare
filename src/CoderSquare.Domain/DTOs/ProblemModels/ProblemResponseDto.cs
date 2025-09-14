using CoderSquare.Domain.Enum;

namespace CoderSquare.Domain.DTOs.ProblemModels;

public class ProblemResponseDto
{
    public int Id { get; set; }
    public string ProblemName { get; set; }
    public Difficulty ProblemDifficulty { get; set; } 
    public string ProblemLink { get; set; } 
}
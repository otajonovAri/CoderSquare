using CoderSquare.Domain.Common;
using CoderSquare.Domain.Enum;

namespace CoderSquare.Domain.Entities;

public class Problem : BaseEntity
{
    public string ProblemName { get; set; } = null!;
    public Difficulty ProblemDifficulty { get; set; } = Difficulty.Easy;
    public string ProblemLink { get; set; } = null!;

    public ICollection<ProblemType> ProblemTypes { get; set; }
}
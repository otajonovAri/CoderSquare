using CoderSquare.Domain.Common;

namespace CoderSquare.Domain.Entities;

public class Type : BaseEntity
{
    public string ProblemType { get; set; } = null!;
    public ICollection<ProblemType> ProblemTypes { get; set; }
}
using CoderSquare.Domain.Common;

namespace CoderSquare.Domain.Entities;

public class ProblemType : BaseEntity
{
    public int ProblemId { get; set; }
    public Problem Problem { get; set; }

    public int TypeId { get; set; }
    public Type Type { get; set; }
}
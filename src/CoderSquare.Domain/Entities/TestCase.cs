using CoderSquare.Domain.Common;

namespace CoderSquare.Domain.Entities;

public class TestCase : BaseEntity
{
    public long ProblemId { get; set; }
    public Problem Problem { get; set; }

    public string Input { get; set; }
    public string Expected { get; set; }
    public bool IsSample { get; set; }
}
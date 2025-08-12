using CoderSquare.Domain.Common;

namespace CoderSquare.Domain.Entities;

public class ProblemComment : BaseEntity
{
    public long UserId { get; set; }
    public User User { get; set; }

    public long ProblemId { get; set; }
    public Problem Problem { get; set; }

    public string Content { get; set; }
}
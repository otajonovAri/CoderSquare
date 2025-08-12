using CoderSquare.Domain.Common;

namespace CoderSquare.Domain.Entities;

public class ProblemNote : BaseEntity
{
    public long UserId { get; set; }
    public User User { get; set; }

    public long ProblemId { get; set; }
    public Problem Problem { get; set; }

    public string NoteText { get; set; }
}
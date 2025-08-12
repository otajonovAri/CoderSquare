using CoderSquare.Domain.Common;
using CoderSquare.Domain.Enum;

namespace CoderSquare.Domain.Entities;

public class Submission : BaseEntity
{
    public long UserId { get; set; }
    public User User { get; set; }

    public long ProblemId { get; set; }
    public Problem Problem { get; set; }

    public long LanguageId { get; set; }
    public Language Language { get; set; }

    public string Code { get; set; }
    public SubmissionStatus Status { get; set; }
    public string Output { get; set; }
    public float? TimeUsed { get; set; }
    public float? MemoryUsed { get; set; }
}
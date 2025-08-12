using CoderSquare.Domain.Common;

namespace CoderSquare.Domain.Entities;

public class Language : BaseEntity
{
    public string Name { get; set; }
    public int JudgeId { get; set; }
    public ICollection<Submission> Submissions { get; set; }
}
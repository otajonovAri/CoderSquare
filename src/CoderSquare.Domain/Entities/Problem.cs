using CoderSquare.Domain.Common;
using CoderSquare.Domain.Enum;

namespace CoderSquare.Domain.Entities;

public class Problem : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Difficulty Difficulty { get; set; }
    public string Tags { get; set; }

    public long CreatorId { get; set; }
    public User Creator { get; set; }

    public ICollection<TestCase> TestCases { get; set; }
    public ICollection<Submission> Submissions { get; set; }
    public ICollection<ProblemLike> Likes { get; set; }
    public ICollection<ProblemComment> Comments { get; set; }
    public ICollection<ProblemNote> Notes { get; set; }
}
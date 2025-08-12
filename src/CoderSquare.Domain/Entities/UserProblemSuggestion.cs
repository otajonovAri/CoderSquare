using CoderSquare.Domain.Common;
using CoderSquare.Domain.Enum;

namespace CoderSquare.Domain.Entities;

public class UserProblemSuggestion : BaseEntity
{
    public long UserId { get; set; }
    public User User { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
    public Difficulty Difficulty { get; set; }
    public string Tags { get; set; }
    public bool IsApproved { get; set; } = false;
}
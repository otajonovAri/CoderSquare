using CoderSquare.Domain.Common;

namespace CoderSquare.Domain.Entities;

public class UserStats : BaseEntity
{
    public long UserId { get; set; }
    public User User { get; set; }

    public long SolvedCount { get; set; }
    public long TotalSubmits { get; set; }
    public float Accuracy { get; set; }
}
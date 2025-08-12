using CoderSquare.Domain.Common;

namespace CoderSquare.Domain.Entities;

public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Solt { get; set; }
    public string PhoneNumber { get; set; }

    public long RoleId { get; set; }
    public UserRole Role { get; set; }

    public long? ConfirmedId { get; set; }
    public UserConfirme? Confirmed { get; set; }

    public ICollection<RefreshToken> RefreshTokens { get; set; }
    public ICollection<UserStats> UserStats { get; set; }
    public ICollection<Submission> Submissions { get; set; }
    public ICollection<ProblemLike> LikedProblems { get; set; }
    public ICollection<ProblemComment> Comments { get; set; }
    public ICollection<ProblemNote> Notes { get; set; }
    public ICollection<UserProblemSuggestion> ProblemSuggestions { get; set; }
}
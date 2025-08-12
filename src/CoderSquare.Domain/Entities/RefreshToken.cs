using CoderSquare.Domain.Common;

namespace CoderSquare.Domain.Entities;

public class RefreshToken : BaseEntity
{
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public bool IsRevoked { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }
}
using CoderSquare.Domain.Common;

namespace CoderSquare.Domain.Entities;

public class UserConfirme : BaseEntity
{
    public string Gmail { get; set; }
    public bool IsConfirmed { get; set; }
    public string ConfirmingCode { get; set; }
    public DateTime ExpiredDate { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }
}
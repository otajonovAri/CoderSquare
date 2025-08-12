using CoderSquare.Domain.Common;

namespace CoderSquare.Domain.Entities;

public class UserRole : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<User> Users { get; set; }
}
using Ubee.Domain.Commons;

namespace Ubee.Domain.Entities;

public class Transaction : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }
    public decimal Amount { get; set; }
    public string Note { get; set; }
}

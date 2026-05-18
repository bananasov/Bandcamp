namespace Bandcamp.API.Models.Account;

public class AccountRequest(long fanId, string olderThanToken)
{
    public long FanId { get; set; } = fanId;
    public string OlderThanToken { get; set; } = olderThanToken;
    public int? Count { get; set; }
}
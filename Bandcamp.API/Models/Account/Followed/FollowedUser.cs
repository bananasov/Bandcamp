namespace Bandcamp.API.Models.Account.Followed;

public class FollowedUser
{
    public long FanId { get; set; }
    public long? BandId { get; set; }
    public string? FanUrl { get; set; }
    public string? ImageId { get; set; }
    public string TrackpipeUrl { get; set; }
    public string Name { get; set; }
    public bool IsFollowing  { get; set; }
    public string? Location  { get; set; }
    public string DateFollowed  { get; set; }
    public string Token { get; set; }
}
namespace Bandcamp.API.Models.Account.Followers;

public class Follower
{
    public long FanId { get; set; }
    public long? BandId { get; set; }
    public long? AvatarId { get; set; }
    public string TrackpipeUrl { get; set; }
    public string Name { get; set; }
    public bool IsFollowing { get; set; }
    public string? Location {  get; set; }
    public string DateFollowed { get; set; }
    public string Token { get; set; }
}
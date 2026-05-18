using System.Text.Json;

namespace Bandcamp.API.Models.Account.Followed;

public class FollowedArtist
{
    public long BandId { get; set; }
    public long? ImageId { get; set; }
    public long ArtId { get; set; }
    public UrlHints UrlHints { get; set; }
    public string Name { get; set; }
    public bool IsFollowing { get; set; }
    public JsonElement IsSubscribed { get; set; }
    public string? Location { get; set; }
    public string DateFollowed { get; set; }
    public string Token { get; set; }
}

public class UrlHints
{
    public string Subdomain { get; set; }
    public string? CustomDomain { get; set; }
}
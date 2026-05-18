using System.Text.Json.Serialization;

namespace Bandcamp.API.Models.Account.Followed;

public class FollowedArtistsResponse
{
    [JsonPropertyName("followeers")]
    public List<FollowedArtist> FollowedArtists { get; set; }
    public bool MoreAvailable { get; set; }
    public string LastToken { get; set; }
}
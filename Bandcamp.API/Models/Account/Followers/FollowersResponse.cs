using System.Text.Json.Serialization;

namespace Bandcamp.API.Models.Account.Followers;

public class FollowersResponse
{
    [JsonPropertyName("followeers")]
    public List<Follower> Followers { get; set; }
    public bool MoreAvailable { get; set; }
    public string LastToken { get; set; }
}
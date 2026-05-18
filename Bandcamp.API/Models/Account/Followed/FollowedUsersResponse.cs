using System.Text.Json.Serialization;

namespace Bandcamp.API.Models.Account.Followed;

public class FollowedUsersResponse
{
    [JsonPropertyName("followeers")]
    public List<FollowedUser> FollowedUsers { get; set; }
    public bool MoreAvailable { get; set; }
    public string LastToken { get; set; }
}
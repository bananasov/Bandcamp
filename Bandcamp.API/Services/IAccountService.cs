using Bandcamp.API.Models.Account.Followed;
using Bandcamp.API.Models.Account;
using Refit;

namespace Bandcamp.API.Services;

public interface IAccountService
{
    [Post("/fancollection/1/following_bands")]
    Task<FollowedArtistsResponse> GetFollowedArtists([Body] AccountRequest request);
    
    [Post("/fancollection/1/following_fans")]
    Task<FollowedUsersResponse> GetFollowedUsers([Body] AccountRequest request);
    
    [Post("/fancollection/1/followers")]
    Task<FollowedUsersResponse> GetFollowers([Body] AccountRequest request);
}
using Bandcamp.API;
using Bandcamp.API.Models.Account;

var bandcampApi = new BandcampApi();

var epoch = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
var request = new AccountRequest(11443438, epoch.ToString());
var response = await bandcampApi.Account.GetFollowedArtists(request);

foreach (var artist in response.FollowedArtists)
{
    Console.WriteLine(artist.Name);
}
using System.Text.Json;
using Bandcamp.API.Services;
using Refit;

namespace Bandcamp.API;

public class BandcampApi : IDisposable
{
    public IAccountService Account { get; }
    // public IDiscoveryService Discovery { get; }
    // public ILibraryService Library { get; }
    // public ISearchService Search { get; }

    private readonly HttpClient _httpClient;

    public BandcampApi(string endpoint = "https://bandcamp.com/api")
    {
        var refitSettings = BuildSettings();

        _httpClient = new HttpClient()
        {
            BaseAddress = new Uri(endpoint),
            Timeout = TimeSpan.FromSeconds(5)
        };

        Account = RestService.For<IAccountService>(_httpClient, refitSettings);
        // Discovery = RestService.For<IDiscoveryService>(_httpClient, refitSettings);
        // Library = RestService.For<ILibraryService>(_httpClient, refitSettings);
        // Search = RestService.For<ISearchService>(_httpClient, refitSettings);
    }

    private static RefitSettings BuildSettings()
    {
        return new RefitSettings
        {
            ContentSerializer = new SystemTextJsonContentSerializer(
                new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
                }),
        };
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}
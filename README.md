SpotifyAPI-NET 
===

A Wrapper for Spotify's Web API, written in .NET, modified to work with client side (WebAssembly) Blazor

**Spotify's Web API** ([link](https://developer.spotify.com/web-api/))
> Based on simple REST principles, our Web API endpoints return metadata in JSON format about artists, albums, and tracks directly from the Spotify catalogue.
> The API also provides access to user-related data such as playlists and music saved in a “Your Music” library, subject to user’s authorization.

**SpotifyAPI.Web** [![Nuget SpotifyAPI.Web](https://badge.fury.io/nu/SpotifyAPI.Web.svg)](https://www.nuget.org/packages/SpotifyAPI.Web/)
> A wrapper around Spotify's Web API, providing sync and async methods to query all possible endpoints. Results are returned as typed class instances, allowing property-based access.

### Docs and Usage

More Information, Installation-Instructions, Examples and API-Reference can be found at [github.io/SpotifyAPI-Net/](http://johnnycrazy.github.io/SpotifyAPI-NET/)

### Example

```c#
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;

public static async void Example()
{
  SpotifyWebAPI api = new SpotifyWebAPI
  {
      AccessToken = "XX?X?X",
      TokenType = "Bearer"
  };
  
  PrivateProfile profile = await api.GetPrivateProfileAsync();
  if(!profile.HasError()) {
    Console.WriteLine(profile.DisplayName);
  }
}
```

### Donations

If you want to support this project or JohnnyCrazy's work in general, you can donate a buck or two via the link below. However, this will be always optional!

[![Donate Link](./donate.svg)](https://paypal.me/JohnnyCrazy)

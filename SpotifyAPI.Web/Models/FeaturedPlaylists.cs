using Newtonsoft.Json;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class FeaturedPlaylists : BasicModel
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("playlists")]
        public Paging<SimplePlaylist> Playlists { get; set; }
    }
}
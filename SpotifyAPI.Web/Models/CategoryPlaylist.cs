using Newtonsoft.Json;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class CategoryPlaylist : BasicModel
    {
        [JsonProperty("playlists")]
        public Paging<SimplePlaylist> Playlists { get; set; }
    }
}
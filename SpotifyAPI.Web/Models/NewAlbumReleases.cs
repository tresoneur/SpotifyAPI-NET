using Newtonsoft.Json;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class NewAlbumReleases : BasicModel
    {
        [JsonProperty("albums")]
        public Paging<SimpleAlbum> Albums { get; set; }
    }
}
using Newtonsoft.Json;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class FollowedArtists : BasicModel
    {
        [JsonProperty("artists")]
        public CursorPaging<FullArtist> Artists { get; set; }
    }
}
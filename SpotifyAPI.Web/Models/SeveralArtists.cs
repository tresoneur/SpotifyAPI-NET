using System.Collections.Generic;
using Newtonsoft.Json;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class SeveralArtists : BasicModel
    {
        [JsonProperty("artists")]
        public List<FullArtist> Artists { get; set; }
    }
}
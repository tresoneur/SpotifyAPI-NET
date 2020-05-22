using System.Collections.Generic;
using Newtonsoft.Json;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class RecommendationSeedGenres : BasicModel
    {
         [JsonProperty("genres")]
         public List<string> Genres { get; set; }
    }
}
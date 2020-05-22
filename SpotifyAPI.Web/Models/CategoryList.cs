using Newtonsoft.Json;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class CategoryList : BasicModel
    {
        [JsonProperty("categories")]
        public Paging<Category> Categories { get; set; }
    }
}
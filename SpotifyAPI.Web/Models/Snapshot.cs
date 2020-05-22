using Newtonsoft.Json;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class Snapshot : BasicModel
    {
        [JsonProperty("snapshot_id")]
        public string SnapshotId { get; set; }
    }
}
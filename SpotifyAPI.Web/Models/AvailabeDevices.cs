using System.Collections.Generic;
using Newtonsoft.Json;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class AvailabeDevices : BasicModel
    {
        [JsonProperty("devices")]
        public List<Device> Devices { get; set; }
    }
}
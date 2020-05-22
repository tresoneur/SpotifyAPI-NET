using System.Collections.Generic;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class ListResponse<T> : BasicModel
    {
        public List<T> List { get; set; }
    }
}
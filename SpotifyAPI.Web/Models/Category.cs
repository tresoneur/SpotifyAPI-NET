﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class Category : BasicModel
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("icons")]
        public List<Image> Icons { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
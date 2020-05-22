﻿using System.Net;

namespace Caerostris.Services.Spotify.Web.SpotifyAPI.Web.Models
{
    public class ResponseInfo
    {
        public WebHeaderCollection Headers { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public static readonly ResponseInfo Empty = new ResponseInfo();
    }
}
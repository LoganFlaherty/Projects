﻿using Newtonsoft.Json;

namespace Storytime_Bot
{
    internal struct ConfigJSON
    {
        [JsonProperty("Token")]
        public string Token { get; set; }
        [JsonProperty("Prefix")]
        public string Prefix { get; set; }
    }
}

﻿using Newtonsoft.Json;

namespace ClashLand.Logic
{
    public class Achievement
    {
        [JsonProperty("data")]
        public int Data { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
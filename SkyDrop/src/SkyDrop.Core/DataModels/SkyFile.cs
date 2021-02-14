using System;
using Newtonsoft.Json;

namespace SkyDrop.Core.DataModels
{
    public class SkyFile
    {
        [JsonProperty("skylink")]
        public string Skylink { get; set; }

        [JsonProperty("merkelroot")]
        public string Merkelroot { get; set; }

        [JsonProperty("bitfield")]
        public long BitField { get; set; }

        public string Filename { get; set; }
    }
}

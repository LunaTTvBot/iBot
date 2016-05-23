using Newtonsoft.Json;

namespace IBot.TwitchAPI.Models
{
    internal class Badge
    {
        [JsonProperty("alpha")]
        public string Alpha { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }
}
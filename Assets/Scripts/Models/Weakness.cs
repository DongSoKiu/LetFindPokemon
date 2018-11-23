using Newtonsoft.Json;

namespace Assets.Scripts.Models
{
    public class Weakness
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
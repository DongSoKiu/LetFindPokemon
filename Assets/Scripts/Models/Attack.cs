using System.Collections.Generic;
using Newtonsoft.Json;

namespace Assets.Scripts.Models
{
    public class Attack
    {
        [JsonProperty("cost")]
        public List<string> Cost { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("damage")]
        public string Damage { get; set; }

        [JsonProperty("convertedEnergyCost")]
        public int ConvertedEnergyCost { get; set; }
    }
}
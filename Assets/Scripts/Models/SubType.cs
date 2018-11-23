using System.Collections.Generic;
using Newtonsoft.Json;

namespace Assets.Scripts.Models
{
    public class SubType
    {
        [JsonProperty("subtypes")]
        public List<string> Types { get; set; }
    }
}
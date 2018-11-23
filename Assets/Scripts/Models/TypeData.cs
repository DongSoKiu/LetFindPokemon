using System.Collections.Generic;
using Newtonsoft.Json;

namespace Assets.Scripts.Models
{
    public class TypeData
    {
        [JsonProperty("types")]
        public List<string> Types { get; set; }
    }
}
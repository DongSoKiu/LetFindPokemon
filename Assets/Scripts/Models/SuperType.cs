using System.Collections.Generic;
using Newtonsoft.Json;

namespace Assets.Scripts.Models
{
    public class SuperType
    {
        [JsonProperty("supertypes")]
        public List<string> Types { get; set; }
    }
}
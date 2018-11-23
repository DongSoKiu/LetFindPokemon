using System.Collections.Generic;
using Assets.Scripts.Models;
using Newtonsoft.Json;

namespace Assets.Scripts
{
    public class Set
    {
        [JsonProperty("sets")]
        public List<SetData> Cards { get; set; }

        [JsonProperty("set")]
        public SetData Card { get; set; }
    }
}
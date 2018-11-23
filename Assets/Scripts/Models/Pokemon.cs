using System.Collections.Generic;
using Assets.Scripts.Models;
using Newtonsoft.Json;

namespace Assets.Scripts
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Pokemon
    {
        [JsonProperty("cards")]
        public List<PokemonCard> Cards { get; set; }

        [JsonProperty("card")]
        public PokemonCard Card { get; set; }

        public List<string> Errors { get; set; }
    }
}
using System.Collections.Generic;
using Assets.Scripts.Models;
using Newtonsoft.Json;

namespace Assets.Scripts
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Trainer
    {
        [JsonProperty("cards")]
        public List<TrainerCard> Cards { get; set; }

        [JsonProperty("card")]
        public TrainerCard Card { get; set; }

        public List<string> Errors { get; set; }
    }
}
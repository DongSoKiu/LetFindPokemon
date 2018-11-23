using System.Collections.Generic;
using Newtonsoft.Json;

namespace Assets.Scripts.Models
{
    public class TrainerCard : BaseCard
    {
        [JsonProperty("text")]
        public List<string> Text { get; set; }
    }
}
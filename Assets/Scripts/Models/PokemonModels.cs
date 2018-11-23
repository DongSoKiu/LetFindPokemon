﻿namespace Assets.Scripts.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class PokemonModels
    {
        [JsonProperty("pokemon")]
        public List<Pokemon> Pokemon { get; set; }
    }

    public partial class Pokemon
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("num")]
        public string Num { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("img")]
        public Uri Img { get; set; }

        [JsonProperty("type")]
        public List<TypeElement> Type { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("candy")]
        public string Candy { get; set; }

        [JsonProperty("candy_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? CandyCount { get; set; }

        [JsonProperty("egg")]
        public Egg Egg { get; set; }

        [JsonProperty("spawn_chance")]
        public double SpawnChance { get; set; }

        [JsonProperty("avg_spawns")]
        public double AvgSpawns { get; set; }

        [JsonProperty("spawn_time")]
        public string SpawnTime { get; set; }

        [JsonProperty("multipliers")]
        public List<double> Multipliers { get; set; }

        [JsonProperty("weaknesses")]
        public List<TypeElement> Weaknesses { get; set; }

        [JsonProperty("next_evolution", NullValueHandling = NullValueHandling.Ignore)]
        public List<Evolution> NextEvolution { get; set; }

        [JsonProperty("prev_evolution", NullValueHandling = NullValueHandling.Ignore)]
        public List<Evolution> PrevEvolution { get; set; }
    }

    public partial class Evolution
    {
        [JsonProperty("num")]
        public string Num { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum Egg { NotInEggs, OmanyteCandy, The10Km, The2Km, The5Km };

    public enum TypeElement { Bug, Dark, Dragon, Electric, Fairy, Fighting, Fire, Flying, Ghost, Grass, Ground, Ice, Normal, Poison, Psychic, Rock, Steel, Water };

    public partial class PokemonModels
    {
        public static PokemonModels FromJson(string json) => JsonConvert.DeserializeObject<PokemonModels>(json, Assets.Scripts.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this PokemonModels self) => JsonConvert.SerializeObject(self, Assets.Scripts.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                EggConverter.Singleton,
                TypeElementConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class EggConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Egg) || t == typeof(Egg?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "10 km":
                    return Egg.The10Km;
                case "2 km":
                    return Egg.The2Km;
                case "5 km":
                    return Egg.The5Km;
                case "Not in Eggs":
                    return Egg.NotInEggs;
                case "Omanyte Candy":
                    return Egg.OmanyteCandy;
            }
            throw new Exception("Cannot unmarshal type Egg");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Egg)untypedValue;
            switch (value)
            {
                case Egg.The10Km:
                    serializer.Serialize(writer, "10 km");
                    return;
                case Egg.The2Km:
                    serializer.Serialize(writer, "2 km");
                    return;
                case Egg.The5Km:
                    serializer.Serialize(writer, "5 km");
                    return;
                case Egg.NotInEggs:
                    serializer.Serialize(writer, "Not in Eggs");
                    return;
                case Egg.OmanyteCandy:
                    serializer.Serialize(writer, "Omanyte Candy");
                    return;
            }
            throw new Exception("Cannot marshal type Egg");
        }

        public static readonly EggConverter Singleton = new EggConverter();
    }

    internal class TypeElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeElement) || t == typeof(TypeElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Bug":
                    return TypeElement.Bug;
                case "Dark":
                    return TypeElement.Dark;
                case "Dragon":
                    return TypeElement.Dragon;
                case "Electric":
                    return TypeElement.Electric;
                case "Fairy":
                    return TypeElement.Fairy;
                case "Fighting":
                    return TypeElement.Fighting;
                case "Fire":
                    return TypeElement.Fire;
                case "Flying":
                    return TypeElement.Flying;
                case "Ghost":
                    return TypeElement.Ghost;
                case "Grass":
                    return TypeElement.Grass;
                case "Ground":
                    return TypeElement.Ground;
                case "Ice":
                    return TypeElement.Ice;
                case "Normal":
                    return TypeElement.Normal;
                case "Poison":
                    return TypeElement.Poison;
                case "Psychic":
                    return TypeElement.Psychic;
                case "Rock":
                    return TypeElement.Rock;
                case "Steel":
                    return TypeElement.Steel;
                case "Water":
                    return TypeElement.Water;
            }
            throw new Exception("Cannot unmarshal type TypeElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeElement)untypedValue;
            switch (value)
            {
                case TypeElement.Bug:
                    serializer.Serialize(writer, "Bug");
                    return;
                case TypeElement.Dark:
                    serializer.Serialize(writer, "Dark");
                    return;
                case TypeElement.Dragon:
                    serializer.Serialize(writer, "Dragon");
                    return;
                case TypeElement.Electric:
                    serializer.Serialize(writer, "Electric");
                    return;
                case TypeElement.Fairy:
                    serializer.Serialize(writer, "Fairy");
                    return;
                case TypeElement.Fighting:
                    serializer.Serialize(writer, "Fighting");
                    return;
                case TypeElement.Fire:
                    serializer.Serialize(writer, "Fire");
                    return;
                case TypeElement.Flying:
                    serializer.Serialize(writer, "Flying");
                    return;
                case TypeElement.Ghost:
                    serializer.Serialize(writer, "Ghost");
                    return;
                case TypeElement.Grass:
                    serializer.Serialize(writer, "Grass");
                    return;
                case TypeElement.Ground:
                    serializer.Serialize(writer, "Ground");
                    return;
                case TypeElement.Ice:
                    serializer.Serialize(writer, "Ice");
                    return;
                case TypeElement.Normal:
                    serializer.Serialize(writer, "Normal");
                    return;
                case TypeElement.Poison:
                    serializer.Serialize(writer, "Poison");
                    return;
                case TypeElement.Psychic:
                    serializer.Serialize(writer, "Psychic");
                    return;
                case TypeElement.Rock:
                    serializer.Serialize(writer, "Rock");
                    return;
                case TypeElement.Steel:
                    serializer.Serialize(writer, "Steel");
                    return;
                case TypeElement.Water:
                    serializer.Serialize(writer, "Water");
                    return;
            }
            throw new Exception("Cannot marshal type TypeElement");
        }

        public static readonly TypeElementConverter Singleton = new TypeElementConverter();
    }

}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StarWars.Domain.Entities;

namespace StarWars.Lib.Tools
{
    public class StarshipWrapper
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }

        [JsonProperty("results")]
        public List<Starship> Starships { get; set; }
    }
}

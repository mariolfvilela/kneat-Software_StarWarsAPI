using System;
using System.Collections.Generic;
using Star_Wars.Domain.Common;

namespace Star_Wars.Domain.Entities
{
    public class Starship : EntityBase
    {
        public Starship() { }

        public string name { get; set; }
        public string model { get; set; }
        public string manufacturer { get; set; }
        public string cost_in_credits { get; set; }
        public string length { get; set; }
        public string max_atmosphering_speed { get; set; }
        public string crew { get; set; }
        public string passengers { get; set; }
        public string cargo_capacity { get; set; }
        public string consumables { get; set; }
        public string hyperdrive_rating { get; set; }
        public string MGLT { get; set; }
        public string starship_class { get; set; }
        public IList<string> pilots { get; set; }
        public IList<string> films { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
        public string resupplyFrequency { get; set; }
    }
}

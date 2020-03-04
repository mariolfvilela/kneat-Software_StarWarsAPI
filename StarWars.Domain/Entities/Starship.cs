using System;
using System.Collections.Generic;
using StarWars.Domain.Common;

namespace StarWars.Domain.Entities
{
    public class Starship : EntityBase
    {
        public Starship() { }

        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Cost_in_credits { get; set; }
        public string Length { get; set; }
        public string Max_atmosphering_speed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        public string Cargo_capacity { get; set; }
        public string Consumables { get; set; }
        public string Hyperdrive_rating { get; set; }
        public string MGLT { get; set; }
        public string Starship_class { get; set; }
        public IList<string> Pilots { get; set; }
        public IList<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
        public string ResupplyFrequency { get; set; }
    }
}

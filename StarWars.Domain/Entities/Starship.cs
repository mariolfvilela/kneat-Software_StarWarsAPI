using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        /// <summary>
        /// The Maximum number of Megalights this starship can travel in a standard hour.
        /// </summary>
        public string MGLT { get; set; }
        public string Starship_class { get; set; }
        //[DataMember(Name = "pilots")]
        //public IList<Pilot>? Pilots { get; set; }
        //public IList<Film>? Films { get; set; }
        public string Url { get; set; }
        public string ResupplyFrequency { get; set; }
    }
}

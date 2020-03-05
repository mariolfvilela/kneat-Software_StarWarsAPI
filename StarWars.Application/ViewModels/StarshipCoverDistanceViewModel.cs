using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StarWars.Domain.Entities;

namespace StarWars.Application.ViewModels
{
    public class StarshipCoverDistanceViewModel : ViewModelBase
    {
        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }
        /// <summary>
        /// The Maximum number of Megalights this starship can travel in a standard hour.
        /// </summary>
        public string MGLT { get; set; }
        public string Consumables { get; set; }
        public string ToStop { get; set; }
    }
}

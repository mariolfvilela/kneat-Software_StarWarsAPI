using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Application.ViewModels
{
    public class StarshipCoverDistanceViewModel : ViewModelBase
    {
        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }
        public string MGLT { get; set; }
    }
}

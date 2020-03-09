using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Domain.Entities
{
    public class Pilot
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 60 caracteres")]
        public string Name { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Star_Wars.Application.ViewModels
{
    public class StarshipViewModel: ViewModelBase
    {

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "The E-mail is Required")]
        //[EmailAddress]
        //[DisplayName("E-mail")]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "The BirthDate is Required")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        //[DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        //[DisplayName("Birth Date")]
        //public DateTime BirthDate { get; set; }

        
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


        public string Mensagem { get; set; }
        public string Exception { get; set; }
        public List<string> Mensagens { get; set; }
    }
}

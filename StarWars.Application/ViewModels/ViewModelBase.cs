using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Application.ViewModels
{
    public class ViewModelBase
    {


        /// <summary>
        /// Identificação (Identity)
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Data de criação do registro.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Data de alteração do registro.
        /// </summary>
        public DateTime? LastModified { get; set; }
    }
}

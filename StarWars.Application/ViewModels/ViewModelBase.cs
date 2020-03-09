using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Application.ViewModels
{
    public class ViewModelBase
    {
        /// <summary>
        /// Identificação (Identity)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Data de criação do registro.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Data de alteração do registro.
        /// </summary>
        public DateTime? LastModified { get; set; }

        public string Mensagem { get; set; }
        public string Exception { get; set; }
        public List<string> Mensagens { get; set; }
    }
}

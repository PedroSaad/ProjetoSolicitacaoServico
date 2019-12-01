using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Servicos")]
   public class Servico 
    {
        [Key]
        public int ServicoId { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int VezesUtilizado { get; set; }

    }
}

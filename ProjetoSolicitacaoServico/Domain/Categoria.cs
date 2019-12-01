using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Categoria")]
  public  class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Nome { get; set; }


    }
}

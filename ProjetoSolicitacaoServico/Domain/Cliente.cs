using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Clientes")]
    public class Cliente
    {
        public Cliente() { Endereco = new Endereco(); }
        [Key]
        public long IdCliente { get; set; }
        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [EmailAddress]
        public string Email { get; set; }
        [Display (Name = "Senha")]
        [Required (ErrorMessage = "Campo Obrigatorio!")]
        public string Senha { get; set; }
        [Display(Name = "Confirmacao Senha")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Compare("Senha", ErrorMessage = "Os campos não coincidem!")]
        [NotMapped]
        public string ConfirmacaoSenha { get; set; }
        [Display(Name = "Razao Social")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public string RazaoSocial { get; set; }
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public string Telefone { get; set;}
        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]

        public string Cnpj { get; set; }

        public Endereco Endereco { get; set; }

    }
}

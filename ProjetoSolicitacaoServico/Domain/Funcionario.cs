using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Funcionarios")]
   public class Funcionario 
    {


        public Funcionario() { Endereco = new Endereco(); }
        [Key]
        public long IdFuncionario { get; set; }
        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public string Senha { get; set; }
        [Display(Name = "Confirmacao Senha")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        [Compare("Senha", ErrorMessage = "Os campos não coincidem!")]
        [NotMapped]
        public string ConfirmacaoSenha { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public string Nome { get; set; }
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public string Telefone { get; set; }
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public string Cpf { get; set; }
        public double Avaliacao { get; set; }
        [Display(Name = "Salario")]
        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public double Salario { get; set; }
        public double MediaAvaliacao { get; set; }
        public int IsAdmin { get; set; }
        public int NumeroAvaliacao { get; set; }
        
        public Endereco Endereco { get; set; }




    }
}

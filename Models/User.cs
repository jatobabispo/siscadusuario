using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisCadUsuario.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,200}$",
         ErrorMessage = "Contém caracteres não permitidos.")]
        public string? Name { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Este email não é válido")]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [RegularExpression(@"[0-9]{11}", ErrorMessage = "CPF inválido.Informe o CPF com apenas os dígitos")]
        // [RegularExpression(@"[/^\d{3}\.\d{3}\.\d{3}\-\d{2}$/]{11}", ErrorMessage = "CPF inválido. O CPF deve conter 11 caracteres e apenas dígitos")]
        public long? CPF { get; set; }
        [Required]
        [Display(Name = "Data Cadastro")]
        
        public DateTime? Created_at { get; set; }
        [Required] [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Required]
        [Display(Name = "Telefone")]
        [RegularExpression(@"[0-9]{10,11}", ErrorMessage = "Digite somente os numeros com o DDD.")]
        public long? Phone { get; set; }
        public string? Perfil { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        [Display(Name = "Número")]
        public long? Number { get; set; }
        [Display(Name = "Cidade")]
        public string? City { get; set; }
        [Display(Name = "Estado")]
        public string? State { get; set; }
        [Display(Name = "País")]
        public string? Country { get; set; }
        [RegularExpression(@"[0-9]{8}", ErrorMessage = "CEP inválido.Informe o CEP com apenas os dígitos")]
        public int? CEP { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Entidades
{
    [Table("Contatos")]
    public class Contato
    {

        [Key]
        public int ContatoId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(150)]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [MaxLength(20)]
        public string Telefone { get; set; }
        [DataType(DataType.PostalCode)]
        [MaxLength(10)]
        [Required]
        public string Cep { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(200)]
        public string Mensagem { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data do Contato")]
        public DateTime DataContato { get; set; }
        public string Origem { get; set; }//Beneficiario, Credenciado, etc...
        public int Status { get; set; }
    }
}

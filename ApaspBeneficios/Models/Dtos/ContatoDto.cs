using EscolaLumiart.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Dtos
{
    public class ContatoDto
    {
        public int ContatoId { get; set; }
        
        public string Nome { get; set; }
       
        public string Email { get; set; }
        
        public string Telefone { get; set; }
       
        public string Cep { get; set; }
        
        public string Mensagem { get; set; }
        
        public DateTime DataContato { get; set; }
        public string Origem { get; set; }//Beneficiario, Credenciado, etc...
        public int Status { get; set; }

        public Contato ConverterParaEntidade()
        {
            return new Contato
            {
                ContatoId = this.ContatoId,
                Nome = this.Nome,
                Email = this.Email,
                Telefone = this.Telefone,
                Cep = this.Cep,
                Mensagem = this.Mensagem,
                DataContato = this.DataContato,
                Origem = this.Origem,
                Status = this.Status
            };


        }
    }
}

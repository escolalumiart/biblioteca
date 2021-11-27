using EscolaLumiart.Models.Entidades;
using EscolaLumiart.Models.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Dtos
{
    public class LivroDto:EntidadeBase
    {

        public string Nome{ get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }

        public int StatusLivroId { get; set; }

        public string Status { get; set; }

        public LivroDto()
        {
          
        }

        public Livro ConverterParaEntidade()
        {
            return new Livro
            {
                Id = this.Id,
                Nome = this.Nome,
                Autor = this.Autor,
                Editora = this.Editora,
                StatusLivro = GerenciadorDeStatus.PesquisarStatusDoLivroPeloId(this.StatusLivroId)
            };
           

        }
         

    }
}

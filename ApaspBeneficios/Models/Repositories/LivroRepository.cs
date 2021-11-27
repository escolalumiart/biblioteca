using EscolaLumiart.Models.Dtos;
using EscolaLumiart.Models.Entidades;
using EscolaLumiart.Models.Interfaces.Contexts;
using EscolaLumiart.Models.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EscolaLumiart.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly IContextData _contextData;

        public LivroRepository(IContextData contextData)
        {
            _contextData = contextData;
        }
        public void Atualizar(Livro livro)
        {
            _contextData.AtualizarLivro(livro);
        }

        public void Cadastrar(Livro livro)
        {
            _contextData.CadasTrarLivros(livro);
        }

        public List<Livro> Listar()
        {
            return _contextData.ListarLivro();
        }

        public Livro PesquisarPorId(string id)
        {
            return _contextData.PesquisarLivroPorId(id);
        }

        public void Excluir(string id)
        {
            _contextData.ExcluirLivro(id);
            
        }
    }
}

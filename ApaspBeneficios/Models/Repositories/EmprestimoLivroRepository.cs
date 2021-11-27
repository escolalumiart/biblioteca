using EscolaLumiart.Models.Entidades;
using EscolaLumiart.Models.Interfaces.Contexts;
using EscolaLumiart.Models.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Repositories
{
    public class EmprestimoLivroRepository : IEmprestimoLivroRepository
    {
        private readonly IContextData _contextData;

        public EmprestimoLivroRepository(IContextData contextData)
        {
            _contextData = contextData;
        }
        public void EfetuarEmprestimo(EmprestimoLivro emprestimoLivro)
        {
            _contextData.EfetuarEmprestimoLivro(emprestimoLivro);
        }

        public void Efetuar_devolucao(EmprestimoLivro emprestimoLivro)
        {
            _contextData.EfetuarDevolucaoLivro(emprestimoLivro);
        }
    }
}

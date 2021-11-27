using EscolaLumiart.Models.Dtos;
using EscolaLumiart.Models.Interfaces.Repositories;
using EscolaLumiart.Models.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Services
{
    public class EmprestimoLivroService : IEmprestimoLivroService
    {
        private readonly IEmprestimoLivroRepository _emprestimoLivroRepository;

        public EmprestimoLivroService(IEmprestimoLivroRepository emprestimoLivroRepository)
        {
            _emprestimoLivroRepository = emprestimoLivroRepository;
        }
        public void EfetuarDevolucao(EmprestimoLivroDto emprestimoLivro)
        {
            try
            {
                var objEmprestimo = emprestimoLivro.ConverterParaEntidade();
                _emprestimoLivroRepository.Efetuar_devolucao(objEmprestimo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EfetuarEmprestimo(EmprestimoLivroDto emprestimoLivro)
        {
            try
            {
                var objEmprestimo = emprestimoLivro.ConverterParaEntidade();
                _emprestimoLivroRepository.EfetuarEmprestimo(objEmprestimo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

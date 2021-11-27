using EscolaLumiart.Models.Dtos;
using EscolaLumiart.Models.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoLivroService _emprestimoService;
        private readonly ILivroService _livroService;
        private readonly IClienteService _clienteService;

        public EmprestimoController(IEmprestimoLivroService emprestimoService, 
            ILivroService livroService, IClienteService clienteService)
        {
            _emprestimoService = emprestimoService;
            _livroService = livroService;
            _clienteService = clienteService;
         

        }
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EfetuarEmprestimo([Bind("Cliente, Livro")] EmprestimoDto emprestimo)
        {
            try
            {
               
                EmprestimoLivroDto entidade = new EmprestimoLivroDto();
                entidade.Cliente = PesquisarCliente(emprestimo.Cliente);
                entidade.ClienteId = entidade.Cliente.Id;

                entidade.Livro = PesquisarLivro(emprestimo.Livro);
                entidade.LivroId = entidade.Livro.Id;

                entidade.UsuarioId = 1;
                entidade.Usuario = new UsuarioDto { Id = 1, Login = "edson" };

                _emprestimoService.EfetuarEmprestimo(entidade);

                return null;


            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public ClienteDto PesquisarCliente(string nome)
        {
            var cliente = _clienteService.Listar()
                .Where(p => p.Nome.Equals(nome)).FirstOrDefault();
            return cliente;
        }

        public LivroDto PesquisarLivro(string nome)
        {
            var livro = _livroService.Listar()
                .Where(p => p.Nome.Equals(nome)).FirstOrDefault();
            return livro;
        }

        public IActionResult PesquisarClientes(string term)
        {
            var clientes = _clienteService.Listar();
            var clientesAtivos = clientes.Where(p => p.StatusClienteId.Equals("1")).ToList();
            var listaNomeClientes = clientesAtivos.Select(p => p.Nome).ToList();
            var filtro = listaNomeClientes.Where(p => p.Contains(term, StringComparison.CurrentCultureIgnoreCase));
            return Json(filtro);
        }

        public IActionResult PesquisarLivros(string term)
        {
            var livros = _livroService.Listar();
            var livrosDisponiveis = livros.Where(p => p.StatusLivroId.Equals("1")).ToList();
            var listaLivros = livrosDisponiveis.Select(p => p.Nome).ToList();
            var filtro = listaLivros.Where(p => p.Contains(term, StringComparison.CurrentCultureIgnoreCase));
            return Json(filtro);
        }
    }
}

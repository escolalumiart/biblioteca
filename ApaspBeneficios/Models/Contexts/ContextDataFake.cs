using EscolaLumiart.Models.Dtos;
using EscolaLumiart.Models.Entidades;
using EscolaLumiart.Models.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Contexts
{
    public  class ContextDataFake:IContextData
    {
        private static List<Livro> livros = new List<Livro>();
        public ContextDataFake()
        {
            //livros = new List<Livro>();
            InitializeData();
        }

        public void AtualizarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void AtualizarLivro(Livro livro)
        {
            try
            {
                var objPesquisa = PesquisarLivroPorId(livro.Id);
                livros.Remove(objPesquisa);
                objPesquisa.Nome = livro.Nome;
                objPesquisa.Editora = livro.Editora;
                objPesquisa.Autor = livro.Autor;

                CadasTrarLivros(objPesquisa);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void CadasTrarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void CadasTrarLivros(Livro livro)
        {
            try
            {
                livros.Add(livro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CadasTrarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void EfetuarDevolucaoLivro(EmprestimoLivro emprestimoLivro)
        {
            throw new NotImplementedException();
        }

        public void EfetuarEmprestimoLivro(EmprestimoLivro emprestimoLivro)
        {
            throw new NotImplementedException();
        }

        public UsuarioDto EfetuarLogin(UsuarioDto usuario)
        {
            throw new NotImplementedException();
        }

        public void ExcluirCliente(string id)
        {
            throw new NotImplementedException();
        }

        public void ExcluirLivro(string id)
        {
            try
            {
                var objPesquisa = PesquisarLivroPorId(id);
                livros.Remove(objPesquisa);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExcluirUsuario(string id)
        {
            throw new NotImplementedException();
        }

        public void ExcluirUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarCliente()
        {
            throw new NotImplementedException();
        }

        public List<Livro> ListarLivro()
        {
            return livros
                .OrderBy(p => p.Nome)
                .ToList();
        }

        public List<Usuario> ListarUsuario()
        {
            throw new NotImplementedException();
        }

        public Cliente PesquisarClientePorId(string id)
        {
            throw new NotImplementedException();
        }

        public Livro PesquisarLivroPorId(string id)
        {
            try
            {
                return livros.FirstOrDefault(p => p.Id == id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Usuario PesquisarUsuarioPorId(string id)
        {
            throw new NotImplementedException();
        }

        public Usuario PesquisarUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        private  void InitializeData()
        {
            var livro = new Livro { Nome = "Implementando Domain-Drive Design", Autor = "Caugh Vernon", Editora = "Alta Books" };
            livros.Add(livro);
            livro = new Livro { Nome = "Domain-Drive Design", Autor = "Eric Evans", Editora = "Alta Books" };
            livros.Add(livro);
             livro = new Livro { Nome = "Redes Guia Pratico", Autor = "Carlos E. Morimoto", Editora = "Sul Editores" };
            livros.Add(livro);
             livro = new Livro { Nome = "PHP Programando com Orientação a Objetos", Autor = "Pablo Dall'Oglio", Editora = "Novatec" };
            livros.Add(livro);
            livro = new Livro {Nome= "Introdução a Programação com Phyton",Autor= "Nilo N.C.Menezes", Editora="Novatec"};
            livros.Add(livro);

        }
    }
}

using EscolaLumiart.Models.Dtos;
using EscolaLumiart.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Interfaces.Contexts
{
    public interface IContextData
    {
        // LIvro
        void CadasTrarLivros(Livro livro);
        List<Livro> ListarLivro();
        Livro PesquisarLivroPorId(string id);
        void AtualizarLivro(Livro livro);
        void ExcluirLivro(string id);

        //Cliente
        void CadasTrarCliente(Cliente cliente);
        List<Cliente> ListarCliente();
        Cliente PesquisarClientePorId(string id);
        void AtualizarCliente(Cliente cliente);
        void ExcluirCliente(string id);

        // Usuario
        void CadasTrarUsuario(Usuario usuario);
        List<Usuario> ListarUsuario();
        Usuario PesquisarUsuarioPorId(int id);
        void AtualizarUsuario(Usuario usuario);
        void ExcluirUsuario(int id);
        UsuarioDto EfetuarLogin(UsuarioDto usuario);

        // EmprestimoLivro

        void EfetuarEmprestimoLivro(EmprestimoLivro emprestimoLivro);
        void EfetuarDevolucaoLivro(EmprestimoLivro emprestimoLivro);
    }
}

using EscolaLumiart.Models.Dtos;
using EscolaLumiart.Models.Entidades;
using EscolaLumiart.Models.Interfaces.Contexts;
using EscolaLumiart.Models.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Repositories
{
    public class UsuarioRepository:IUsuarioRepository
    {
        private readonly IContextData _contextData;
        public UsuarioRepository(IContextData contextData)
        {
            _contextData = contextData;
        }

        public void Atualizar(Usuario usuario)
        {
            _contextData.AtualizarUsuario(usuario);
        }

        public void Cadastrar(Usuario usuario)
        {
            _contextData.CadasTrarUsuario(usuario);
        }

        public UsuarioDto EfetuarLogin(UsuarioDto usuario)
        {
            return _contextData.EfetuarLogin(usuario);

        }

        public void Excluir(int id)
        {
            _contextData.ExcluirUsuario(id);
        }

        public List<Usuario> Listar()
        {
            return _contextData.ListarUsuario();
        }

        public Usuario PesquisarPorId(int id)
        {
            return _contextData.PesquisarUsuarioPorId(id);
        }
    }
}

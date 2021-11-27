using EscolaLumiart.Models.Entidades;
using EscolaLumiart.Models.Interfaces.Contexts;
using EscolaLumiart.Models.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IContextData _contextData;

        public ClienteRepository(IContextData contextData)
        {
            _contextData = contextData;
        }
        public void Atualizar(Cliente cliente)
        {
            _contextData.AtualizarCliente(cliente);
        }

        public void Cadastrar(Cliente cliente)
        {
            _contextData.CadasTrarCliente(cliente);
        }

        public List<Cliente> Listar()
        {
            return _contextData.ListarCliente();
        }

        public Cliente PesquisarPorId(string id)
        {
            return _contextData.PesquisarClientePorId(id);
        }

        public void Excluir(string id)
        {
            _contextData.ExcluirCliente(id);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Interfaces.Services
{
    public interface IGenericService<T, Y>
    {
        // T = entidade Y = tipo de dado de chave
        void Cadastrar(T entidade);
        List<T> Listar();
        //T PesquisarPorId(string id);
        T PesquisarPorId(Y id);
        void Atualizar(T entidade);
        void Excluir(Y id);
    }
}

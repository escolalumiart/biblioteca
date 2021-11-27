using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Enuns
{
    public enum TSql
    {
        // LIVRO
        CADASTRAR_LIVRO,
        LISTAR_LIVRO,
        PESQUISAR_LIVRO,
        ATUALIZAR_LIVRO,
        EXCLUIR_LIVRO,
        // CLIENTE
        CADASTRAR_CLIENTE,
        LISTAR_CLIENTE,
        PESQUISAR_CLIENTE,
        ATUALIZAR_CLIENTE,
        EXCLUIR_CLIENTE,

        // USUARIO
        CADASTRAR_USUARIO,
        LISTAR_USUARIO,
        PESQUISAR_USUARIO,
        ATUALIZAR_USUARIO,
        EXCLUIR_USUARIO,
        EFETUAR_LOGIN,

        //EMPRESTIMO
        EFETUAR_EMPRESTIMO_LIVRO,
        ATUALIZAR_STATUS_LIVRO,
        EFETUAR_DEVOLUCAO_LIVRO
    }
}

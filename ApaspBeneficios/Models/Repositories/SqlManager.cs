using EscolaLumiart.Models.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Repositories
{
    public class SqlManager
    {
        public static string GetSql(TSql tsql)
        {
            var sql = "";
            switch (tsql)
            {
                #region   LIVRO
                case TSql.CADASTRAR_LIVRO:
                    sql = "insert into livro (id, nome, autor, editora, statusLivroId) values (convert(binary(36),@id), @nome, @autor,@editora,@statusLivroId)";
                    break;
                case TSql.LISTAR_LIVRO:
                    sql = "select convert(varchar(36),id) 'id', nome, autor, editora, statusLivroId from livro order by nome";
                    break;
                case TSql.PESQUISAR_LIVRO:
                    sql = "select convert(varchar(36),id) 'id', nome, autor, editora from livro where id =@id";
                    break;
                case TSql.ATUALIZAR_LIVRO:
                    sql = "update livro set  nome =@nome, autor = @autor, editora = @editora  where id =@id";
                    break;
                case TSql.EXCLUIR_LIVRO:
                    sql = "delete from livro  where id =@id";
                    break;
                #endregion region

                #region CLIENTE
                case TSql.CADASTRAR_CLIENTE:
                    sql = "insert into cliente (id, nome, cpf, email, fone, statusClienteId) values (convert(binary(36),@id), @nome, @cpf, @email, @fone, @statusClienteId)";
                    break;
                case TSql.LISTAR_CLIENTE:
                    sql = "select convert(varchar(36),id) 'id', nome, cpf, email, fone from cliente order by nome";
                    break;
                case TSql.PESQUISAR_CLIENTE:
                    sql = "select convert(varchar(36),id) 'id', nome, cpf, email, fone  from cliente where id =@id";
                    break;
                case TSql.ATUALIZAR_CLIENTE:
                    sql = "update cliente set  nome =@nome, cpf = @cpf, email = @email, fone = @fone where id =@id";
                    break;
                case TSql.EXCLUIR_CLIENTE:
                    sql = "delete from cliente  where id =@id";
                    break;
                #endregion


                #region USUARIO
                case TSql.CADASTRAR_USUARIO:
                    sql = "insert into usuario (login, senha) values (@login, @senha)";
                    break;
                case TSql.LISTAR_USUARIO:
                    sql = "select id, login, senha from usuario";
                    break;
                case TSql.PESQUISAR_USUARIO:
                    sql = "select id, login, senha from usuario where id =@id";
                    break;
                case TSql.ATUALIZAR_USUARIO:
                    sql = "update usuario set  senha =@senha where id =@id";
                    break;
                case TSql.EXCLUIR_USUARIO:
                    sql = "delete from usuario  where id =@id";
                    break;
                case TSql.EFETUAR_LOGIN:
                    sql = "select id, login from usuario where login =@login and senha = @senha";
                    break;
                #endregion region

                #region EMPRESTIMO LIVRO
                case TSql.EFETUAR_EMPRESTIMO_LIVRO:
                    sql = "insert into emprestimolivro (clienteId, usuatioId, livroId, dataEmprestimo, dataDevolução) values (@clienteId, @usuarioId,@livroId,@dataEmprestimo, @dataDevolucao)";
                    break;
                case TSql.EFETUAR_DEVOLUCAO_LIVRO:
                    sql = "update emprestimoLivro set  dataDevolucaoEfetiva = @dataDevolucaoEfetiva where clienteId =@clienteId and livroId=@livroId" ;
                    break;
                case TSql.ATUALIZAR_STATUS_LIVRO:
                    sql = "update livro set statusLivroId = @statusLivroId where id = @id";
                    break;

                #endregion

                default:
                    break;
            }

            return sql;
        }
    }
}

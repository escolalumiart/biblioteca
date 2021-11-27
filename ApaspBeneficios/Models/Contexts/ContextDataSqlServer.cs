using EscolaLumiart.Models.Dtos;
using EscolaLumiart.Models.Entidades;
using EscolaLumiart.Models.Enuns;
using EscolaLumiart.Models.Interfaces.Contexts;
using EscolaLumiart.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Contexts
{
    public class ContextDataSqlServer : IContextData
    {
        private readonly SqlConnection _connection = null;
        public ContextDataSqlServer(IConnectionManager connectionManager)
        {
            _connection = connectionManager.GetConnection();
        }

        #region Contexto de Cliente
        public void AtualizarCliente(Cliente cliente)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.ATUALIZAR_CLIENTE);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = cliente.Id;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = cliente.Nome;
                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cliente.Cpf;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = cliente.Email;
                command.Parameters.Add("@fone", SqlDbType.VarChar).Value = cliente.Fone;

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
        public void CadasTrarCliente(Cliente cliente)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.CADASTRAR_CLIENTE);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = cliente.Id;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = cliente.Nome;
                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cliente.Cpf;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = cliente.Email;
                command.Parameters.Add("@fone", SqlDbType.VarChar).Value = cliente.Fone;
                command.Parameters.Add("@statusClienteId", SqlDbType.Int).Value = cliente.StatusCliente.GetHashCode();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
        public void ExcluirCliente(string id)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.EXCLUIR_CLIENTE);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Cliente> ListarCliente()
        {
            var clientes = new List<Cliente>();
            try
            {
                var query = SqlManager.GetSql(TSql.LISTAR_CLIENTE);

                var command = new SqlCommand(query, _connection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);
                //ou  adapter.Fill(dataset,"consulta");

                var rows = dataset.Tables[0].Rows;
                //ou  var rows = dataset.Tables["consulta"].Rows;
                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;
                    var id = colunas[0].ToString();
                    var nome = colunas[1].ToString();
                    var cpf = colunas[2].ToString();
                    var email = colunas[3].ToString();
                    var fone = colunas[4].ToString();

                    var cliente = new Cliente { Id = id, Nome = nome, Cpf = cpf, Email = email, Fone = fone };
                    clientes.Add(cliente);

                }
                adapter = null;
                dataset = null;
                return clientes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Cliente PesquisarClientePorId(string id)
        {
            try
            {
                Cliente cliente = null;
                var query = SqlManager.GetSql(TSql.PESQUISAR_CLIENTE);

                var command = new SqlCommand(query, _connection);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);
                //ou  adapter.Fill(dataset,"consulta");

                var rows = dataset.Tables[0].Rows;
                //ou  var rows = dataset.Tables["consulta"].Rows;
                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;
                    var codigo = colunas[0].ToString();
                    var nome = colunas[1].ToString();
                    var cpf = colunas[2].ToString();
                    var email = colunas[3].ToString();
                    var fone = colunas[4].ToString();

                    cliente = new Cliente { Id = codigo, Nome = nome, Cpf = cpf, Email = email, Fone = fone };
                }
                adapter = null;
                dataset = null;
                return cliente;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Contexto de Livro
        public void AtualizarLivro(Livro livro)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.ATUALIZAR_LIVRO);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = livro.Id;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = livro.Nome;
                command.Parameters.Add("@autor", SqlDbType.VarChar).Value = livro.Autor;
                command.Parameters.Add("@editora", SqlDbType.VarChar).Value = livro.Editora;

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
        public void CadasTrarLivros(Livro livro)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.CADASTRAR_LIVRO);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = livro.Id;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = livro.Nome;
                command.Parameters.Add("@autor", SqlDbType.VarChar).Value = livro.Autor;
                command.Parameters.Add("@editora", SqlDbType.VarChar).Value = livro.Editora;
                command.Parameters.Add("@statusLivroId", SqlDbType.Int).Value = livro.StatusLivro.GetHashCode();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

        }
        public void ExcluirLivro(string id)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.EXCLUIR_LIVRO);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Livro PesquisarLivroPorId(string id)
        {
            try
            {
                Livro livro = null;
                var query = SqlManager.GetSql(TSql.PESQUISAR_LIVRO);

                var command = new SqlCommand(query, _connection);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);
                //ou  adapter.Fill(dataset,"consulta");

                var rows = dataset.Tables[0].Rows;
                //ou  var rows = dataset.Tables["consulta"].Rows;
                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;
                    var codigo = colunas[0].ToString();
                    var nome = colunas[1].ToString();
                    var autor = colunas[2].ToString();
                    var editora = colunas[3].ToString();

                    livro = new Livro { Id = codigo, Nome = nome, Autor = autor, Editora = editora };
                }
                adapter = null;
                dataset = null;
                return livro;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Livro> ListarLivro()
        {
            var livros = new List<Livro>();
            try
            {
                var query = SqlManager.GetSql(TSql.LISTAR_LIVRO);

                var command = new SqlCommand(query, _connection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);
                //ou  adapter.Fill(dataset,"consulta");

                var rows = dataset.Tables[0].Rows;
                //ou  var rows = dataset.Tables["consulta"].Rows;
                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;
                    var id = colunas[0].ToString();
                    var nome = colunas[1].ToString();
                    var autor = colunas[2].ToString();
                    var editora = colunas[3].ToString();
                    var statusLivroId = colunas[4].ToString();

                    var livro = new Livro { Id = id, Nome = nome, Autor = autor, Editora = editora, StatusLivroId = Int32.Parse(statusLivroId)};
                    livro.StatusLivro = GerenciadorDeStatus.PesquisarStatusDoLivroPeloId(livro.StatusLivroId);
                    livros.Add(livro);

                }
                adapter = null;
                dataset = null;
                return livros;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Contexto de Usuario
        public void AtualizarUsuario(Usuario usuario)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.ATUALIZAR_USUARIO);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = usuario.Id;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = usuario.Senha;
                command.Parameters.Add("@login", SqlDbType.VarChar).Value = usuario.Login;
                
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
        public void CadasTrarUsuario(Usuario usuario)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.CADASTRAR_USUARIO);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = usuario.Id;
                command.Parameters.Add("@login", SqlDbType.VarChar).Value = usuario.Login;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = usuario.Senha;
               
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
        public void ExcluirUsuario(int id)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.EXCLUIR_USUARIO);
                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Usuario> ListarUsuario()
        {
            var usuarios = new List<Usuario>();
            try
            {
                var query = SqlManager.GetSql(TSql.LISTAR_USUARIO);

                var command = new SqlCommand(query, _connection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);
                //ou  adapter.Fill(dataset,"consulta");

                var rows = dataset.Tables[0].Rows;
                //ou  var rows = dataset.Tables["consulta"].Rows;
                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;
                    var id = Int32.Parse(colunas[0].ToString());
                    var login = colunas[1].ToString();
                    var senha = colunas[2].ToString();
                

                    var usuario = new Usuario{ Id = id, Login = login, Senha = senha };
                    usuarios.Add(usuario);

                }
                adapter = null;
                dataset = null;
                return usuarios;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Usuario PesquisarUsuarioPorId(int id)
        {
            try
            {
                Usuario usuario = null;
                var query = SqlManager.GetSql(TSql.PESQUISAR_USUARIO);

                var command = new SqlCommand(query, _connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);
                //ou  adapter.Fill(dataset,"consulta");

                var rows = dataset.Tables[0].Rows;
                //ou  var rows = dataset.Tables["consulta"].Rows;
                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var codigo = Int32.Parse(colunas[0].ToString());
                    var login = colunas[1].ToString();
                    var senha = colunas[2].ToString();
                 

                    usuario = new Usuario { Id = codigo, Login = login, Senha = senha };
                }
                adapter = null;
                dataset = null;
                return usuario;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public UsuarioDto EfetuarLogin(UsuarioDto usuario)
        {
            try
            {
                UsuarioDto result = null;
                var query = SqlManager.GetSql(TSql.EFETUAR_LOGIN);

                var command = new SqlCommand(query, _connection);
                command.Parameters.Add("@login", SqlDbType.VarChar).Value = usuario.Login;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = usuario.Senha;
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);
                //ou  adapter.Fill(dataset,"consulta");

                var rows = dataset.Tables[0].Rows;
                //ou  var rows = dataset.Tables["consulta"].Rows;
                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var codigo = Int32.Parse(colunas[0].ToString());
                    var login = colunas[1].ToString();
               


                    result = new UsuarioDto { Id = codigo, Login = login};
                }
                adapter = null;
                dataset = null;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EfetuarEmprestimoLivro(EmprestimoLivro emprestimoLivro)
        { SqlTransaction transaction = null;
            try
            {
                _connection.Open();
                transaction = _connection.BeginTransaction();

                var query = SqlManager.GetSql(TSql.EFETUAR_EMPRESTIMO_LIVRO);
                var command = new SqlCommand(query, _connection, transaction);

                command.Parameters.Add("@clienteId", SqlDbType.VarChar).Value = emprestimoLivro.ClienteId;
                command.Parameters.Add("@usuarioId", SqlDbType.Int).Value = emprestimoLivro.UsuarioId;
                command.Parameters.Add("@livroId", SqlDbType.VarChar).Value = emprestimoLivro.LivroId;
                command.Parameters.Add("@dataEmprestimo", SqlDbType.DateTime).Value = emprestimoLivro.DataEmprestimo;
                command.Parameters.Add("@dataDevolucao", SqlDbType.DateTime).Value = emprestimoLivro.DataDevolucao;
                
                command.ExecuteNonQuery();

                var query2 = SqlManager.GetSql(TSql.ATUALIZAR_STATUS_LIVRO);
                var command2 = new SqlCommand(query, _connection, transaction);
                command2.Parameters.Add("@d", SqlDbType.VarChar).Value = emprestimoLivro.LivroId;
                command2.Parameters.Add("@statusLivroId", SqlDbType.Int).Value = StatusLivro.EMPRESTADO.GetHashCode();

                command2.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public void EfetuarDevolucaoLivro(EmprestimoLivro emprestimoLivro)
        {
            SqlTransaction transaction = null;
            try
            {
                _connection.Open();
                transaction = _connection.BeginTransaction();

                var query = SqlManager.GetSql(TSql.EFETUAR_DEVOLUCAO_LIVRO);
                var command = new SqlCommand(query, _connection, transaction);

                command.Parameters.Add("@clienteId", SqlDbType.VarChar).Value = emprestimoLivro.ClienteId;
                command.Parameters.Add("@livroId", SqlDbType.VarChar).Value = emprestimoLivro.LivroId;
                command.Parameters.Add("@dataDevolucaoEfetiva", SqlDbType.DateTime).Value = emprestimoLivro.DataDevolucaoEfetiva;

                command.ExecuteNonQuery();

                var query2 = SqlManager.GetSql(TSql.ATUALIZAR_STATUS_LIVRO);
                var command2 = new SqlCommand(query, _connection, transaction);
                command2.Parameters.Add("@d", SqlDbType.VarChar).Value = emprestimoLivro.LivroId;
                command2.Parameters.Add("@statusLivroId", SqlDbType.Int).Value = StatusLivro.DISPONÍVEL.GetHashCode();

                command2.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        #endregion

    }
}

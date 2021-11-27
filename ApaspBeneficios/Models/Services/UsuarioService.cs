using EscolaLumiart.Models.Dtos;
using EscolaLumiart.Models.Interfaces.Repositories;
using EscolaLumiart.Models.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public void Atualizar(UsuarioDto usuario)
        {
            try
            {
                var objUsuario= usuario.ConverterParaEntidade();
                _usuarioRepository.Atualizar(objUsuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Cadastrar(UsuarioDto usuario)
        {
            try
            {
                var objUsuario = usuario.ConverterParaEntidade();
                
                _usuarioRepository.Cadastrar(objUsuario);
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
               
               var validacao = _usuarioRepository.EfetuarLogin(usuario);
                return validacao;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<UsuarioDto> Listar()
        {
            try
            {
                var usuariosDto = new List<UsuarioDto>();
                var usuarios = _usuarioRepository.Listar();
                foreach (var item in usuarios)
                {
                    usuariosDto.Add(item.ConverterParaDto());
                }
                return usuariosDto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public UsuarioDto PesquisarPorId(int id)
        {
            try
            {
                var usuario = _usuarioRepository.PesquisarPorId(id);
                return usuario.ConverterParaDto();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

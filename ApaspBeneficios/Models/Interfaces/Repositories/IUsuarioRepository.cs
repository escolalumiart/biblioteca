using EscolaLumiart.Models.Dtos;
using EscolaLumiart.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Interfaces.Repositories
{
    public interface IUsuarioRepository:IRepository<Usuario, int>
    {
        UsuarioDto EfetuarLogin(UsuarioDto usuario);
    }
}

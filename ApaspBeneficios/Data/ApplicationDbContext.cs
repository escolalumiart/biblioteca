using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using EscolaLumiart.Models.Dtos;
using EscolaLumiart.Models.Entidades;

namespace EscolaLumiart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
       
        public DbSet<EscolaLumiart.Models.Dtos.LivroDto> LivroDto { get; set; }
        public DbSet<EscolaLumiart.Models.Dtos.ClienteDto> ClienteDto { get; set; }
        public DbSet<Contato> Contato { get; set; }

    }
}


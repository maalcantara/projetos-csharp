using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IntroducaoAPI.Entities;

namespace IntroducaoAPI.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        // propriedade que refere a Entidade -> classe no programa e ao mesmo tempo uma tabela no db
        public DbSet<Contato> Contatos { get; set; }

    }
}
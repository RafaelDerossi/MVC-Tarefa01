using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarefa01_Rafael_Derossi.Models;

namespace Tarefa01_Rafael_Derossi.Data
{
    public class Tarefa01_Rafael_DerossiContext : DbContext
    {
        public Tarefa01_Rafael_DerossiContext (DbContextOptions<Tarefa01_Rafael_DerossiContext> options)
            : base(options)
        {
        }

        public DbSet<Tarefa01_Rafael_Derossi.Models.Produto> Produto { get; set; }

        
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TarefasContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
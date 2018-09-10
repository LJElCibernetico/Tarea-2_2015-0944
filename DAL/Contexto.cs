using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Productos> productos { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}

using SEKKAT.ORM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatonsCodeFirst.ORM
{
    public class ContexteBDD : DbContext
    {
        public ContexteBDD()
            : base("chaineDeConnexion")
        {

        }

        public DbSet<jeux> jeu { get; set; }
        public DbSet<Réservation> réservations { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Client> Clients { get; set; }
    }
}


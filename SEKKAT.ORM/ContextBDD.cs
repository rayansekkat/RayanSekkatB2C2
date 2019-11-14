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

        //public DbSet<Categorie> Categories { get; set; }
        //public DbSet<Chaton> Chatons { get; set; }
        //public DbSet<Proprietaire> Proprietaires { get; set; }
    }
}


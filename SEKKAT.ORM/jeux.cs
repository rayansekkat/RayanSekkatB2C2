using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEKKAT.ORM
{
    public class jeux
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }
        public string Plateforme { get; set; }

        public bool possédé { get; set; }

        public bool échangeable { get; set; }

        public bool JeuSouhaite { get; set; }


        public virtual ICollection<Client> Client { get; set; }

        public jeux()
        {
            Client = new List<Client>();
        }

    }
}

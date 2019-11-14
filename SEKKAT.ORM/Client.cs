using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEKKAT.ORM
{
    public class Client
    {
        [Key]
        public int id { get; set; }


        [StringLength(50)]
        public string MotDePasse { get; set; }
        [StringLength(50)]
        public string Identifient { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }
        [StringLength(50)]
        public string Prénom { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual ICollection<jeux> jeux { get; set; }

        public Client()
        {
            jeux = new List<jeux>();
        }

    }
}

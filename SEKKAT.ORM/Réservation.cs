using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEKKAT.ORM
{
    public class Réservation
    {
        [Key]
        public int ReservationID { get; set; }

        public bool reservé { get; set; }

        public virtual jeux jeu { get; set; }
        public virtual Client clients { get; set; }

    }
}

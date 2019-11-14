using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEKKAT.ORM
{
    public class Stock
    {
        [Key]
        public int StockId { get; set; }

        public bool StockMagasin { get; set; }

        public bool StockUser { get; set; }

        public virtual jeux jeu { get; set; }
    }
}

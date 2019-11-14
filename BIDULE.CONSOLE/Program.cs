using ChatonsCodeFirst.ORM;
using SEKKAT.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIDULE.CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContexteBDD())
            {
               

                var jeu = new jeux()
                {
                    
                    Nom = "Call of duty",
                    Plateforme = "Playstation 4",
                    échangeable = false,
                    JeuSouhaite = true,
                    possédé = false,
                };

                var souhaité = db.jeu.Where(j => j.JeuSouhaite.Equals(true));
                foreach (var item in souhaité)
                {
                    System.Console.WriteLine(item.Nom, item.Plateforme);
                }


                var possédé = db.jeu.Where(j => j.possédé.Equals(true));
                foreach (var item in souhaité)
                {
                    System.Console.WriteLine(item.Nom, item.Plateforme);
                }




                db.jeu.Add(jeu);
                db.SaveChanges();

                System.Console.ReadKey();
            }
        }
    }
}

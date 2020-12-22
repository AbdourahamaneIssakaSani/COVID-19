using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COVID_19
{
    class Program
    {
        static void Main()
        {           
            Citoyen Ali = new Citoyen();
            Ali.Nom = "Ali";
            Ali.Prenom = "Salissou";
            Ali.Age = 23;
            Ali.Genre = Sexe.masclin;
            Ali.Residence = "State, Fès 20000";

            Console.WriteLine(Ali.Nom.ToUpper() + "\t" + Ali.Prenom);
        }
    }
}

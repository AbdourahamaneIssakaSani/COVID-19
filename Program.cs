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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============Civilité============");
            Console.WriteLine("Nom et Prénom:"+ Ali.Nom.ToUpper() +" " + Ali.Prenom);           
            Console.WriteLine("Sexe:" + Ali.Genre);
            Console.WriteLine("Age:" + Ali.Age);
            Console.WriteLine("Adresse:"+ Ali.Residence);
            Console.WriteLine("============Etat sanitaire============");
            Console.WriteLine("Depistage:"+ Ali.Depistage.ElementAt<Depistage>(0));
        }
    }
}

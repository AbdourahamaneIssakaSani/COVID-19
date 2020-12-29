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

            Depistage dep = new Depistage();
            CodeQR code = new CodeQR();
            dep.AddCodeQR(code);
            Ali.AddDepistage(dep);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============Civilité============");
            Console.WriteLine("Nom:"+ Ali.Nom);           
            Console.WriteLine("Prénom:"+Ali.Prenom);           
            Console.WriteLine("Sexe:" + Ali.Genre);
            Console.WriteLine("Age:" + Ali.Age);
            Console.WriteLine("Adresse:"+ Ali.Residence);
            Console.WriteLine("============Dépistage============");
            Console.WriteLine("Nom du test:" + Ali.Depistage.ElementAt<Depistage>(0).Test);
            Console.WriteLine("Date:" + Ali.Depistage.ElementAt<Depistage>(0).Date);
            Console.WriteLine("Atteint du COVID-19:" + Ali.Depistage.ElementAt<Depistage>(0).Positif);
            Console.WriteLine("============CodeQR============");
            Console.WriteLine("ID :"+code.ID);
            Console.WriteLine("Date d’émission :"+code.dateEmission);
            Console.WriteLine("Code couleur :"+code.Etat);
            Console.WriteLine("Informations complémentaires :"+code.Details);
            
            Console.WriteLine("============État sanitaire============");

            Console.ReadLine();
        }
    }
}

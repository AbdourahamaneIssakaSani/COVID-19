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
            
            Consultationenligne Visite = new Consultationenligne();
            Visite.traitements = new Traitement[10];
            Visite.traitements[0] = new Traitement();
            Visite.traitements[0].codeQRA = new CodeQR(code);
            Visite.traitements[0].consultationenligneB = new Consultationenligne(Visite);
            Visite.traitements[0].Details = "Aucun traitement prescris";           
            Visite.traitements[0].estVaccine = false;
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============Civilité============");
            Console.WriteLine("Nom:"+ Ali.Nom);           
            Console.WriteLine("Prénom:"+Ali.Prenom);           
            Console.WriteLine("Sexe:" + Ali.Genre);
            Console.WriteLine("Age:" + Ali.Age);
            Console.WriteLine("Adresse:"+ Ali.Residence);
            Console.WriteLine("============Dépistage============");
            Console.WriteLine("Nom du test:" + Ali.Depistage.ElementAt<Depistage>(0).Test);
            Console.WriteLine("Date:" + Ali.Depistage.ElementAt<Depistage>(0).Date.Date);
            Console.WriteLine("Fait à:" + Ali.Depistage.ElementAt<Depistage>(0).Endroit.Localisation().Position.Location);
            Console.WriteLine("Atteint du COVID-19:" + Ali.Depistage.ElementAt<Depistage>(0).Positif);
            Console.WriteLine("============CodeQR============");
            Console.WriteLine("ID :"+code.ID);
            Console.WriteLine("Date d’émission :"+code.dateEmission);
            Console.WriteLine("Code couleur :"+code.Etat);
            Console.WriteLine("Informations complémentaires :"+code.Details);
            
            Console.WriteLine("============Consultation en Ligne============");            
            Console.WriteLine("Date de Consultation :" + Visite.Date.AddDays(-14));
            Console.WriteLine("Observation du médecin :"+Visite.Avancement());
            Console.WriteLine("\t=====Ordonnance=====");
            Console.WriteLine("Code Patient :" + Visite.traitements[0].codeQRA.ID);
            Console.WriteLine("Date:"+Visite.traitements[0].DateOrdonnance.AddDays(-14));
            Console.WriteLine("Prescription:"+Visite.traitements[0].Details);
            Console.WriteLine("Est-il vacciné:"+Visite.traitements[0].estVaccine);
            
            Console.WriteLine("============Consultation en Ligne 2============");
            Visite.traitements[1] = new Traitement();
            Visite.traitements[1].codeQRA = code;
            Visite.traitements[1].consultationenligneB = Visite;
            Visite.traitements[1].Details = "Confinement recommandé";
            Visite.traitements[1].estVaccine = true;

            Console.WriteLine("\t=====Ordonnance=====");
            Console.WriteLine("Code Patient :" + Visite.traitements[1].codeQRA.ID);
            Console.WriteLine("Date:" + Visite.traitements[1].DateOrdonnance);
            Console.WriteLine("Prescription:" + Visite.traitements[1].Details);
            Console.WriteLine("Est-il vacciné:" + Visite.traitements[1].estVaccine);
            
            Console.ReadLine();
        }
    }
}

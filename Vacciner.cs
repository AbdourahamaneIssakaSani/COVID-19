// File:    Vacciner.cs
// Author:  Gaming VivoBook Pro
// Created: jeudi 3 d�cembre 2020 18:35:40
// Purpose: Definition of Class Vacciner

using System;

/// s�il est vaccin� selon son code QR ou son statut(agent de sant�, personne ag�e) car le vaccin n�est pas disponible pour tous, il doit renseigner cela au cours de sa consultation en ligne. De ce fait, les vaccin�s peuvent avoir un code Jaune puisqu�on est vaccin� seulement si on est consid�r� "� risque"
public class Vacciner
{
   private DateTime date;
   private Coordonnees lieu;
   private string details;
   private bool estVaccine;
   
   public bool Vaccine()
   {
      throw new NotImplementedException();
   }
   
   public CodeQR codeQRA;
   public Consultationenligne consultationenligneB;

}
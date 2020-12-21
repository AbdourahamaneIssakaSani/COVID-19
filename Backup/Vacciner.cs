// File:    Vacciner.cs
// Author:  Gaming VivoBook Pro
// Created: jeudi 3 décembre 2020 18:35:40
// Purpose: Definition of Class Vacciner

using System;

/// s’il est vacciné selon son code QR ou son statut(agent de santé, personne agée) car le vaccin n’est pas disponible pour tous, il doit renseigner cela au cours de sa consultation en ligne. De ce fait, les vaccinés peuvent avoir un code Jaune puisqu’on est vacciné seulement si on est considéré "à risque"
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
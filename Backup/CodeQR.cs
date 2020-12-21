// File:    CodeQR.cs
// Author:  Gaming VivoBook Pro
// Created: jeudi 3 décembre 2020 17:43:00
// Purpose: Definition of Class CodeQR

using System;

/// il obtient un code QR après un test de dépistage sinon en fonction de ses déplacements, c’est-à-dire s’il a partagé les mêmes coordonnées qu’un malade au même moment ou selon certaines conditions définie par les autorités sanitaires.
/// Le code QR contient les informations suivantes :
/// --- en quarantaine
/// --- confiné à la maison
/// --- hospitalisé
/// --- en observation
public class CodeQR
{
   private int id;
   private Couleur couleur;
   private DateTime date;
   private string etat;
   private string details;
   
   public Couleur Etat()
   {
      throw new NotImplementedException();
   }
   
   public Vacciner[] Association12;

}
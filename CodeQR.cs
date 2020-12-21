// File:    CodeQR.cs
// Author:  Gaming VivoBook Pro
// Created: jeudi 3 d�cembre 2020 17:43:00
// Purpose: Definition of Class CodeQR

using System;

/// il obtient un code QR apr�s un test de d�pistage sinon en fonction de ses d�placements, c�est-�-dire s�il a partag� les m�mes coordonn�es qu�un malade au m�me moment ou selon certaines conditions d�finie par les autorit�s sanitaires.
/// Le code QR contient les informations suivantes :
/// --- en quarantaine
/// --- confin� � la maison
/// --- hospitalis�
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
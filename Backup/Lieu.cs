// File:    Lieu.cs
// Author:  Gaming VivoBook Pro
// Created: jeudi 3 d�cembre 2020 17:30:03
// Purpose: Definition of Class Lieu

using System;

/// un lieu visit� est d�fini par des coordon�es, d�s qu�il bouge on enregistre les anciennes coordonn�es comme lieu visit�
public class Lieu
{
   private DateTime date;
   private DateTime heure;
   private TimeSpan duree;
   
   public bool Avisite()
   {
      throw new NotImplementedException();
   }
   
   public System.Collections.Generic.List<CodeQR> codeQR;
   
   /// <summary>
   /// Property for collection of CodeQR
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<CodeQR> CodeQR
   {
      get
      {
         if (codeQR == null)
            codeQR = new System.Collections.Generic.List<CodeQR>();
         return codeQR;
      }
      set
      {
         RemoveAllCodeQR();
         if (value != null)
         {
            foreach (CodeQR oCodeQR in value)
               AddCodeQR(oCodeQR);
         }
      }
   }
   
   /// <summary>
   /// Add a new CodeQR in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddCodeQR(CodeQR newCodeQR)
   {
      if (newCodeQR == null)
         return;
      if (this.codeQR == null)
         this.codeQR = new System.Collections.Generic.List<CodeQR>();
      if (!this.codeQR.Contains(newCodeQR))
         this.codeQR.Add(newCodeQR);
   }
   
   /// <summary>
   /// Remove an existing CodeQR from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveCodeQR(CodeQR oldCodeQR)
   {
      if (oldCodeQR == null)
         return;
      if (this.codeQR != null)
         if (this.codeQR.Contains(oldCodeQR))
            this.codeQR.Remove(oldCodeQR);
   }
   
   /// <summary>
   /// Remove all instances of CodeQR from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllCodeQR()
   {
      if (codeQR != null)
         codeQR.Clear();
   }
   public Coordonnees coordonnees;

}
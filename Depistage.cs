// File:    Depistage.cs
// Author:  Gaming VivoBook Pro
// Created: jeudi 3 décembre 2020 17:09:17
// Purpose: Definition of Class Depistage

using System;

public class Depistage
{
   private string nomTest;
   private string lieuTest;
   private DateTime dateTest;
   
   public bool Resultats()
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

}
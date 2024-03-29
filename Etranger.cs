// File:    Etranger.cs
// Author:  Gaming VivoBook Pro
// Created: mercredi 2 d�cembre 2020 17:51:43
// Purpose: Definition of Class Etranger

using System;

public class Etranger : Personne
{
   private string nationalite;
   private DateTime dateArrivee;
   
   public string Provenance()
   {
      throw new NotImplementedException();
   }
   
   public bool ArriveRecent()
   {
      throw new NotImplementedException();
   }
   
   public System.Collections.Generic.List<Coordonnees> coordonnees;
   
   /// <summary>
   /// Property for collection of Coordonnees
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Coordonnees> Coordonnees
   {
      get
      {
         if (coordonnees == null)
            coordonnees = new System.Collections.Generic.List<Coordonnees>();
         return coordonnees;
      }
      set
      {
         RemoveAllCoordonnees();
         if (value != null)
         {
            foreach (Coordonnees oCoordonnees in value)
               AddCoordonnees(oCoordonnees);
         }
      }
   }
   
   /// <summary>
   /// Add a new Coordonnees in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddCoordonnees(Coordonnees newCoordonnees)
   {
      if (newCoordonnees == null)
         return;
      if (this.coordonnees == null)
         this.coordonnees = new System.Collections.Generic.List<Coordonnees>();
      if (!this.coordonnees.Contains(newCoordonnees))
         this.coordonnees.Add(newCoordonnees);
   }
   
   /// <summary>
   /// Remove an existing Coordonnees from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveCoordonnees(Coordonnees oldCoordonnees)
   {
      if (oldCoordonnees == null)
         return;
      if (this.coordonnees != null)
         if (this.coordonnees.Contains(oldCoordonnees))
            this.coordonnees.Remove(oldCoordonnees);
   }
   
   /// <summary>
   /// Remove all instances of Coordonnees from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllCoordonnees()
   {
      if (coordonnees != null)
         coordonnees.Clear();
   }
   public System.Collections.Generic.List<Depistage> depistage;
   
   /// <summary>
   /// Property for collection of Depistage
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Depistage> Depistage
   {
      get
      {
         if (depistage == null)
            depistage = new System.Collections.Generic.List<Depistage>();
         return depistage;
      }
      set
      {
         RemoveAllDepistage();
         if (value != null)
         {
            foreach (Depistage oDepistage in value)
               AddDepistage(oDepistage);
         }
      }
   }
   
   /// <summary>
   /// Add a new Depistage in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddDepistage(Depistage newDepistage)
   {
      if (newDepistage == null)
         return;
      if (this.depistage == null)
         this.depistage = new System.Collections.Generic.List<Depistage>();
      if (!this.depistage.Contains(newDepistage))
         this.depistage.Add(newDepistage);
   }
   
   /// <summary>
   /// Remove an existing Depistage from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveDepistage(Depistage oldDepistage)
   {
      if (oldDepistage == null)
         return;
      if (this.depistage != null)
         if (this.depistage.Contains(oldDepistage))
            this.depistage.Remove(oldDepistage);
   }
   
   /// <summary>
   /// Remove all instances of Depistage from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllDepistage()
   {
      if (depistage != null)
         depistage.Clear();
   }

}
// File:    Etranger.cs
// Author:  Gaming VivoBook Pro
// Created: mercredi 2 décembre 2020 17:51:43
// Purpose: Definition of Class Etranger

using System;
using System.Collections.Generic;

public class Etranger : Personne
{
    private string nationalite;
    private DateTime dateArrivee;
    private string provenance;
    
    public Etranger()
    {
        Identifiant = "Inconnu";
        nationalite = "Inconnue";
    }

    public string Nationalite
    {
        set { nationalite = value; }
        get { return nationalite; }
    }
    public DateTime DateArrivee
    {
        set { dateArrivee = value; }
        get { return dateArrivee; }
    }
    public string Provenance
    {
        set { provenance = value; }
        get { return provenance; }
    }
    
    public bool ArriveRecent()
    {
        if (DateTime.Now.Day - dateArrivee.Day < 15)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public bool Avisite(Lieu CeLieu)
    {
        if (lieuVisite.Contains(CeLieu))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<Lieu> lieuVisite;

    /// <summary>
    /// Property for collection of Coordonnees
    /// </summary>
    /// <pdGenerated>Default opposite class collection property</pdGenerated>
    public List<Lieu> LieuVisite
    {
        get
        {
            if (lieuVisite == null)
                lieuVisite = new List<Lieu>();
            return lieuVisite;
        }
        set
        {
            RemoveAllLieuVisite();
            if (value != null)
            {
                foreach (Lieu oLieuVisite in value)
                    AddLieuVisite(oLieuVisite);
            }
        }
    }

    /// <summary>
    /// Add a new Coordonnees in the collection
    /// </summary>
    /// <pdGenerated>Default Add</pdGenerated>
    public void AddLieuVisite(Lieu newLieuVisite)
    {
        if (newLieuVisite == null)
            return;
        if (this.lieuVisite == null)
            this.lieuVisite = new List<Lieu>();
        if (!this.lieuVisite.Contains(newLieuVisite))
            this.lieuVisite.Add(newLieuVisite);
    }

    /// <summary>
    /// Remove an existing Coordonnees from the collection
    /// </summary>
    /// <pdGenerated>Default Remove</pdGenerated>
    public void RemoveLieuVisite(Lieu oldLieuVisite)
    {
        if (oldLieuVisite == null)
            return;
        if (this.lieuVisite != null)
            if (this.lieuVisite.Contains(oldLieuVisite))
                this.lieuVisite.Remove(oldLieuVisite);
    }

    /// <summary>
    /// Remove all instances of Coordonnees from the collection
    /// </summary>
    /// <pdGenerated>Default removeAll</pdGenerated>
    public void RemoveAllLieuVisite()
    {
        if (lieuVisite != null)
            lieuVisite.Clear();
    }
    public List<Depistage> depistage;
   
    /// <summary>
    /// Property for collection of Depistage
    /// </summary>
    /// <pdGenerated>Default opposite class collection property</pdGenerated>
    public List<Depistage> Depistage
    {
        get
        {
            if (depistage == null)
            depistage = new List<Depistage>();
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
            this.depistage = new List<Depistage>();
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
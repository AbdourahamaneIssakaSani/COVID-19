// File:    Citoyen.cs
// Author:  Gaming VivoBook Pro
// Created: mercredi 2 d�cembre 2020 17:51:35
// Purpose: Definition of Class Citoyen

using System;
using System.Linq;
using System.Collections.Generic;
using COVID_19;

/// il faut v�rifier aussi s�il a voyag� dans les 2 semaines pr�c�dents la date actuelle, informations tr�s impotante pour les agents de sant�.
public class Individu : Personne
{
    private DateTime derniereDateVoyage;
    private string autresDetails;

    public DateTime DateVoyage
    {
        get { return derniereDateVoyage; }
        set { derniereDateVoyage = value; }
    }
    
    public Individu()
    {
        Identifiant = Guid.NewGuid().ToString("N").Substring(0, 8);
        Nationalite = "";
    }
    public Individu(Individu individu)
    {
        this.Identifiant = individu.Identifiant;
        this.Nom = individu.Nom;
        this.Prenom = individu.Prenom;
        this.Age = individu.Age;
        this.Genre = individu.Genre;
        this.Nationalite = individu.Nationalite;
        this.Residence = individu.Residence;
        this.DateVoyage = individu.DateVoyage;
        this.LieuVisite = individu.LieuVisite;
        this.Depistage = individu.Depistage;
    }
    public bool AVoyageRecemment()
    {
        //teste s�il a voyag� dans les 14 derniers jours au moins
        if((DateTime.Now - derniereDateVoyage).TotalDays <= 14)
        {
            return true;
        }
        else
        {
            return false;
        }
        //throw new NotImplementedException();
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
    public string AutresDetails
    {
        get { return autresDetails; }
        set { autresDetails = value; }
    }

    public bool EstEtranger()
    {
        if(Nationalite != "marocaine")
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
    
    private List<Depistage> depistage;
   
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
// File:    Lieu.cs
// Author:  Gaming VivoBook Pro
// Created: jeudi 3 décembre 2020 17:30:03
// Purpose: Definition of Class Lieu

using System;
using System.Collections.Generic;
using System.Device.Location;

/// un lieu visité est défini par des coordonées, dès qu’il bouge on enregistre les anciennes coordonnées comme lieu visité
public class Lieu
{
    private GeoCoordinateWatcher coordonnees;
    private DateTime date;
    private TimeSpan heure;
    //private int duree;
    
    public Lieu()
    {       
        coordonnees = new GeoCoordinateWatcher(); 
        coordonnees.Start();
        date = DateTime.Now.Date;
        heure = DateTime.Now.TimeOfDay;        
    }
    public GeoCoordinateWatcher Localisation()
    {
        return coordonnees;
    }
    public bool Avisite()
    {
        throw new NotImplementedException();
    }
   
    public List<CodeQR> codeQR;
   
    /// <summary>
    /// Property for collection of CodeQR
    /// </summary>
    /// <pdGenerated>Default opposite class collection property</pdGenerated>
    public List<CodeQR> CodeQR
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
            this.codeQR = new List<CodeQR>();
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
    //public Coordonnees coordonnees;

}
// File:    Depistage.cs
// Author:  Gaming VivoBook Pro
// Created: jeudi 3 décembre 2020 17:09:17
// Purpose: Definition of Class Depistage

using System;
using System.Linq;
using System.Collections.Generic;

public class Depistage
{
    private string nomTest;
    private DateTime dateTest;
    private bool positif;
    private Lieu lieu;
    public Depistage()
    {
        nomTest = "PCR";
        dateTest = DateTime.Now;
        positif = false;
        lieu = new Lieu();

    }
    public Lieu Endroit
    {
        get { return lieu; }
    }
    public DateTime Date
    {
        get { return dateTest; }
        set { dateTest = value; }
    }
    public string Test
    {
        get { return nomTest; }
        set { nomTest = value; }
    }    
    public bool Positif
    {
        get { return positif; }
        set { positif = value; }
        //throw new NotImplementedException();
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
            codeQR = new List<CodeQR>();
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
    

}
// File:    Consultationenligne.cs
// Author:  Gaming VivoBook Pro
// Created: jeudi 3 décembre 2020 18:32:05
// Purpose: Definition of Class Consultationenligne

using System;

/// en fonction de son code QR il fait des consultation en ligne ou pas
public class Consultationenligne
{
    private DateTime date;
    private string rapport;
    
    public Consultationenligne()
    {
        date = DateTime.Now;
        rapport = "";
    }
    public string Avancement()
    {
        return rapport;
    }
    public string Rapport
    {
        set { rapport = value; }
    }
    public DateTime Date
    {
        get { return date; }
    }
   //public Vaccine[] Association12;

}
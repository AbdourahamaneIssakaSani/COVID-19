// File:    Vaccine.cs
// Author:  Gaming VivoBook Pro
// Created: jeudi 3 décembre 2020 18:35:40
// Purpose: Definition of Class Vaccine

using System;

/// s’il est vacciné selon son code QR ou son statut(agent de santé, personne agée) car le vaccin n’est pas disponible pour tous, il doit renseigner cela au cours de sa consultation en ligne. De ce fait, les vaccinés peuvent avoir un code Jaune puisqu’on est vacciné seulement si on est considéré "à risque"
public class Traitement
{
    private DateTime date;    
    private string details;
    private bool vaccine;
    
    public Traitement()
    {
        details = "R.A.S";
        vaccine = false;
        date = DateTime.Now.Date;
    }
    public DateTime DateOrdonnance
    {
        set { date = value; }
        get { return date; }
    }

    public string Details
    {
        set { details = value; }
        get { return details; }
    }
    
    public bool estVaccine
    {
        set { vaccine = value; }
        get { return vaccine; }
    }
   
    public CodeQR codeQRA;
    public Consultationenligne consultationenligneB;

}
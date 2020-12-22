// File:    CodeQR.cs
// Author:  Gaming VivoBook Pro
// Created: jeudi 3 décembre 2020 17:43:00
// Purpose: Definition of Class CodeQR

using System;
using COVID_19;

/// il obtient un code QR après un test de dépistage sinon en fonction de ses déplacements, c’est-à-dire s’il a partagé les mêmes coordonnées qu’un malade au même moment ou selon certaines conditions définie par les autorités sanitaires.
/// Le code QR contient les informations suivantes :
/// --- en quarantaine
/// --- confiné à la maison
/// --- hospitalisé
/// --- en observation
public class CodeQR
{
    private static int id = 1000;
    private Couleur couleur;
    private DateTime date;
    //private string etat;
    private string details;
    
    public CodeQR()
    {
        couleur = Couleur.vert;
        date = DateTime.Now;
        CodeQR.id++;
    }
    public Couleur Etat
    {
        get { return couleur; }
        set { couleur = value; }
    }
    public DateTime dateEmission
    {
        get { return date; }
        set { date = value; }
    }
    public string Details
    {
        get { return details; }
        set { details = value; }
    }
   // public Vaccine[] Association12;

}
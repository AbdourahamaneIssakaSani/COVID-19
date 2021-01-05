// File:    Personne.cs
// Author:  Gaming VivoBook Pro
// Created: vendredi 4 décembre 2020 18:18:59
// Purpose: Definition of Class Personne

using System;


public class Personne
{
    private string nom;
    private string prenom;
    private int age;
    private Sexe sexe;
    private string residence;
    private string nationalite;
    private static string identifiant;
    
    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }
    public string Prenom
    {
        get { return prenom; }
        set { prenom = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public Sexe Genre
    {
        get { return sexe; }
        set { sexe = value; }
    }
    public string Residence
    {
        get { return residence; }
        set { residence = value; }
    }

    public string Nationalite
    {
        get { return nationalite; }
        set { nationalite = value; }
    }
    public string Identifiant
    {
        set { identifiant = value; }
        get { return identifiant; }
    }
   
   /* Adresse déjà fournie par les setters de adresse
    * public string Adresse()
   {
      return;
   }*/

}
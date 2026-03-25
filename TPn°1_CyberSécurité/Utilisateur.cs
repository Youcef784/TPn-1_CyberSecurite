using System;
using System.Collections.Generic;
using System.Text;

namespace TPn_1_CyberSécurité
{
    public class Utilisateur
    {
        private DateTime DateCreation;
        private string Email;
        private int Id;
        private string MotdePasse;
        private string Nom;
        private int ProfilSecuriteId;
        private ProfilSecurite ProfilSecurite;


        public Utilisateur(DateTime dateCreation, string email, int id, string motdePasse, string nom, int profilSecuriteId)
        {
            DateCreation = dateCreation;
            Email = email;
            Id = id;
            MotdePasse = motdePasse;
            Nom = nom;
            ProfilSecuriteId = profilSecuriteId;
        }

        public override string ToString()
        {
            return $"Utilisateur: {Nom}, Email: {Email}, Id: {Id}, Date de Création: {DateCreation}, Profil de Sécurité Id: {ProfilSecuriteId}";
        }


    }
}

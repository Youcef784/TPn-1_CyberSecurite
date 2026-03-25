using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TPn_1_CyberSécurité
{
    public class ProfilSecurite
    {
        private bool CompteVerrouille;
        private DateTime DateVerrouillage;
        private string DerniereConnexion;
        private int Id;
        private bool MfaActive;
        private int NbTentativesEchouer;
        private int NiveauAcces;

        public ProfilSecurite(int id, bool compteVerrouille, DateTime dateVerrouillage, string derniereConnexion, bool mfaActive, int nbTentativesEchouer, int niveauAcces)
        {
            Id = id;
            CompteVerrouille = compteVerrouille;
            DateVerrouillage = dateVerrouillage;
            DerniereConnexion = derniereConnexion;
            MfaActive = mfaActive;
            NbTentativesEchouer = nbTentativesEchouer;
            NiveauAcces = niveauAcces;
        }
        public override string ToString()
        {
            return $"Profil de Sécurité: Id: {Id}, Compte Verrouillé: {CompteVerrouille}, Date de Verrouillage: {DateVerrouillage}, Dernière Connexion: {DerniereConnexion}, MFA Active: {MfaActive}, Nombre de Tentatives Échouées: {NbTentativesEchouer}, Niveau d'Accès: {NiveauAcces}";
        }
    }
}

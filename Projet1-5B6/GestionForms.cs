using Projet1_5B6.Forms_Admin;
using Projet1_5B6.Forms_Prepose;
using Projet1_5B6.Models;
using System;
using System.Windows.Forms;

namespace Projet1_5B6
{
    class GestionForms
    {
        public static Utilisateur utilisateurConnecte;
        private MenuUtilisateur menuUtilisateur;
        private readonly FrmConnexion frmConnexion;

        public GestionForms()
        {
            frmConnexion = new FrmConnexion();
        }

        public void Demarrer()
        {
            frmConnexion.Connexion += GestionConnexion;

            Application.Run(frmConnexion);
        }

        private void GestionConnexion(object sender, Utilisateur util)
        {
            utilisateurConnecte = util;

            menuUtilisateur = DeterminerMenuUtilisateur();
            menuUtilisateur.Deconnexion += GestionDeconnexion;

            if (utilisateurConnecte.EstAdmin)
            {
                new FrmAccueilAdmin(menuUtilisateur).ShowDialog();
            }
            else
            {
                new FrmAccueilPrepose(menuUtilisateur).ShowDialog();
            }
        }

        private void GestionDeconnexion(object sender, EventArgs e)
        {
            this.frmConnexion.Deconnexion();
        }

        private MenuUtilisateur DeterminerMenuUtilisateur()
        {
            if (utilisateurConnecte.EstAdmin)
            {
                return new MenuAdmin();
            }
            else
            {
                return new MenuPrepose();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1_5B6.Forms_Admin;
using Projet1_5B6.Forms_Prepose;
using Projet1_5B6.Models;

namespace Projet1_5B6
{
    class GestionForms
    {
        private Utilisateur utilisateurConnecte;
        private MenuUtilisateur menuUtilisateur;

        public void Demarrer()
        {
            FrmConnexion frmConnexion = new FrmConnexion();

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
                new FrmAccueilAdmin(menuUtilisateur).Show();
            }
            else
            {
                new FrmAccueilPrepose(menuUtilisateur).Show();
            }
        }

        private void GestionDeconnexion(object sender, EventArgs e)
        {
            utilisateurConnecte = null;
            menuUtilisateur = null;

            FrmConnexion frmConnexion = new FrmConnexion();

            frmConnexion.Connexion += GestionConnexion;

            frmConnexion.Show();
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

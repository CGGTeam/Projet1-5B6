using Projet1_5B6.Forms_Admin;
using Projet1_5B6.Forms_Client;
using System;
using System.Windows.Forms;

namespace Projet1_5B6
{
    public partial class FrmConnexion : Form
    {
        private object utilisateur = null;

        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (!EstUtilisateurValide()) return;

            if (EstAdmin())
            {
                Hide();
                new FrmAccueilAdmin().Show();
            }
            else
            {
                Hide();
                new FrmAccueilClient().Show();
            }
        }

        private bool EstAdmin()
        {
            //TODO: authentifier pour de vrai
            return false;
        }

        private bool EstUtilisateurValide()
        {
            //TODO: authentifier pour de vrai
            return true;
        }
    }
}

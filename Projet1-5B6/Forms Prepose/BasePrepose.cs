using System;
using System.Windows.Forms;
using Projet1_5B6.Forms_Commun;

namespace Projet1_5B6.Forms_Client
{
    public partial class BasePrepose : Form
    {
        public BasePrepose()
        {
            InitializeComponent();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientsInvites fClientsInvites = new FrmClientsInvites();
            Hide();
            fClientsInvites.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmConnexion().Show();
        }

        private void planificationSoinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1_5B6.Forms_Commun;
using Projet1_5B6.Forms_Commun.Forms_Gestion_Soins;

namespace Projet1_5B6.Forms_Admin
{
    public partial class BaseAdmin : Form
    {
        public BaseAdmin()
        {
            InitializeComponent();
        }

        private void gestionAssistantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmGestionAssistants().Show();
        }

        private void gestionClientsEtInvitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmClientsInvites().Show();
        }

        private void gestionSoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmGestionSoins().Show();
        }

        private void gestionChambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmGestionChambresEtTypes().Show();
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

        private void planificationSOinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmPlanificationSoins();
        }
    }
}

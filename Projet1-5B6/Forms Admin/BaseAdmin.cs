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
            FrmGestionAssistants frmGestionAssistants = new FrmGestionAssistants();
            Hide();
            frmGestionAssistants.Show();
        }

        private void gestionClientsEtInvitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientsInvites fClients = new FrmClientsInvites();
            Hide();
            fClients.Show();
        }

        private void gestionSoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmGestionSoins().Show();
        }
    }
}

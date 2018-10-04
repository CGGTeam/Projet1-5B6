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
            Hide();
            new FrmGestionAssistants().Show();
            Close();
        }

        private void gestionClientsEtInvitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmClientsInvites().Show();
            Close();
        }

        private void gestionSoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmGestionSoins().Show();
            Close();
        }

        private void gestionChambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmGestionChambresEtTypes().Show();
            Close();
        }
    }
}

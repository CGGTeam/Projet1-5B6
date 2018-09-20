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
    }
}

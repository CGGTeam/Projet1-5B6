using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Commun.Forms_Gestion_Clients
{
    public partial class FrmAjoutInvite : Form
    {
        private readonly BD5B6TP1_ConstantinBrassardLaheyDataSet.InviteRow nouvelInvite;

        public FrmAjoutInvite(BD5B6TP1_ConstantinBrassardLaheyDataSet.InviteRow nouvelInvite)
        {
            InitializeComponent();
            this.nouvelInvite = nouvelInvite;
        }

        private void inviteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inviteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);

        }

        private void FrmAjoutInvite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Invite' table. You can move, or remove it, as needed.
            this.inviteTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Invite);

            tbNoClient.Text = nouvelInvite.NoClient.ToString();
            tbNoInvite.Text = nouvelInvite.NoInvite.ToString();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            nouvelInvite.Nom = tbNom.Text;
            nouvelInvite.Prenom = tbPrenom.Text;

            this.DialogResult = DialogResult.OK;

            Close();
        }
    }
}

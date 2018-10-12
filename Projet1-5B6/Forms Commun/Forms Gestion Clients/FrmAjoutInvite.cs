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
        private readonly bool modeModif;
        private Control[] controlesAValider;

        public FrmAjoutInvite(BD5B6TP1_ConstantinBrassardLaheyDataSet.InviteRow nouvelInvite, bool modeModif = false)
        {
            InitializeComponent();
            this.nouvelInvite = nouvelInvite;


            controlesAValider = new Control[]
            {
                tbPrenom,
                tbNom,
            };

            this.modeModif = modeModif;
        }

        private void FrmAjoutInvite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Invite' table. You can move, or remove it, as needed.
            this.inviteTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Invite);

            if (modeModif)
            {
                tbPrenom.Text = nouvelInvite.Prenom;
                tbNom.Text = nouvelInvite.Nom;

                Text = "Modification Invite";
                btnConfirmer.Text = "Confirmer les modifications";
                lblEntent.Text = "Modifier Invite";
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            nouvelInvite.Nom = tbNom.Text;
            nouvelInvite.Prenom = tbPrenom.Text;

            this.DialogResult = DialogResult.OK;

            Close();
        }

        private void Valider()
        {
            btnConfirmer.Enabled = controlesAValider.All(ctrl => ctrl.Text.Trim() != "");
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            Valider();
        }

        private void tbPrenom_TextChanged(object sender, EventArgs e)
        {
            Valider();
        }
    }
}

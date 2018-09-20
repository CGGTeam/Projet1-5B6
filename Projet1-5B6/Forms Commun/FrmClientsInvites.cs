using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Commun
{
    public partial class FrmClientsInvites : Form
    {
        public FrmClientsInvites()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
        }

        private void FormClientsInvites_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Invite' table. You can move, or remove it, as needed.
            this.inviteTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Invite);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Client);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Client);

        }


        private void clientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            

        }

        private void btnAjoutCli_Click(object sender, EventArgs e)
        {
            var nouveauClient = bD5B6TP1_ConstantinBrassardLaheyDataSet.Client.NewClientRow();
            FrmAjoutClient frmAjout = new FrmAjoutClient(nouveauClient);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.Client.AddClientRow(nouveauClient);
            clientBindingSource.MoveLast();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Validate();
            clientBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
        }

        private void btnClientSuivant_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveNext();
        }

        private void btnClientPrecedent_Click(object sender, EventArgs e)
        {
            clientBindingSource.MovePrevious();
        }

        private void btnSupprimerCli_Click(object sender, EventArgs e)
        {
            DataRowView selection = (DataRowView) clientBindingSource.Current;

            if (!EstSupprimable(selection)) return;

            selection.Delete();
        }

        private bool EstSupprimable(DataRowView selection)
        {
            //TODO:unstubify
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Commun
{
    public partial class FrmClientsInvites : Form
    {
        public FrmClientsInvites()
        {
            InitializeComponent();
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
            ADOUtils.SupprimerSelection(clientBindingSource, EstSupprimable);
        }

        private bool EstSupprimable(DataRowView selection)
        {
            //TODO:unstubify
            return true;
        }

        private void inviteDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            int noInvite = DeterminerNoNouvelInvite();

            ((DataRowView) inviteBindingSource.Current)["NoInvite"] = noInvite;

            VerifierNbInvites();
        }

        private int DeterminerNoNouvelInvite()
        {
            int plusPetitNoLibre = IdClientCourant + 1;

            IEnumerable<DataRowView> listeInvites = inviteBindingSource.List.Cast<DataRowView>();

            foreach (DataRowView invite in listeInvites.Where(IdNonNull).OrderBy(SortParId))
            {
                var noInvite = invite["NoInvite"];

                if (plusPetitNoLibre == Convert.ToInt32(noInvite))
                {
                    plusPetitNoLibre++;
                }
            }

            return plusPetitNoLibre;
        }

        private bool IdNonNull(DataRowView invite)
        {
            return !(invite["NoInvite"] is DBNull);
        }

        private int SortParId(DataRowView invite)
        {
            return Convert.ToInt32(invite["NoInvite"]);
        }

        private int IdClientCourant
        {
            get
            {
                DataRowView clientCourant = (DataRowView)clientBindingSource.Current;

                int idClientCourant = Convert.ToInt32(clientCourant["NoClient"]);

                return idClientCourant;
            }
        }

        private void VerifierNbInvites()
        {
            bool nbInvitesEnDessousDeLimite = inviteBindingSource.List.Count < 9;
            inviteBindingSource.AllowNew = nbInvitesEnDessousDeLimite;
        }

        private void inviteDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            VerifierNbInvites();
        }

        private void inviteDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var cellule = inviteDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cellule.Value.ToString().Trim() == "")
            {
                e.Cancel = true;
                cellule.ErrorText = "Cette cellule doit être remplie";
            }
        }

        private void inviteDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = InviteAUnSoinPlanifie();
        }

        private bool InviteAUnSoinPlanifie()
        {
            return false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            clientBindingSource.ResetBindings(false);
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Commun
{
    public partial class FrmGestionSoins : Form
    {
        public FrmGestionSoins()
        {
            InitializeComponent();
        }

        private void FrmGestionSoins_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeSoin' table. You can move, or remove it, as needed.
            this.typeSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeSoin);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin' table. You can move, or remove it, as needed.
            this.soinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin);

        }

        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {
            var nouveauSoin = bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin.NewSoinRow();
            FrmAjoutSoin frmAjout = new FrmAjoutSoin(nouveauSoin);

            nouveauSoin.NoSoin = TrouverNoSoin();
            nouveauSoin.Duree = new TimeSpan(0, 1, 0, 0);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin.AddSoinRow(nouveauSoin);
            soinBindingSource.MoveLast();
        }

        private int TrouverNoSoin()
        {
            int plusGrandId = 0;

            foreach (DataRow rangee in bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin.Rows)
            {
                int id = Convert.ToInt32(rangee["NoSoin"]);
                if (id > plusGrandId)
                    plusGrandId = id;
            }

            return plusGrandId + 1;
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Validate();
            soinBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DataRowView selection = (DataRowView)soinBindingSource.Current;

            if (!EstSupprimable(selection)) return;

            selection.Delete();
        }

        private bool EstSupprimable(DataRowView selection)
        {
            //TODO: validation
            return true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            soinBindingSource.ResetBindings(false);
        }
    }
}
﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Commun
{
    public partial class FrmAjoutSoin : Form
    {
        private BD5B6TP1_ConstantinBrassardLaheyDataSet.SoinRow soin;
        private readonly Control[] controlesAValider;

        public FrmAjoutSoin(BD5B6TP1_ConstantinBrassardLaheyDataSet.SoinRow soin)
        {
            InitializeComponent();
            this.soin = soin;

            controlesAValider = new Control[]
            {
                tbDescription,
                tbPrix,
                cmbTypeSoin,
            };
        }

        private void FrmAjoutSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeSoin' table. You can move, or remove it, as needed.
            this.typeSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeSoin);
            tbNoSoin.Text = soin.NoSoin.ToString();
            tbDuree.Text = "60";
        }

        private void ValiderFormulaire(object sender, EventArgs e)
        {
            bool formulaireComplet = controlesAValider.All(ControleNonVide);

            btnConfirmer.Enabled = formulaireComplet;
        }

        private bool ControleNonVide(Control ctrl)
        {
            return ctrl.Text.Trim() != "";
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            soin.Description = tbDescription.Text;
            soin.NoTypeSoin = (int)cmbTypeSoin.SelectedValue;
            soin.Prix = Convert.ToDecimal(tbPrix.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void tbPrix_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Convert.ToDecimal(tbPrix.Text);
            }
            catch (Exception exception)
            {
                e.Cancel = true;
            }
        }
    }
}

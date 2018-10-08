using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Commun.Forms_Gestion_Soins
{
    public partial class FrmPlanifierSoin : Form
    {
        private readonly BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinRow planifSoin;

        public FrmPlanifierSoin(BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinRow planifSoin)
        {
            InitializeComponent();
            this.planifSoin = planifSoin;
        }

        private void FrmPlanifierSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtDescriptionSoin' table. You can move, or remove it, as needed.
            this.noEtDescriptionSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtDescriptionSoin);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsAssistants' table. You can move, or remove it, as needed.
            this.noEtNomsAssistantsTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsAssistants);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsClientsInvites' table. You can move, or remove it, as needed.
            this.noEtNomsClientsInvitesTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsClientsInvites);
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            planifSoin.NoSoin = (int) cboSoin.SelectedValue;
            planifSoin.NoAssistant = (int) cboAssistant.SelectedValue;
            planifSoin.NoPersonne = (int) cboPatient.SelectedValue;
            planifSoin.DateHeure = dtpDateHeure.Value;

            this.DialogResult = DialogResult.OK;

            Close();
        }
    }
}

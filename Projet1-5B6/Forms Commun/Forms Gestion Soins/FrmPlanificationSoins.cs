using Projet1_5B6.WinForms_ext;
using System;
using System.Data;
using System.Windows.Forms;
using Projet1_5B6.Forms_Admin;
using Projet1_5B6.Models;

namespace Projet1_5B6.Forms_Commun.Forms_Gestion_Soins
{
    public partial class FrmPlanificationSoins : BaseFormGestion
    {
        public FrmPlanificationSoins(MenuUtilisateur menu) : base(menu)
        {
            InitializeComponent();
        }

        private void FrmPlanificationSoins_Load(object sender, EventArgs e)
        {
            colDateHeure = new CalendarColumn();

            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsAssistants' table. You can move, or remove it, as needed.
            this.noEtNomsAssistantsTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsAssistants);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsAssistants' table. You can move, or remove it, as needed.
            this.noEtNomsAssistantsTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsAssistants);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsClientsInvites' table. You can move, or remove it, as needed.
            this.noEtNomsClientsInvitesTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsClientsInvites);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtDescriptionSoin' table. You can move, or remove it, as needed.
            this.noEtDescriptionSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtDescriptionSoin);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin' table. You can move, or remove it, as needed.
            this.planifSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            ADOUtils.SupprimerSelection(planifSoinBindingSource, EstSupprimable);
        }

        private bool EstSupprimable(DataRowView planifSoin)
        {
            return true;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var nouveauSoinPlanifie = bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin.NewPlanifSoinRow();
            FrmPlanifierSoin frmAjout = new FrmPlanifierSoin(nouveauSoinPlanifie, bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin.AddPlanifSoinRow(nouveauSoinPlanifie);
            planifSoinBindingSource.MoveLast();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Validate();
            planifSoinBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            planifSoinBindingSource.ResetBindings(false);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DateTime dateHeureSelec = (DateTime)((DataRowView)planifSoinBindingSource.Current)["DateHeure"];
            int noAssistantSelec = (int)((DataRowView)planifSoinBindingSource.Current)["NoAssistant"];
            int noPersonneSelec = (int)((DataRowView)planifSoinBindingSource.Current)["NoPersonne"];

            BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinRow rowSelec =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin.FindByNoPersonneNoAssistantDateHeure(noPersonneSelec, noAssistantSelec, dateHeureSelec);

            FrmPlanifierSoin frmAjout = new FrmPlanifierSoin(rowSelec, bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin, true);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) rowSelec.CancelEdit();
        }
    }
}

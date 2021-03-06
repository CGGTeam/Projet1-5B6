﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters;

namespace Projet1_5B6.Forms_Commun.Forms_Gestion_Soins
{
    public partial class FrmPlanifierSoin : Form
    {
        private readonly BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinRow planifSoin;
        private readonly AssistantSoinTableAdapter assistantSoinTableAdapter;
        private readonly bool modifMode;
        private readonly DateTime ancienneDateHeure;
        private readonly int ancienNoPersonne;
        private readonly int ancienNoAssistant;
        private Control[] controlesAValider;

        public FrmPlanifierSoin(BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinRow planifSoin, BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinDataTable dataTable, bool modifMode = false)
        {
            InitializeComponent();
            this.planifSoin = planifSoin;

            this.assistantSoinTableAdapter = new AssistantSoinTableAdapter();

            this.modifMode = modifMode;

            controlesAValider = new Control[]
            {
                dtpDateHeure,
                cboAssistant,
                cboPatient,
                cboSoin,
            };

            if (modifMode)
            {
                ancienneDateHeure = this.planifSoin.DateHeure;
                ancienNoPersonne = this.planifSoin.NoPersonne;
                ancienNoAssistant = this.planifSoin.NoAssistant;
            }

            foreach (DataRow planifSoinRow in dataTable)
            {
                bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin.ImportRow(planifSoinRow);
            }
        }

        private void FrmPlanifierSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtDescriptionSoin' table. You can move, or remove it, as needed.
            this.noEtDescriptionSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtDescriptionSoin);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsAssistants' table. You can move, or remove it, as needed.
            this.noEtNomsAssistantsTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsAssistants);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsClientsInvites' table. You can move, or remove it, as needed.
            this.noEtNomsClientsInvitesTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsClientsInvites);

            this.assistantSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin);

            dtpDateHeure.Validating += Validation.ValiderDateHeureReservation(errorProvider);
            dtpDateHeure.Validating += ValiderDisponibilites;
            dtpDateHeure.Value = DateTime.Now;

            if (modifMode)
            {
                cboAssistant.SelectedValue = planifSoin.NoAssistant;
                cboPatient.SelectedValue = planifSoin.NoPersonne;
                cboSoin.SelectedValue = planifSoin.NoSoin;
                dtpDateHeure.Value = planifSoin.DateHeure;

                Text = "Modification d'un rendez-vous";
                lblEntete.Text = "Modifer planification soin";
                btnConfirmer.Text = "Confirmer les modifications";
            }
        }

        private void ValiderDisponibilites(object sender, CancelEventArgs e)
        {
            bool patientEstDisponible = PersonneEstDisponible(dtpDateHeure.Value, (int)cboPatient.SelectedValue);
            bool assistantEstDisponible = this.AssistantEstDisponible(dtpDateHeure.Value, (int) cboAssistant.SelectedValue);

            if (!patientEstDisponible && !assistantEstDisponible)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpDateHeure, "Le patient et l'assistant ne sont pas disponible à cette heure");
            }
            else if (!patientEstDisponible)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpDateHeure, "Le patient n'est pas disponible à cette heure");
            } 
            else if (!assistantEstDisponible)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpDateHeure, "L'assistant n'est pas disponible à cette heure");
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
           planifSoin.NoSoin = (int)cboSoin.SelectedValue;
            planifSoin.NoAssistant = (int)cboAssistant.SelectedValue;
            planifSoin.NoPersonne = (int)cboPatient.SelectedValue;
            planifSoin.DateHeure = dtpDateHeure.Value;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void cboPatient_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(cboPatient, "");

            if (!PersonneEstDisponible(dtpDateHeure.Value, (int)cboPatient.SelectedValue))
            {
                e.Cancel = true;
                errorProvider.SetError(cboPatient, "Ce patient n'est pas disponible à cette heure");
            }
        }

        private void cboAssistant_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(cboAssistant, "");

            if (!AssistantEstDisponible(dtpDateHeure.Value, (int)cboAssistant.SelectedValue))
            {
                e.Cancel = true;
                errorProvider.SetError(cboAssistant, "Cet assistant n'est pas disponible à cette heure");
            }
        }

        private bool AssistantEstDisponible(DateTime heure, int idAssistant)
        {
            IEnumerable<BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinRow> soinsPlanifiesAssistant =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin.Where(rangee => rangee.NoAssistant == idAssistant);

            if (idAssistant == ancienNoAssistant)
            {
                return true;
            }

            foreach (BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinRow soinPlanifie in soinsPlanifiesAssistant)
            {
                DateTime dateHeure = soinPlanifie.DateHeure;
                if (Validation.DateTimesOverlap(heure, dateHeure) &&
                    ancienNoAssistant != idAssistant &&
                    !Validation.DateTimesOverlap(ancienneDateHeure, heure))
                {
                    return false;
                    
                }
            }

            return true;
        }

        private bool PersonneEstDisponible(DateTime heure, int idPersonne)
        {
            IEnumerable<BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinRow> soinsPlanifiesPersonne =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin.Where(rangee => rangee.NoPersonne == idPersonne);

            foreach (BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinRow soinPlanifie in soinsPlanifiesPersonne)
            {
                DateTime dateHeure = soinPlanifie.DateHeure;
                if (Validation.DateTimesOverlap(heure, dateHeure) && 
                    ancienNoPersonne != idPersonne && 
                    !Validation.DateTimesOverlap(ancienneDateHeure, heure))
                {
                    return false;
                }
            }

            return true;
        }

        private void cboAssistant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IEnumerable<BD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoinRow> soinsOffertsAssistant =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin.Where(rangee => rangee.NoAssistant == (int)cboAssistant.SelectedValue);
            IEnumerable<BD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtDescriptionSoinRow> noDescSoinsOfferts =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtDescriptionSoin.Where(noEtDescSoin => soinsOffertsAssistant.Any(soinOff => soinOff.NoSoin == noEtDescSoin.NoSoin));

            object selectionAvant = cboSoin.SelectedValue;
            cboSoin.DataSource =
                new BindingList<BD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtDescriptionSoinRow>(noDescSoinsOfferts.ToList());

            if (cboSoin.SelectedValue != selectionAvant)
            {
                ttpModifSoinsDispos.Show("Le soin sélectionné a été changé", cboSoin, 3000);
            }
        }

        private void Valider()
        {
            btnConfirmer.Enabled = controlesAValider.All(ctrl => ctrl.Text.Trim() != "");
        }
    }
}

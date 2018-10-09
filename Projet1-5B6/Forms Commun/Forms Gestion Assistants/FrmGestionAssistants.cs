using Projet1_5B6.Forms_Admin.Forms_Gestion_Assistants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1_5B6.Models;

namespace Projet1_5B6.Forms_Admin
{
    public partial class FrmGestionAssistants : BaseFormGestion
    {
        public FrmGestionAssistants(MenuUtilisateur menu) : base(menu)
        {
            InitializeComponent();
        }

        private void FrmGestionAssistants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin' table. You can move, or remove it, as needed.
            this.soinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistanSoinDescription' table. You can move, or remove it, as needed.
            this.assistanSoinDescriptionTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistanSoinDescription);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin' table. You can move, or remove it, as needed.
            this.assistantSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin' table. You can move, or remove it, as needed.
            this.assistantSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Assistant' table. You can move, or remove it, as needed.
            this.assistantTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Assistant);

        }

        private void btnAjouterAssistant_Click(object sender, EventArgs e)
        {
            var nouveauAssistant = bD5B6TP1_ConstantinBrassardLaheyDataSet.Assistant.NewAssistantRow();
            FrmAddAssistant frmAjout = new FrmAddAssistant(nouveauAssistant);

            nouveauAssistant.NoAssistant = TrouverNoAssistant();

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.Assistant.AddAssistantRow(nouveauAssistant);
            assistantBindingSource.MoveLast();
        }
        private int TrouverNoAssistant()
        {
            int plusGrandId = 0;

            foreach (DataRow rangee in bD5B6TP1_ConstantinBrassardLaheyDataSet.Assistant.Rows)
            {
                int id = Convert.ToInt32(rangee["NoAssistant"]);
                if (id > plusGrandId)
                    plusGrandId = id;
            }

            return plusGrandId + 1;
        }


        private void btnSupprimerAssistant_Click(object sender, EventArgs e)
        {
            ADOUtils.SupprimerSelection(assistantBindingSource, EstSupprimable);
        }
        private bool EstSupprimable(DataRowView selection)
        {
            //TODO: On ne peut supprimer un assistant s’il a des planifications de soins lui sont assignées
            return true;
        }

        private void btnModifierAssistant_Click(object sender, EventArgs e)
        {
            Validate();
            assistantBindingSource.EndEdit();
            assistantSoinBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            assistantBindingSource.ResetBindings(false);
            assistantSoinBindingSource.ResetBindings(false);
        }

        private void btnSupprimerSoin_Click(object sender, EventArgs e)
        {
            ADOUtils.SupprimerSelection(assistantSoinBindingSource, EstSupprimableSoin);
        }
        private bool EstSupprimableSoin(DataRowView selection)
        {
            //TODO: On ne peut supprimer un soin offert par un assistant si le soin est présent dans une planification.
            return true;
        }
        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {
            var nouveauSoinsAssistant = bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin.NewAssistantSoinRow();

            nouveauSoinsAssistant.NoAssistant = Convert.ToInt32(assistantDataGridView.CurrentRow.Cells[0].Value);
            nouveauSoinsAssistant.NoSoin = (int)listSoin.SelectedValue;
            bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin.AddAssistantSoinRow(nouveauSoinsAssistant);
            assistantBindingSource.MoveLast();

            this.assistanSoinDescriptionTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistanSoinDescription);
        }
    }
}

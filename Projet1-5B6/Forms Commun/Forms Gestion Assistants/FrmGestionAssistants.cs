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
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin' table. You can move, or remove it, as needed.
            this.noEtDescriptionSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtDescriptionSoin);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin' table. You can move, or remove it, as needed.
            this.soinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin);
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
        private void btnModifier_Click(object sender, EventArgs e)
        {           
            FrmAddAssistant frmAjout = new FrmAddAssistant(null);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            this.assistantTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Assistant);
            assistantDataGridView.Update();

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
            if(ADOUtils.SupprimerSelection(assistantBindingSource, EstSupprimable))
            {
               foreach(DataRowView row in assistantSoinBindingSource)
                {
                    try
                    {
                        if ((int)row[0] == Convert.ToInt32(assistantSoinDataGridView.CurrentRow.Cells[0].Value))
                            row.Delete();
                    }
                    catch (Exception exep) { };
                }
            }
        }
        private bool EstSupprimable(DataRowView selection)
        {
            int noAssistant = (int)selection[0];
            int noSoin = -1;
            return CheckSoinsPlanif(noAssistant, noSoin);
        }

        private void btnModifierAssistant_Click(object sender, EventArgs e)
        {
            Validate();
            assistantBindingSource.EndEdit();
            assistantSoinBindingSource.EndEdit();

            assistantSoinTableAdapter.Update(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
            assistantTableAdapter.Update(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            assistantBindingSource.ResetBindings(false);
            assistantSoinBindingSource.ResetBindings(false);

            assistantSoinTableAdapter.Update(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
            assistantTableAdapter.Update(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
        }

        private void btnSupprimerSoin_Click(object sender, EventArgs e)
        {
            ADOUtils.SupprimerSelection(assistantSoinBindingSource, EstSupprimableSoin);
        }
        private Boolean CheckSoinsPlanif(int noAssistant, int noSoin)
        {
            //connection a la BD
            string maChaineConnexion = "Data Source=sqlinfo.cgodin.qc.ca;Initial Catalog=BD5B6TP1_ConstantinBrassardLahey;User ID=5B6Constantin;Password=Password1";
            SqlConnection maConnexion = new SqlConnection(maChaineConnexion);
            maConnexion.Open();

            //requete SQL
            string maRequeteSQL = "";
            SqlCommand maCommande;
            if (noSoin == -1)
            {
                maRequeteSQL = "SELECT * FROM PlanifSoin WHERE NoAssistant = @NoAssistant";

                SqlParameter paramNoAssistant = new SqlParameter("@NoAssistant", noAssistant);


                maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                maCommande.Parameters.Add(paramNoAssistant);
            }
            else
            {
                maRequeteSQL = "SELECT * FROM PlanifSoin WHERE NoAssistant = @NoAssistant AND NoSoin = @NoSoin";

                SqlParameter paramNoAssistant = new SqlParameter("@NoAssistant", noAssistant);
                SqlParameter paramNoSoin = new SqlParameter("@NoSoin", noSoin);


                maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                maCommande.Parameters.Add(paramNoAssistant);
                maCommande.Parameters.Add(paramNoSoin);
            }

            SqlDataReader monReader = maCommande.ExecuteReader();
            if (monReader.HasRows)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer un soin si ce soin est présent dans une planif!", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maConnexion.Close();
                return false;
            }
            maConnexion.Close();
            return true;
        }
        private bool EstSupprimableSoin(DataRowView selection)
        {
            var noSoin = Convert.ToInt32(assistantSoinDataGridView.CurrentRow.Cells[1].Value);
            var noAssistant = Convert.ToInt32(assistantSoinDataGridView.CurrentRow.Cells[0].Value);

            
            return CheckSoinsPlanif( noAssistant,  noSoin);
        }
        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {
            var nouveauSoinsAssistant = bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin.NewAssistantSoinRow();

            nouveauSoinsAssistant.NoAssistant = Convert.ToInt32(assistantDataGridView.CurrentRow.Cells[0].Value);
            nouveauSoinsAssistant.NoSoin = (int)listSoin.SelectedValue;

            try
            {
                if (!(bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin.FindByNoAssistantNoSoin(nouveauSoinsAssistant.NoAssistant, nouveauSoinsAssistant.NoSoin).IsNull(1)))
                {
                    MessageBox.Show("Ce soin est déjà assigné à cet assistant", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception exep) { };
            bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin.AddAssistantSoinRow(nouveauSoinsAssistant);
            assistantSoinBindingSource.MoveLast();
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {

        }
    }
}

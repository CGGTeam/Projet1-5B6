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
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistanSoinDescription' table. You can move, or remove it, as needed.
            this.assistanSoinDescriptionTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistanSoinDescription);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin' table. You can move, or remove it, as needed.
            this.assistantSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin' table. You can move, or remove it, as needed.
            this.assistantSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Assistant' table. You can move, or remove it, as needed.
            this.assistantTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Assistant);

            foreach (DataGridViewRow row in assistantDataGridView.Rows)
            {
                row.ReadOnly = true;
            }

        }

        private void btnAjouterAssistant_Click(object sender, EventArgs e)
        {
            new FrmAddAssistant().ShowDialog();
            this.assistantTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Assistant);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerAssistant_Click(object sender, EventArgs e)
        {
            if (assistantDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show(string.Format("Vous devez sélectionner au minimum 1 assistant"));
                return;
            }               

            //confirmation du delete
            DialogResult myResult;
            myResult = MessageBox.Show("Voulez-vous vraiment supprimer cet assistant?", "Supprimer confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                // confirm delete
                foreach (DataGridViewRow row in assistantDataGridView.SelectedRows)
                {
                    //get row index and noAssistant
                    int intRowIndex = row.Index;
                    string strNoAssistant = Convert.ToString(row.Cells[0].Value);

                    //connection a la BD
                    String maChaineConnexion = "Data Source=sqlinfo.cgodin.qc.ca;Initial Catalog=BD5B6TP1_ConstantinBrassardLahey;User ID=5B6Constantin;Password=Password1";

                    //supprimer de la BD et datagridview
                    try
                    {
                        using (SqlConnection con = new SqlConnection(maChaineConnexion))
                        {
                            con.Open();
                            using (SqlCommand command = new SqlCommand("DELETE FROM ASSISTANT WHERE NoAssistant = '" + strNoAssistant + "'", con))
                            {
                                command.ExecuteNonQuery();
                                assistantDataGridView.Rows.RemoveAt(row.Index);
                            }
                            con.Close();
                        }
                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show(string.Format("Une erreur est survenue: ", ex.Message));
                    }
                }
            }           
        }

        private void btnModifierAssistant_Click(object sender, EventArgs e)
        {
            if(assistantDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show(string.Format("Vous pouvez uniquement modifier un assistant à la fois"));
                return;
            }
            if (assistantDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show(string.Format("Vous devez sélectionner un assistant pour le modifier"));
                return;
            }
            DataGridViewRow row = assistantDataGridView.SelectedRows[0];
            row.ReadOnly = false;
            row.DefaultCellStyle.BackColor = Color.LightBlue;
        }
    }
}

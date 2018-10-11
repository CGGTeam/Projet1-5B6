using Projet1_5B6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Admin.Fomrs_Rapports
{
    public partial class FrmSoinsAssistants : BaseFormGestion
    {
        public FrmSoinsAssistants(MenuUtilisateur menu) : base(menu)
        {
            InitializeComponent();
        }

        private void FrmSoinsAssistants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsClientsInvites' table. You can move, or remove it, as needed.
            this.noEtNomsClientsInvitesTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsClientsInvites);
            dateTimePicker.Value = DateTime.Now;
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsAssistants' table. You can move, or remove it, as needed.
            this.noEtNomsAssistantsTableAdapter1.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsAssistants);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.RapportSoinsAssistant' table. You can move, or remove it, as needed.
            this.rapportSoinsAssistantTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.RapportSoinsAssistant, dateTimePicker.Value.ToString());
        }

        private void noEtNomsAssistantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.noEtNomsAssistantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);

        }

        private void onDatepickerChange(object sender, EventArgs e)
        {
            this.rapportSoinsAssistantTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.RapportSoinsAssistant, dateTimePicker.Value.ToString());
        }
    }

}
    
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Admin
{
    public partial class FrmAjoutTypeChambre : Form
    {
        private BD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambreRow nouveauTypeChambre;

        public FrmAjoutTypeChambre(BD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambreRow nouveauTypeChambre)
        {
            InitializeComponent();
            this.nouveauTypeChambre = nouveauTypeChambre;
        }

        private void typeChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);

        }

        private void FrmAjoutTypeChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre' table. You can move, or remove it, as needed.
            this.typeChambreTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre);

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            try
            {
                nouveauTypeChambre.Description = tbDescription.Text;
                nouveauTypeChambre.PrixBas = Convert.ToDecimal(tbPrixBas.Text);
                nouveauTypeChambre.PrixHaut = Convert.ToDecimal(tbPrixHaut.Text);
                nouveauTypeChambre.PrixMoyen = Convert.ToDecimal(tbPrixMoyen.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                this.DialogResult = DialogResult.Cancel;
            }
       }
    }
}

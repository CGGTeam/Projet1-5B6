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
    public partial class FrmAjoutChambre : Form
    {
        private readonly BD5B6TP1_ConstantinBrassardLaheyDataSet.ChambreRow nouvelleChambre;

        public FrmAjoutChambre(BD5B6TP1_ConstantinBrassardLaheyDataSet.ChambreRow nouvelleChambre)
        {
            InitializeComponent();
            this.nouvelleChambre = nouvelleChambre;
        }

        private void FrmAjoutChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre' table. You can move, or remove it, as needed.
            this.typeChambreTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre);

            tbNoChambre.Text = nouvelleChambre.NoChambre.ToString();
            cboTypeChambre.SelectedValue = nouvelleChambre.NoTypeChambre;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            nouvelleChambre.Decoration = tbDecoration.Text;
            nouvelleChambre.Emplacement = tbEmplacement.Text;
            nouvelleChambre.NoTypeChambre = (int)cboTypeChambre.SelectedValue;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}

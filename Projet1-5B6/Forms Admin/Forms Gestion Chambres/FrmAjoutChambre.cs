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

        public FrmAjoutChambre(BD5B6TP1_ConstantinBrassardLaheyDataSet.ChambreRow nouvelleChambre, bool modifMode = false)
        {
            InitializeComponent();
            this.nouvelleChambre = nouvelleChambre;

            if (modifMode)
            {
                tbDecoration.Text = nouvelleChambre.Decoration;
                tbEmplacement.Text = nouvelleChambre.Emplacement;
                cboTypeChambre.SelectedValue = nouvelleChambre.NoTypeChambre;

                Text = "Modification d'une chambre";
                lblEntete.Text = "Modifer chambre";
                btnConfirmer.Text = "Confirmer modification";
            }
        }

        private void FrmAjoutChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre' table. You can move, or remove it, as needed.
            this.typeChambreTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre);

            tbNoChambre.Text = nouvelleChambre.NoChambre.ToString();
            cboTypeChambre.SelectedValue = nouvelleChambre.NoTypeChambre;

            tbDecoration.Validating += Validation.ValiderNonVide(errorProvider);
            tbEmplacement.Validating += Validation.ValiderNonVide(errorProvider);
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

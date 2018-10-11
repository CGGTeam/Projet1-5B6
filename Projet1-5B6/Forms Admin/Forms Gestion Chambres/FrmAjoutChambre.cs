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
        private readonly BD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambreDataTable dataTable;
        private Control[] controlesAValider;

        public FrmAjoutChambre(BD5B6TP1_ConstantinBrassardLaheyDataSet.ChambreRow nouvelleChambre, BD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambreDataTable dataTable, bool modifMode = false)
        {
            InitializeComponent();
            this.nouvelleChambre = nouvelleChambre;

            this.dataTable = dataTable;

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
            foreach (DataRow row in dataTable.Rows)
            {
                bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre.ImportRow(row);
            }

            tbNoChambre.Text = nouvelleChambre.NoChambre.ToString();
            cboTypeChambre.SelectedValue = nouvelleChambre.NoTypeChambre;

            tbDecoration.Validating += DecorationNonVide;
            tbEmplacement.Validating += EmplacementNonVide;

            controlesAValider = new Control[]
            {
                tbDecoration,
                tbEmplacement,
                cboTypeChambre
            };
        }

        private void EmplacementNonVide(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(tbEmplacement, "");

            if (tbEmplacement.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(tbEmplacement, "Ce champs doit être rempli");
            }
        }

        private void Valider(object sender, EventArgs e)
        {
            btnConfirmer.Enabled = controlesAValider.All(ctrl => ctrl.Text.Trim() != "");
        }

        private void DecorationNonVide(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(tbDecoration, "");

            if (tbDecoration.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(tbDecoration, "Ce champs doit être rempli");
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            Validate();

            nouvelleChambre.Decoration = tbDecoration.Text;
            nouvelleChambre.Emplacement = tbEmplacement.Text;
            nouvelleChambre.NoTypeChambre = (int)cboTypeChambre.SelectedValue;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}

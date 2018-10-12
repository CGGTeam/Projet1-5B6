using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Admin
{
    public partial class FrmAjoutTypeChambre : Form
    {
        private readonly BD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambreRow nouveauTypeChambre;
        private Control[] controlesAValider;

        public FrmAjoutTypeChambre(BD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambreRow nouveauTypeChambre, bool modifMode = false)
        {
            InitializeComponent();

            controlesAValider = new Control[]
            {
                tbDescription,
                tbNoType,
                tbPrixBas,
                tbPrixHaut,
                tbPrixMoyen,
            };

            this.nouveauTypeChambre = nouveauTypeChambre;

            tbNoType.Text = nouveauTypeChambre.NoTypeChambre.ToString();

            if (modifMode)
            {
                tbDescription.Text = nouveauTypeChambre.Description;
                tbPrixBas.Text = nouveauTypeChambre.PrixBas.ToString();
                tbPrixHaut.Text = nouveauTypeChambre.PrixHaut.ToString();
                tbPrixMoyen.Text = nouveauTypeChambre.PrixMoyen.ToString();

                Text = "Modification d'un type de chambre";
                lblEntete.Text = "Modifer type chambre";
                btnConfirmer.Text = "Confirmer les modifications";
            }
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

        private void FrmAjoutTypeChambre_Load(object sender, EventArgs e)
        {
            tbPrixHaut.Validating += Validation.ValiderPrix(errorProvider);
            tbPrixBas.Validating += Validation.ValiderPrix(errorProvider);
            tbPrixMoyen.Validating += Validation.ValiderPrix(errorProvider);
            tbDescription.Validating += Validation.ValiderDescriptionTypeChambre(errorProvider);
        }

        private void Valider(object sender, EventArgs e)
        {
            btnConfirmer.Enabled = controlesAValider.All(ctrl => ctrl.Text.Trim() != "");
        }

        private void ValiderPrix(object sender, CancelEventArgs e)
        {
            TextBox tbValide = (TextBox)sender;
            errorProvider.SetError(tbValide, "");

            try
            {
                double prix = Convert.ToDouble(tbValide.Text);

                if (prix < 0)
                {
                    errorProvider.SetError(tbValide, "Prix doit être positif");
                    e.Cancel = true;
                }
                else
                {
                    if (!ValiderPrixRelatifs(tbValide))
                    {
                        e.Cancel = true;
                        errorProvider.SetError(tbValide, "Prix invalides: le prix bas doit être inférieur ou égal au prix moyen" +
                                                         " et le prix moyen inférieur ou égal au prix haut");
                    }
                }
            }
            catch (Exception)
            {
                errorProvider.SetError(tbValide, "doit être un contrôle valide");
                e.Cancel = true;
            }
        }

        private bool ValiderPrixRelatifs(TextBox sender)
        {
            try
            {
                double prixBas = tbPrixBas.Text.Trim() == "" ? double.MinValue : Convert.ToDouble(tbPrixBas.Text);
                double prixHaut = tbPrixHaut.Text.Trim() == "" ? double.MaxValue : Convert.ToDouble(tbPrixHaut.Text);
                double prixMilieu = tbPrixMoyen.Text.Trim() == ""
                    ? (prixBas + prixHaut) / 2
                    : Convert.ToDouble(tbPrixMoyen.Text);

                return prixBas <= prixMilieu && prixMilieu <= prixHaut;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

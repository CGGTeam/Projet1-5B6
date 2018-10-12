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

namespace Projet1_5B6.Forms_Commun.Forms_Gestion_Utilisateur
{
    public partial class FrmGestionUtilisateurs : BaseFormGestion
    {
        public FrmGestionUtilisateurs(MenuUtilisateur menu) : base(menu)
        {
            InitializeComponent();
        }

        private void FrmGestionUtilisateurs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeUtilisateur' table. You can move, or remove it, as needed.
            this.typeUtilisateurTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeUtilisateur);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Utilisateur' table. You can move, or remove it, as needed.
            this.utilisateurTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Utilisateur);

            foreach(DataGridViewRow row in utilisateurDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value).Equals(GestionForms.utilisateurConnecte.NoUtilisateur))
                {
                    row.ReadOnly = true;
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }

            utilisateurTableAdapter.Adapter.RowUpdated += GestionConflits.GenererGestionConflit("NoUtilisateur", "l'utilisateur");
        }
        private int TrouverNoUtilisateur()
        {
            int plusGrandId = 0;

            foreach (DataRow rangee in bD5B6TP1_ConstantinBrassardLaheyDataSet.Utilisateur.Rows)
            {
                int id = Convert.ToInt32(rangee["NoUtilisateur"]);
                if (id > plusGrandId)
                    plusGrandId = id;
            }

            return plusGrandId + 1;
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Validate();
            utilisateurBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
            BaseFormGestion.estSavegarder = true;
            utilisateurTableAdapter.Fill(bD5B6TP1_ConstantinBrassardLaheyDataSet.Utilisateur);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(ADOUtils.SupprimerSelection(utilisateurBindingSource, EstSupprimable))
                BaseFormGestion.estSavegarder = false;
        }

        private bool EstSupprimable(DataRowView selection)
        {
            if (Convert.ToInt32(selection[0]).Equals(GestionForms.utilisateurConnecte.NoUtilisateur))
            {
                MessageBox.Show("Vous ne pouvez pas supprimer votre propre utilisateur!");
                return false;
            }

            return true;
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            utilisateurBindingSource.ResetBindings(false);
            BaseFormGestion.estSavegarder = true;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var nouveauUtilisateur = bD5B6TP1_ConstantinBrassardLaheyDataSet.Utilisateur.NewUtilisateurRow();
            FrmAjoutUtilisateur frmAjout = new FrmAjoutUtilisateur(nouveauUtilisateur);

            nouveauUtilisateur.NoUtilisateur = TrouverNoUtilisateur();

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.Utilisateur.AddUtilisateurRow(nouveauUtilisateur);
            utilisateurBindingSource.MoveLast();
            BaseFormGestion.estSavegarder = false;
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            utilisateurBindingSource.ResetBindings(false);
            BaseFormGestion.estSavegarder = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int noUtilisateurtSelectionne = (int)((DataRowView)utilisateurBindingSource.Current)["NoUtilisateur"];
            BD5B6TP1_ConstantinBrassardLaheyDataSet.UtilisateurRow rowModifier = bD5B6TP1_ConstantinBrassardLaheyDataSet.Utilisateur.FindByNoUtilisateur(noUtilisateurtSelectionne);
            FrmAjoutUtilisateur frmAjout = new FrmAjoutUtilisateur(rowModifier, true);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;
            else BaseFormGestion.estSavegarder = false;
        }
    }
}

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

        private void utilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);

        }

        private void FrmGestionUtilisateurs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Utilisateur' table. You can move, or remove it, as needed.
            this.utilisateurTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Utilisateur);

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
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            ADOUtils.SupprimerSelection(utilisateurBindingSource, EstSupprimable);
        }

        private bool EstSupprimable(DataRowView selection)
        {
            //TODO: validation n'est pas l'utilisateur courant
            return true;
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            utilisateurBindingSource.ResetBindings(false);
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
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            utilisateurBindingSource.ResetBindings(false);
        }
    }
}

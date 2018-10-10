using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1_5B6.Forms_Commun;
using Projet1_5B6.Models;

namespace Projet1_5B6.Forms_Admin
{
    public partial class FrmGestionChambresEtTypes : BaseFormGestion
    {
        public FrmGestionChambresEtTypes(MenuUtilisateur menu) : base(menu)
        {
            InitializeComponent();
        }

        private void GestionChambresEtTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre' table. You can move, or remove it, as needed.
            this.chambreTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre' table. You can move, or remove it, as needed.
            this.typeChambreTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre);
        }

        private int TrouverNoTypeChambre()
        {
            int plusGrandId = 0;

            foreach (DataRow rangee in bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre.Rows)
            {
                int id = Convert.ToInt32(rangee["NoTypeChambre"]);
                if (id > plusGrandId)
                    plusGrandId = id;
            }

            return plusGrandId + 1;
        }

        private void btnAjouterType_Click(object sender, EventArgs e)
        {
            var nouveauType = bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre.NewTypeChambreRow();

            nouveauType.NoTypeChambre = TrouverNoTypeChambre();

            FrmAjoutTypeChambre frmAjout = new FrmAjoutTypeChambre(nouveauType);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre.AddTypeChambreRow(nouveauType);
            typeChambreBindingSource.MoveLast();
        }

        private void btnAjouterChambre_Click(object sender, EventArgs e)
        {
            var nouvelleChambre = bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre.NewChambreRow();
            DataRowView typeChambreSelectionnee = (DataRowView) typeChambreBindingSource.Current;
            
            nouvelleChambre.NoChambre = TrouverNoChambre();
            nouvelleChambre.NoTypeChambre = (int)typeChambreSelectionnee["NoTypeChambre"];

            FrmAjoutChambre frmAjout = new FrmAjoutChambre(nouvelleChambre);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            int indexTypeNouvelleChambre =
                typeChambreBindingSource.Find("NoTypeChambre", nouvelleChambre.NoTypeChambre);
            typeChambreBindingSource.Position = indexTypeNouvelleChambre;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre.AddChambreRow(nouvelleChambre);
            chambreBindingSource.MoveLast();
        }

        private int TrouverNoChambre()
        {
            int plusGrandID = 0;

            foreach (DataRow rangee in bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre.Rows)
            {
                if ((int)rangee["NoChambre"] > plusGrandID)
                {
                    plusGrandID = (int) rangee["NoChambre"];
                }
            }

            return plusGrandID + 1;
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Validate();
            chambreBindingSource.EndEdit();
            typeChambreBindingSource.EndEdit();

            chambreTableAdapter.Update(bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre);
            typeChambreTableAdapter.Update(bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            chambreBindingSource.ResetBindings(false);
            typeChambreBindingSource.ResetBindings(false);
        }
    }
}

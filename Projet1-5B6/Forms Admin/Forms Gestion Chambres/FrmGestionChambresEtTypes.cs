using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters;
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

            chambreBindingSource.CurrentChanged += VerifierSiChambreEstReservee;
            typeChambreBindingSource.CurrentChanged += VerifierSiTypeADesChambres;

            chambreTableAdapter.Adapter.RowUpdated += GestionConflits.GenererGestionConflit("NoChambre", "chambre");
            typeChambreTableAdapter.Adapter.RowUpdated += GestionConflits.GenererGestionConflit("NoTypeChambre", "type chambre");
        }

        private void VerifierSiTypeADesChambres(object sender, EventArgs e)
        {
            if (typeChambreBindingSource.Current == null)
            {
                btnSupprimerChambre.Enabled = false;
                return;
            }

            int noTypeSelec = (int) ((DataRowView) typeChambreBindingSource.Current)["NoTypeChambre"];
                
            if (bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre.Any(chambre => chambre.NoTypeChambre == noTypeSelec))
            {
                btnSupprimerType.Enabled = false;
                ttpChambre.Show("Ce type de chambre ne peut pas être supprimé car:\n\t- Il existe des chambres de ce type", btnSupprimerChambre, 3000);
            }
            else
            {
                btnSupprimerType.Enabled = true;
            }
        }

        private void VerifierSiChambreEstReservee(object sender, EventArgs e)
        {
            if (chambreBindingSource.Current == null)
            {
                btnSupprimerChambre.Enabled = false;
                return;
            }

            ReservationChambreTableAdapter reservationChambreTableAdapter = new ReservationChambreTableAdapter();
            reservationChambreTableAdapter.Fill(bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre);

            int idChambreSelection = (int) ((DataRowView)chambreBindingSource.Current)["NoChambre"];

            if (bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre.Any(reservation =>
                reservation.NoChambre == idChambreSelection))
            {
                btnSupprimerChambre.Enabled = false;
                ttpChambre.Show("Cette chambre ne peut pas être supprimée car:\n\t- Elle est réservée par un client", btnSupprimerChambre, 3000);
            }
            else
            {
                btnSupprimerChambre.Enabled = true;
            }
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
            BaseFormGestion.estSavegarder = false;
        }

        private void btnAjouterChambre_Click(object sender, EventArgs e)
        {
            var nouvelleChambre = bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre.NewChambreRow();
            DataRowView typeChambreSelectionnee = (DataRowView) typeChambreBindingSource.Current;
            
            nouvelleChambre.NoChambre = TrouverNoChambre();
            nouvelleChambre.NoTypeChambre = (int)typeChambreSelectionnee["NoTypeChambre"];

            FrmAjoutChambre frmAjout = new FrmAjoutChambre(nouvelleChambre, bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            int indexTypeNouvelleChambre =
                typeChambreBindingSource.Find("NoTypeChambre", nouvelleChambre.NoTypeChambre);
            typeChambreBindingSource.Position = indexTypeNouvelleChambre;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre.AddChambreRow(nouvelleChambre);
            chambreBindingSource.MoveLast();
            BaseFormGestion.estSavegarder = false;
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
            BaseFormGestion.estSavegarder = true;

            chambreTableAdapter.Fill(bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre);
            typeChambreTableAdapter.Fill(bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            chambreBindingSource.ResetBindings(false);
            typeChambreBindingSource.ResetBindings(false);
            BaseFormGestion.estSavegarder = true;
        }

        private void btnSupprimerChambre_Click(object sender, EventArgs e)
        {
            if(ADOUtils.SupprimerSelection(chambreBindingSource, ChambreEstSupprimable))
                BaseFormGestion.estSavegarder = false;
        }

        private bool ChambreEstSupprimable(DataRowView obj)
        {
            return true;
        }

        private void btnSupprimerType_Click(object sender, EventArgs e)
        {
            if(ADOUtils.SupprimerSelection(typeChambreBindingSource, type => true))
                BaseFormGestion.estSavegarder = true;
        }

        private void btnModifierType_Click(object sender, EventArgs e)
        {
            int noTypeSelec = (int)((DataRowView)typeChambreBindingSource.Current)["NoTypeChambre"];
            BD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambreRow rowSelec =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre.FindByNoTypeChambre(noTypeSelec);

            FrmAjoutTypeChambre frmAjout = new FrmAjoutTypeChambre(rowSelec, true);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) rowSelec.CancelEdit();
            else BaseFormGestion.estSavegarder = true;
        }

        private void btnModifierChambre_Click(object sender, EventArgs e)
        {
            int noChambreSelec = (int)((DataRowView)chambreBindingSource.Current)["NoChambre"];
            BD5B6TP1_ConstantinBrassardLaheyDataSet.ChambreRow rowSelec =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre.FindByNoChambre(noChambreSelec);

            FrmAjoutChambre frmAjout = new FrmAjoutChambre(rowSelec, bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre, true);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) rowSelec.CancelEdit();
            else BaseFormGestion.estSavegarder = true;
        }
    }
}

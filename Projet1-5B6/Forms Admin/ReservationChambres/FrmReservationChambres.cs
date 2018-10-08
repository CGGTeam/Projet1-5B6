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

namespace Projet1_5B6.Forms_Admin.ReservationChambres
{
    public partial class FrmReservationChambres : BaseFormGestion
    {
       
        public FrmReservationChambres(MenuUtilisateur menu) : base(menu)
        {
            InitializeComponent();
        }

        private void FrmReservationChambres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.ChambreEtPrix' table. You can move, or remove it, as needed.
            this.chambreEtPrixTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.ChambreEtPrix);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomClients' table. You can move, or remove it, as needed.
            this.noEtNomClientsTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomClients);

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            try
            {
                var nouvelleReservation = bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre.NewReservationChambreRow();
                nouvelleReservation.NoClient = (int)listeClients.SelectedValue;
                foreach (DataRow rangee in bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre.Rows)
                {
                    nouvelleReservation.NoChambre = Convert.ToInt32(rangee["NoChambre"]);
                }
                nouvelleReservation.DateArrivee = dateDebut.Value;
                nouvelleReservation.DateDepart = dateFin.Value;
                nouvelleReservation.NbPersonnes = (int)numericNbPersonne.Value;

                tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            new FrmSupprimerReservation().Show();
        }
    }
}

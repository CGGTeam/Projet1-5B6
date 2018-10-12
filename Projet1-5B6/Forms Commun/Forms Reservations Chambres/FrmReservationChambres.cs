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
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre' table. You can move, or remove it, as needed.
            this.reservationChambreTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.ChambreEtPrix' table. You can move, or remove it, as needed.
            this.chambreEtPrixTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.ChambreEtPrix);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomClients' table. You can move, or remove it, as needed.
            this.noEtNomClientsTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomClients);

            reservationChambreTableAdapter.Adapter.RowUpdated += GestionConflits.GenererGestionConflit("No Reservation", "la reservation du client");
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            try
            {
                var nouvelleReservation = bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre.NewReservationChambreRow();
                nouvelleReservation.NoClient = (int)listeClients.SelectedValue;
                nouvelleReservation.NoChambre = Convert.ToInt32(chambreEtPrixDataGridView.CurrentRow.Cells[0].Value);
                nouvelleReservation.DateArrivee = dateDebut.Value;
                nouvelleReservation.DateDepart = dateFin.Value;
                nouvelleReservation.NbPersonnes = (int)numericNbPersonne.Value;

                if (CheckDate(nouvelleReservation.DateArrivee))
                {
                    lblFeed.Text = "La date d'arrivée doit être supérieur à la date courante!";
                    return;
                }
                if (!CheckIfRoomAvailable(nouvelleReservation.NoChambre, nouvelleReservation.DateArrivee, nouvelleReservation.DateDepart))
                {
                    lblFeed.Text = "La chambre n'est pas disponible durant les dates spécifiées";
                    return;
                }
                    
                bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre.AddReservationChambreRow(nouvelleReservation);
                Validate();
                reservationChambreBindingSource.EndEdit();
                reservationChambreTableAdapter.Update(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
                reservationChambreTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre);
                lblFeed.Text = "La réservation a été éffectuée avec succès!";
            }
            catch (Exception) { lblFeed.Text = "Une erreure est survenue lors de la réservation!"; }

        }
        private Boolean CheckIfRoomAvailable(int noChambre, DateTime dateDebut, DateTime dateFin)
        {
            Boolean estDisponible = true;

            BD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambreDataTable reservationChambreTable = bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre;
            if (reservationChambreTable.Any(reservationChambre => reservationChambre.NoChambre == noChambre
                && ((DateTime.Compare(dateDebut, reservationChambre.DateArrivee) > 0 && DateTime.Compare(dateDebut, reservationChambre.DateDepart) < 0)
                || ((DateTime.Compare(dateFin, reservationChambre.DateArrivee) < 0 && DateTime.Compare(dateFin, reservationChambre.DateDepart) > 0)))))
            {
                estDisponible = false;
            }
            return estDisponible;
        }
        private Boolean CheckDate(DateTime date)
        {
            return (DateTime.Compare(date, DateTime.Now) < 0) ;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            new FrmSupprimerReservation().Show();
        }

        private void UpdateDatePicker(object sender, EventArgs e)
        {
            dateFin.MinDate = dateDebut.Value;
        }
    }
}

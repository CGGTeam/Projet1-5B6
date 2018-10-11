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
    public partial class FrmSupprimerReservation : Form
    {
        public FrmSupprimerReservation()
        {
            InitializeComponent();
        }

        private void reservationChambreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationChambreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);

        }

        private void FrmSupprimerReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre' table. You can move, or remove it, as needed.
            this.reservationChambreTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre);

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            ADOUtils.SupprimerSelection(reservationChambreBindingSource, EstSupprimable);
        }

        private bool EstSupprimable(DataRowView selection)
        {
            Boolean EstSupprimable = true;
            if (selection == null)
            {
                lblFeed.Text = "Aucune réservation sélectionnée!";
                EstSupprimable= false;
            }
            if (DateTime.Compare((DateTime)selection["DateArrivee"], DateTime.Now) < 0)
            {
                lblFeed.Text = "Impossible de supprimer une réservation antérieure ou courante!";
                EstSupprimable= false;
            }
            return EstSupprimable;
        }
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            Validate();
            reservationChambreBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
            Close();
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            reservationChambreBindingSource.ResetBindings(false);
            Close();
        }
    }
}


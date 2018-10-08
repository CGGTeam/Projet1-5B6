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
            if((DateTime)selection["DateArrivee"] >= DateTime.Now && selection == null)
                return false;
            return true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            reservationChambreBindingSource.ResetBindings(false);
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            Validate();
            reservationChambreBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
            Close();
        }
    }
}


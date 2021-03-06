﻿using System;
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
    public partial class FrmReservationChambres : Form
    {
        private readonly BD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambreRow nouvelleReservationChambre;

        public FrmReservationChambres(BD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambreRow nouvelleReservationChambre)
        {
            InitializeComponent();
            this.nouvelleReservationChambre = nouvelleReservationChambre;
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
                nouvelleReservationChambre.NoClient = (int)listeClients.SelectedValue;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Admin
{
    public partial class FrmAjoutTypeChambre : Form
    {
        private readonly BD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambreRow nouveauTypeChambre;

        public FrmAjoutTypeChambre(BD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambreRow nouveauTypeChambre)
        {
            InitializeComponent();
            this.nouveauTypeChambre = nouveauTypeChambre;

            tbNoType.Text = nouveauTypeChambre.NoTypeChambre.ToString();
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
    }
}
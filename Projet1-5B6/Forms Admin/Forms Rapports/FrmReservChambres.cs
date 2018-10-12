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

namespace Projet1_5B6.Forms_Admin.Fomrs_Rapports
{
    public partial class FrmReservChambres : BaseFormGestion
    {
        public FrmReservChambres(MenuUtilisateur menu) : base(menu)
        {
            InitializeComponent();
        }

        private void FrmReservChambres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre' table. You can move, or remove it, as needed.
            this.rapportChambreTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.RapportChambre);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Chambre' table. You can move, or remove it, as needed.
            this.noEtEmplacementChambreTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtEmplacementChambre);

            rapportChambreDataGridView.RowHeadersVisible = false;
        }
    }
}

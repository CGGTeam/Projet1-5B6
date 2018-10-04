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

namespace Projet1_5B6.Forms_Admin
{
    public partial class FrmGestionChambresEtTypes : BaseAdmin
    {
        public FrmGestionChambresEtTypes()
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
            frmAjout.ShowDialog();

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeChambre.AddTypeChambreRow(nouveauType);
            typeChambreBindingSource.MoveLast();
        }
    }
}

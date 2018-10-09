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
    public partial class FrmSoinsClients : BaseFormGestion
    {
        public FrmSoinsClients(MenuUtilisateur menu) : base(menu)
        {
            InitializeComponent();
        }

        private void FrmSoinsClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.SoinsPersonnes' table. You can move, or remove it, as needed.
            this.soinsPersonnesTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.SoinsPersonnes);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsClientsInvites' table. You can move, or remove it, as needed.
            this.noEtNomsClientsInvitesTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.NoEtNomsClientsInvites);

        }
    }
}

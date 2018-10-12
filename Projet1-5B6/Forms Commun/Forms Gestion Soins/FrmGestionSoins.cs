using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters;
using Projet1_5B6.Forms_Commun.Forms_Gestion_Soins;
using Projet1_5B6.Models;

namespace Projet1_5B6.Forms_Commun
{
    public partial class FrmGestionSoins : BaseFormGestion
    {
        public FrmGestionSoins(MenuUtilisateur menu) : base(menu)
        {
            InitializeComponent();
        }

        private void FrmGestionSoins_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeSoin' table. You can move, or remove it, as needed.
            this.typeSoinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeSoin);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin' table. You can move, or remove it, as needed.
            this.soinTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin);

            soinBindingSource.CurrentChanged += VerifierSiSupprimable;

            soinTableAdapter.Adapter.RowUpdated += GestionConflits.GenererGestionConflit("NoSoin", "le soin");
        }

        private void VerifierSiSupprimable(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = EstSupprimable((DataRowView)soinBindingSource.Current);
        }

        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {
            var nouveauSoin = bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin.NewSoinRow();
            FrmAjoutSoin frmAjout = new FrmAjoutSoin(nouveauSoin);

            nouveauSoin.NoSoin = TrouverNoSoin();
            nouveauSoin.Duree = new TimeSpan(0, 1, 0, 0);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin.AddSoinRow(nouveauSoin);
            soinBindingSource.MoveLast();
            BaseFormGestion.estSavegarder = false;
        }

        private int TrouverNoSoin()
        {
            int plusGrandId = 0;

            foreach (DataRow rangee in bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin.Rows)
            {
                int id = Convert.ToInt32(rangee["NoSoin"]);
                if (id > plusGrandId)
                    plusGrandId = id;
            }

            return plusGrandId + 1;
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Validate();
            soinBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
            BaseFormGestion.estSavegarder = true;
            soinTableAdapter.Fill(bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(ADOUtils.SupprimerSelection(soinBindingSource, EstSupprimable))
                BaseFormGestion.estSavegarder = false;
        }

        private bool EstSupprimable(DataRowView selection)
        {
            if (soinBindingSource.Current == null) return false;

            BD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoinDataTable assistantSoinTable =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin;
            int idSoinSelectionne = (int)((DataRowView)soinBindingSource.Current)["NoSoin"];

            AssistantSoinTableAdapter assistantSoinTableAdapter = new AssistantSoinTableAdapter();
            assistantSoinTableAdapter.Fill(bD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantSoin);

            bool peutEtreSupprime = true;
            string texteTooltip = "Le soin sélectionné ne peut pas être supprimé car:";
            ttpSupprimer.SetToolTip(btnSupprimer, "");

            if (assistantSoinTable.Any(assistantSoin => assistantSoin.NoSoin == idSoinSelectionne))
            {
                texteTooltip += "\n\t- Il est assigné à un assistant";
                peutEtreSupprime =  false;
            }

            BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinDataTable planifSoinTable =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin;

            PlanifSoinTableAdapter planifSoinTableAdapter = new PlanifSoinTableAdapter();
            planifSoinTableAdapter.Fill(bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin);

            if (planifSoinTable.Any(planifSoin => planifSoin.NoSoin == idSoinSelectionne))
            {
                texteTooltip += "\n\t- Un soin de ce type est planifié";
                peutEtreSupprime = false;
            }

            if (!peutEtreSupprime)
            {
                ttpSupprimer.Show(texteTooltip, btnSupprimer, 3000);
            }

            return peutEtreSupprime;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            soinBindingSource.ResetBindings(false);
            BaseFormGestion.estSavegarder = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int noSoinSelec = (int)((DataRowView)soinBindingSource.Current)["NoSoin"];

            BD5B6TP1_ConstantinBrassardLaheyDataSet.SoinRow rowSelec =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.Soin.FindByNoSoin(noSoinSelec);

            FrmAjoutSoin frmAjout = new FrmAjoutSoin(rowSelec, true);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) rowSelec.CancelEdit();
            else BaseFormGestion.estSavegarder = false; 
        }
    }
}
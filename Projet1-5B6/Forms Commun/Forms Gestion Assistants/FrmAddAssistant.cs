using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Admin.Forms_Gestion_Assistants
{
    public partial class FrmAddAssistant : Form
    {
        BD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantRow user;
        DataRowView selection;
        Boolean pourModifier = false;
        private readonly Control[] controlesAValider;
        
        public FrmAddAssistant(BD5B6TP1_ConstantinBrassardLaheyDataSet.AssistantRow user)
        {
            InitializeComponent();
            this.user = user;

            controlesAValider = new Control[]
            {
                tbNom,
                tbPrenom,
                tbSpecialite,
            };
        }

        public FrmAddAssistant(BindingSource bindingSource)
        {

            pourModifier = true;

            InitializeComponent();

            this.Text = "Modifier un assistant";
            lblTitre.Text = "Modifier un assistant";
            btnConfirmer.Text = "Confirmer la modification";

            DataRowView selection = (DataRowView)bindingSource.Current;
            this.selection = selection;

            controlesAValider = new Control[]
           {
                tbNom,
                tbPrenom,
                tbSpecialite,
           };
        }

        private void FrmAddAssistant_Load(object sender, EventArgs e)
        {
            if (pourModifier)
            {
                tbNoAssistant.Text = selection[0].ToString();
                tbPrenom.Text = (string)selection[1];
                tbNom.Text = (string)selection[2];
                tbSpecialite.Text = (string)selection[3];
                tbRemarques.Text = (string)selection[4];
            }
            else
            {
                tbNoAssistant.Text = user.NoAssistant.ToString();
            }
        }
        private void ValiderFormulaire(object sender, KeyEventArgs e)
        {
            bool formulaireComplet = controlesAValider.All(ControleNonVide);

            btnConfirmer.Enabled = formulaireComplet;
        }
        private bool ControleNonVide(Control ctrl)
        {
            return ctrl.Text.Trim() != "";
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (pourModifier)
            {
                selection[2] = tbNom.Text;
                selection[1] = tbPrenom.Text;
                selection[3] = tbSpecialite.Text;
                selection[4] = tbRemarques.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                user.Nom = tbNom.Text;
                user.Prenom = tbPrenom.Text;
                user.Specialites = tbSpecialite.Text;
                user.Remarques = tbRemarques.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

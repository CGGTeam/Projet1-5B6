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

namespace Projet1_5B6.Forms_Commun.Forms_Gestion_Utilisateur
{
    public partial class FrmAjoutUtilisateur : Form
    {
        BD5B6TP1_ConstantinBrassardLaheyDataSet.UtilisateurRow user;
        private readonly Control[] controlesAValider;
        bool pourModifier = false;
        public FrmAjoutUtilisateur(BD5B6TP1_ConstantinBrassardLaheyDataSet.UtilisateurRow user, bool pourModifier = false)
        {
            InitializeComponent();
            this.user = user;
            this.pourModifier = pourModifier;
            controlesAValider = new Control[]
            {
                tbNom,
               tbMotDePasse,
            };
        }
        private void FrmAjoutUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeUtilisateur' table. You can move, or remove it, as needed.
            this.typeUtilisateurTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.TypeUtilisateur);

            if (pourModifier)
            {
                this.Text = "Modification d'un utilisateur";
                label1.Text = "Modification d'un utilisateur";
                btnConfirmer.Text = "Confirmer la modification";

                tbNo.Text = user.NoUtilisateur.ToString();
                tbNom.Text = (string)user.Nom;
                tbMotDePasse.Text = (string)user.MotDePasse;
                listTypeUtilisateur.SelectedValue = (int)user.NoTypeUtilisateur;

                btnConfirmer.Enabled = true;
            }
            else
            {
                tbNo.Text = user.NoUtilisateur.ToString();
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
            string maChaineConnexion = "Data Source=sqlinfo.cgodin.qc.ca;Initial Catalog=BD5B6TP1_ConstantinBrassardLahey;User ID=5B6Constantin;Password=Password1";
            SqlConnection maConnexion = new SqlConnection(maChaineConnexion);
            maConnexion.Open();

            //requete SQL
            string maRequeteSQL = "SELECT * FROM Utilisateur WHERE Nom = @NomUtilisateur";
            SqlParameter paramNom = new SqlParameter("@NomUtilisateur", tbNom.Text);

            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            maCommande.Parameters.Add(paramNom);

            SqlDataReader monReader = maCommande.ExecuteReader();
            if (monReader.HasRows)
            {
                MessageBox.Show("Vous devez utiliser un nom unique!");
                return;
            }
            maConnexion.Close();

            user.Nom = tbNom.Text;
            user.MotDePasse = tbMotDePasse.Text;
            user.NoTypeUtilisateur = (int)listTypeUtilisateur.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
            
        }
    }
}

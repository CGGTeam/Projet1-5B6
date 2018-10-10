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
        private BindingSource utilisateurBindingSource;

        public FrmAjoutUtilisateur(BD5B6TP1_ConstantinBrassardLaheyDataSet.UtilisateurRow user, BindingSource utilisateurBindingSource)
        {
            InitializeComponent();
            this.user = user;
            this.utilisateurBindingSource = utilisateurBindingSource;

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
            tbNo.Text = user.NoUtilisateur.ToString();

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
            user.Nom = tbNom.Text;

            //connection a la BD
            string maChaineConnexion = "Data Source=sqlinfo.cgodin.qc.ca;Initial Catalog=BD5B6TP1_ConstantinBrassardLahey;User ID=5B6Constantin;Password=Password1";
            SqlConnection maConnexion = new SqlConnection(maChaineConnexion);
            maConnexion.Open();

            //requete SQL
            string maRequeteSQL = "SELECT * FROM Utilisateur WHERE Nom = @NomUtilisateur";
            SqlParameter paramNom = new SqlParameter("@NomUtilisateur", user.Nom);

            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            maCommande.Parameters.Add(paramNom);

            SqlDataReader monReader = maCommande.ExecuteReader();
            if (monReader.HasRows)
            {
                MessageBox.Show("Vous devez utiliser un nom unique!");
                return;
            }
            maConnexion.Close();
                
            user.MotDePasse = tbMotDePasse.Text;
            user.NoTypeUtilisateur = (int)listTypeUtilisateur.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
            
        }
    }
}

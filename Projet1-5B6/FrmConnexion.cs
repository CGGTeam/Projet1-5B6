using Projet1_5B6.Forms_Admin;
using Projet1_5B6.Forms_Prepose;
using System;
using System.Data.SqlClient;
using System.Dynamic;
using System.Windows.Forms;
using Projet1_5B6.Models;

namespace Projet1_5B6
{
    public partial class FrmConnexion : Form
    {
        SqlConnection maConnexion = null;
        private Utilisateur utilisateur = null;

        public FrmConnexion()
        {
            InitializeComponent();

            //connection a la BD
            string maChaineConnexion = "Data Source=sqlinfo.cgodin.qc.ca;Initial Catalog=BD5B6TP1_ConstantinBrassardLahey;User ID=5B6Constantin;Password=Password1";
            maConnexion = new SqlConnection(maChaineConnexion);
            maConnexion.Open();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (!EstUtilisateurValide()) return;

            Hide();
            Connexion?.Invoke(this, utilisateur);
            if (WillShow)
            {
                WillShow = false;
                Show();
            }
            else
            {
                Close();
            }
        }

        private bool EstUtilisateurValide()
        {
            string strNomUilisateur = tbNomUtilisateur.Text;
            string strMotDePasse = tbMotDePasse.Text;

            //requete SQL
            string maRequeteSQL = "SELECT * FROM Utilisateur WHERE Nom = @NomUtilisateur and MotDePasse = @MotDePasse";
            SqlParameter paramNom = new SqlParameter("@NomUtilisateur", strNomUilisateur);
            SqlParameter paramMDP = new SqlParameter("@MotDePasse", strMotDePasse);

            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            maCommande.Parameters.Add(paramNom);
            maCommande.Parameters.Add(paramMDP);

            SqlDataReader monReader = maCommande.ExecuteReader();
            if (!monReader.HasRows)
            {
                monReader.Close();
                lblErrorProvider.Text = "Nom d'utilisateur ou mot de passe incorrect";
                return false;
            }
            else
            {
                monReader.Read();

                utilisateur = new Utilisateur((int)monReader[0], (string)monReader[1], (int)monReader[3]);

                monReader.Close();
                return true;
            }
        }

        public event EventHandler<Utilisateur> Connexion;

        public void Deconnexion()
        {
            this.WillShow = true;
        }

        public bool WillShow { get; set; }
    }
}

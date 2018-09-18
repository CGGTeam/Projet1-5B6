using Projet1_5B6.Forms_Admin;
using Projet1_5B6.Forms_Client;
using System;
using System.Data.SqlClient;
using System.Dynamic;
using System.Windows.Forms;

namespace Projet1_5B6
{
    public partial class FrmConnexion : Form
    {
        SqlConnection maConnexion = null;
        private dynamic utilisateur = null;

        public FrmConnexion()
        {
            InitializeComponent();

            //connection a la BD
            String maChaineConnexion = "Data Source=sqlinfo.cgodin.qc.ca;Initial Catalog=BD5B6TP1_ConstantinBrassardLahey;User ID=5B6Constantin;Password=Password1";
            maConnexion = new SqlConnection(maChaineConnexion);
            maConnexion.Open();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (!EstUtilisateurValide()) return;

            if (EstAdmin())
            {
                Hide();
                new FrmAccueilAdmin().Show();
            }
            else
            {
                Hide();
                new FrmAccueilClient().Show();
            }
        }

        private bool EstAdmin()
        {  
            return utilisateur.noTypeUtilisateur == 0 ? true : false;
        }

        private bool EstUtilisateurValide()
        {
            String strNomUilisateur = tbNomUtilisateur.Text;
            String strMotDePasse = tbMotDePasse.Text;

            //requete SQL
            String maRequeteSQL = "SELECT * FROM Utilisateur WHERE Nom = @NomUtilisateur and MotDePasse = @MotDePasse";
            SqlParameter paramNom = new SqlParameter("@NomUtilisateur", strNomUilisateur);
            SqlParameter paramMDP = new SqlParameter("@MotDePasse", strMotDePasse);

            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            maCommande.Parameters.Add(paramNom);
            maCommande.Parameters.Add(paramMDP);

            SqlDataReader monReader = maCommande.ExecuteReader();
            if (monReader.HasRows == false)
            {
                monReader.Close();
                lblErrorProvider.Text = "Nom d'utilisateur ou mot de passe incorrect";
                return false;
            }
            else
            {
                utilisateur = new ExpandoObject();
                monReader.Read();

                //remplir l'objet utilisateur
                utilisateur.noUtilisateur = monReader[0];
                utilisateur.nom = monReader[1];
                utilisateur.noTypeUtilisateur = monReader[3];
                
                monReader.Close();
                return true;
            }
        }
    }
}

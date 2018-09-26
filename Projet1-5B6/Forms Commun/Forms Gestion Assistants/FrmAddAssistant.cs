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
        SqlConnection maConnexion = null;
        public FrmAddAssistant()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            //connection a la BD
            String maChaineConnexion = "Data Source=sqlinfo.cgodin.qc.ca;Initial Catalog=BD5B6TP1_ConstantinBrassardLahey;User ID=5B6Constantin;Password=Password1";
            maConnexion = new SqlConnection(maChaineConnexion);
            maConnexion.Open();

            String strNom = tbNom.Text;
            String strPrenom = tbPrenom.Text;
            String strSpecialite = tbSpecialite.Text;
            String strRemarques = tbRemarques.Text;

            //validations
            if (strPrenom == "")
            {
                lblErrorProvider.Text = "Veuillez entrer un prénom";
                lblErrorProvider.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (strNom == "")
            {
                lblErrorProvider.Text = "Veuillez entrer un nom";
                lblErrorProvider.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (strSpecialite == "")
            {
                lblErrorProvider.Text = "Veuillez entrer une specialité";
                lblErrorProvider.ForeColor = System.Drawing.Color.Red;
                return;
            }


            //Get the next availbale id
            String maRequeteSQL = " SELECT MAX(NoAssistant) FROM Assistant";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);

            // Toujours convertir car ExecuteScalar retourne un objet sans type
            String strNo = maCommande.ExecuteScalar().ToString();
            int no = strNo=="" ? 0 : Convert.ToInt32(strNo) + 1;

            String strNoAssistant = no.ToString();


            //querry
            String query = "INSERT INTO Assistant (NoAssistant,Prenom,Nom,Specialites,Remarques) VALUES (@id,@prenom,@nom, @specialite, @remarques)";

            SqlCommand command = new SqlCommand(query, maConnexion);
            command.Parameters.Add(new SqlParameter("@id", strNoAssistant));
            command.Parameters.Add(new SqlParameter("@nom", strNom));
            command.Parameters.Add(new SqlParameter("@prenom", strPrenom));
            command.Parameters.Add(new SqlParameter("@specialite", strSpecialite));
            command.Parameters.Add(new SqlParameter("@remarques", strRemarques));

            command.ExecuteNonQuery();

            maConnexion.Close();
            Close();
        }
    }
}

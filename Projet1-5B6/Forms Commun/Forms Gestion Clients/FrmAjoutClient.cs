using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Commun
{
    public partial class FrmAjoutClient : Form
    {
        private Control[] controlesAValider;
        private readonly BD5B6TP1_ConstantinBrassardLaheyDataSet.ClientRow client;
        private readonly  bool modifMode;

        public FrmAjoutClient(BD5B6TP1_ConstantinBrassardLaheyDataSet.ClientRow client, bool modifMode = false)
        {
            
            InitializeComponent();
            this.client = client;

            controlesAValider = new Control[]
            {
                tbPrenom,
                tbAdresse,
                tbCodePostal,
                tbNom,
                tbPays,
                tbVille,
            };

            this.modifMode = modifMode;
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (!Valider()) return;

            client.Adresse = tbAdresse.Text;
            client.CodePostal = tbCodePostal.Text;
            client.DateInscription = DateTime.Today;
            client.Nom = tbNom.Text;
            client.Pays = tbPays.Text;
            client.Prenom = tbPrenom.Text;
            client.Ville = tbVille.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool Valider()
        {
            return controlesAValider.All(ControleNonVide);
        }

        private void FrmAjoutClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Client);
            tbNoClient.Text = client.NoClient.ToString();

            if (modifMode)
            {
                tbPrenom.Text = client.Prenom;
                tbNom.Text = client.Nom;
                tbAdresse.Text = client.Adresse;
                tbCodePostal.Text = client.CodePostal;
                tbPays.Text = client.Pays;
                tbVille.Text = client.Ville;

                lblEntete.Text = "Modifier client";
                Text = "Modification d'un client";
                btnAjout.Text = "Confirmer les modifications";
            }
        }

        private void ValiderFormulaireRempli(object sender, EventArgs e)
        {
            btnAjout.Enabled = Valider();
        }

        private bool ControleNonVide(Control ctrl)
        {
            return ctrl.Text.Trim() != "";
        }
    }
}

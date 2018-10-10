using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Commun
{
    public partial class FrmAjoutClient : Form
    {
        private readonly Control[] controlesAValider;
        private readonly BD5B6TP1_ConstantinBrassardLaheyDataSet.ClientRow client;

        public FrmAjoutClient(BD5B6TP1_ConstantinBrassardLaheyDataSet.ClientRow client)
        {
            controlesAValider = new Control[]
            {
                tbPrenom,
                tbAdresse,
                tbCodePostal,
                tbNom,
                tbPays,
                tbVille,
            };
            InitializeComponent();
            this.client = client;
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (!Valider()) return;

            client.Adresse = tbAdresse.Text;
            client.CodePostal = tbCodePostal.Text;
            client.DateInscription = DateTime.Today;
            client.NoClient = TrouverNoClient();
            client.Nom = tbNom.Text;
            client.Pays = tbPays.Text;
            client.Prenom = tbPrenom.Text;
            client.Ville = tbVille.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private int TrouverNoClient()
        {
            int plusGrandId = 0;

            foreach (DataRow rangee in bD5B6TP1_ConstantinBrassardLaheyDataSet.Client.Rows)
            {
                int id = Convert.ToInt32(rangee["NoClient"]);
                if (id > plusGrandId)
                    plusGrandId = id;
            }

            return plusGrandId + 10;
        }

        private bool Valider()
        {
            return controlesAValider.All(ControleNonVide);
        }

        private void FrmAjoutClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Client);
        }

        private void ValiderFormulaireRempli(object sender, EventArgs e)
        {
            btnAjout.Enabled = Valider();
        }

        private bool ControleNonVide(Control ctrl)
        {
            return true;
            //return ctrl.Text.Trim() != "";
        }
    }
}

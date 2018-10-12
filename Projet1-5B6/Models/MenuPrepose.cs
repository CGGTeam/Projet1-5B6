using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1_5B6.Forms_Admin.ReservationChambres;
using Projet1_5B6.Forms_Commun;
using Projet1_5B6.Forms_Commun.Forms_Gestion_Soins;

namespace Projet1_5B6.Models
{
    class MenuPrepose: MenuUtilisateur
    {
        private ToolStripMenuItem itGestionClientsInvites;
        private ToolStripMenuItem itPlanifSoins;
        private ToolStripMenuItem itReservationChambres;
        private ToolStripMenuItem itDeconnexion;
        private ToolStripMenuItem itQuitter;

        public MenuPrepose()
        {
            InitializeComponent();
        }
        private void Deconnecter(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                Deconnexion?.Invoke(this, null);
            }
        }
        private void Quitter(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                Application.Exit();
            }
        }
        private bool demandeFermer()
        {
            if (!BaseFormGestion.estSavegarder)
            {
                DialogResult result = MessageBox.Show("Vous êtes sur le point de quitter sans avoir sauvegarder! \n Êtes-vous sûr de vouloir quitter?", "Fermeture déconnexion", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (result == DialogResult.Yes)
                {
                    BaseFormGestion.estSavegarder = true;
                    BaseFormGestion.estDeconnexion = true;
                    return true;
                }
                return false;
            }
            else
            {
                BaseFormGestion.estSavegarder = true;
                BaseFormGestion.estDeconnexion = true;
                return true;
            }
        }

        private void ReservationChambres(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmReservationChambres(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }

        private void PlanifSoins(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmPlanificationSoins(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }

        private void GestionClientsInvites(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmGestionClientsInvites(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }

        private void InitializeComponent()
        {
            this.itGestionClientsInvites = new System.Windows.Forms.ToolStripMenuItem();
            this.itPlanifSoins = new System.Windows.Forms.ToolStripMenuItem();
            this.itReservationChambres = new System.Windows.Forms.ToolStripMenuItem();
            this.itDeconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.itQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // itGestionClientsInvites
            // 
            this.itGestionClientsInvites.Name = "itGestionClientsInvites";
            this.itGestionClientsInvites.Size = new System.Drawing.Size(213, 20);
            this.itGestionClientsInvites.Text = "Gestion clients et invités";
            this.itGestionClientsInvites.Click += GestionClientsInvites;
            // 
            // itPlanifSoins
            // 
            this.itPlanifSoins.Name = "itPlanifSoins";
            this.itPlanifSoins.Size = new System.Drawing.Size(157, 20);
            this.itPlanifSoins.Text = "Planification soin";
            this.itPlanifSoins.Click += PlanifSoins;
            // 
            // itReservationChambres
            // 
            this.itReservationChambres.Name = "itReservationChambres";
            this.itReservationChambres.Size = new System.Drawing.Size(197, 20);
            this.itReservationChambres.Text = "Réservation chambres";
            this.itReservationChambres.Click += ReservationChambres;
            // 
            // itDeconnexion
            // 
            this.itDeconnexion.Name = "itDeconnexion";
            this.itDeconnexion.Size = new System.Drawing.Size(127, 20);
            this.itDeconnexion.Text = "Déconnexion";
            this.itDeconnexion.Click += Deconnecter;
            // 
            // itQuitter
            // 
            this.itQuitter.Name = "itQuitter";
            this.itQuitter.Size = new System.Drawing.Size(79, 20);
            this.itQuitter.Text = "Quitter";
            this.itQuitter.Click += Quitter;
            // 
            // MenuPrepose
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itGestionClientsInvites,
            this.itPlanifSoins,
            this.itReservationChambres,
            this.itDeconnexion,
            this.itQuitter});
            this.Text = "Menu préposé";
            this.ResumeLayout(false);
        }

        public override event EventHandler Deconnexion;
    }
}

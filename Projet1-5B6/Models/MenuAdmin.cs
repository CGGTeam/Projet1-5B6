using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1_5B6.Forms_Admin;
using Projet1_5B6.Forms_Admin.Fomrs_Rapports;
using Projet1_5B6.Forms_Admin.ReservationChambres;
using Projet1_5B6.Forms_Commun;
using Projet1_5B6.Forms_Commun.Forms_Gestion_Assistants;
using Projet1_5B6.Forms_Commun.Forms_Gestion_Soins;
using Projet1_5B6.Forms_Commun.Forms_Gestion_Utilisateur;

namespace Projet1_5B6.Models
{
    class MenuAdmin: MenuUtilisateur
    {
        private ToolStripMenuItem itMenuAdmin;
        private ToolStripMenuItem itGestionUtilisateur;
        private ToolStripMenuItem itGestionClientsInvs;
        private ToolStripMenuItem itGestSoins;
        private ToolStripMenuItem itGestAssistants;
        private ToolStripMenuItem itGestChambres;
        private ToolStripMenuItem itReservChambres;
        private ToolStripMenuItem itVisualiserRapp;
        private ToolStripMenuItem itDeconnect;
        private ToolStripMenuItem itQuit;
        private ToolStripMenuItem itRappSoinsClients;
        private ToolStripMenuItem itRappReservChambres;
        private ToolStripMenuItem itRappSoinsAssist;

        public MenuAdmin()
        {
            InitializeComponent();
        }
        private void GestionUtilisateurs(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmGestionUtilisateurs(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }

        }
        private void GestionAssistants(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmGestionAssistant(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }

        private void GestionClientInvites(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmGestionClientsInvites(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }

        private void GestionSoins(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmGestionSoins(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }

        private void GestionChambres(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmGestionChambresEtTypes(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }
        public static void QuitterStatic()
        {
            if (!BaseFormGestion.estSavegarder)
            {
                DialogResult result = MessageBox.Show("Vous êtes sur le point de quitter sans avoir sauvegarder! \n Êtes-vous sûr de vouloir quitter?", "Fermeture déconnexion", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (result == DialogResult.Yes)
                {
                    BaseFormGestion.estSavegarder = true;
                    BaseFormGestion.estDeconnexion = true;
                    Application.Exit();
                }
            }
            else
            {
                BaseFormGestion.estSavegarder = true;
                BaseFormGestion.estDeconnexion = true;
                Application.Exit();
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

        private void Deconnecter(object sender, EventArgs e)
        {
            if(demandeFermer())
            {
                FindForm()?.Hide();
                Deconnexion?.Invoke(this, null);
            }
        }

        private void PlanificationSoins(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmPlanificationSoins(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }

        private void ReservationChambre(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmReservationChambres(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }
        private void RappSoinsClients(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmSoinsClients(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }

        private void RappReservChambres(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmReservChambres(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }

        private void RappSoinsAssist(object sender, EventArgs e)
        {
            if (demandeFermer())
            {
                FindForm()?.Hide();
                new FrmSoinsAssistants(this).ShowDialog();
                BaseFormGestion.estDeconnexion = false;
            }
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem itPlanifSoins;
            this.itMenuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.itGestionUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.itGestionClientsInvs = new System.Windows.Forms.ToolStripMenuItem();
            this.itGestSoins = new System.Windows.Forms.ToolStripMenuItem();
            this.itGestAssistants = new System.Windows.Forms.ToolStripMenuItem();
            this.itGestChambres = new System.Windows.Forms.ToolStripMenuItem();
            this.itReservChambres = new System.Windows.Forms.ToolStripMenuItem();
            this.itVisualiserRapp = new System.Windows.Forms.ToolStripMenuItem();
            this.itRappSoinsClients = new System.Windows.Forms.ToolStripMenuItem();
            this.itRappReservChambres = new System.Windows.Forms.ToolStripMenuItem();
            this.itRappSoinsAssist = new System.Windows.Forms.ToolStripMenuItem();
            this.itDeconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.itQuit = new System.Windows.Forms.ToolStripMenuItem();
            itPlanifSoins = new System.Windows.Forms.ToolStripMenuItem();

            this.SuspendLayout();
            // 
            // itMenuAdmin
            // 
            this.itMenuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itGestionUtilisateur,
            this.itGestionClientsInvs,
            this.itGestSoins,
            itPlanifSoins,
            this.itGestAssistants,
            this.itGestChambres,
            this.itReservChambres,
            this.itVisualiserRapp,
            this.itDeconnect,
            this.itQuit});
            this.itMenuAdmin.Name = "itMenuAdmin";
            this.itMenuAdmin.Size = new System.Drawing.Size(124, 20);
            this.itMenuAdmin.Text = "Menu admin";
            // 
            // itGestionUtilisateur
            // 
            this.itGestionUtilisateur.Name = "itGestionUtilisateur";
            this.itGestionUtilisateur.Size = new System.Drawing.Size(269, 30);
            this.itGestionUtilisateur.Text = "Gestion utilisateurs";
            this.itGestionUtilisateur.Click += GestionUtilisateurs;
            // 
            // itGestionClientsInvs
            // 
            this.itGestionClientsInvs.Name = "itGestionClientsInvs";
            this.itGestionClientsInvs.Size = new System.Drawing.Size(269, 30);
            this.itGestionClientsInvs.Text = "Gestion clients/invités";
            this.itGestionClientsInvs.Click += GestionClientInvites;
            // 
            // itGestSoins
            // 
            this.itGestSoins.Name = "itGestSoins";
            this.itGestSoins.Size = new System.Drawing.Size(269, 30);
            this.itGestSoins.Text = "Gestion soins";
            this.itGestSoins.Click += GestionSoins;
            // 
            // itPlanifSoins
            // 
            itPlanifSoins.Name = "itPlanifSoins";
            itPlanifSoins.Size = new System.Drawing.Size(269, 30);
            itPlanifSoins.Text = "Planification soins";
            itPlanifSoins.Click += PlanificationSoins;
            // 
            // itGestAssistants
            // 
            this.itGestAssistants.Name = "itGestAssistants";
            this.itGestAssistants.Size = new System.Drawing.Size(269, 30);
            this.itGestAssistants.Text = "Gestion Assistants";
            this.itGestAssistants.Click += GestionAssistants;
            // 
            // itGestChambres
            // 
            this.itGestChambres.Name = "itGestChambres";
            this.itGestChambres.Size = new System.Drawing.Size(269, 30);
            this.itGestChambres.Text = "Gestion chambres";
            this.itGestChambres.Click += GestionChambres;
            // 
            // itReservChambres
            // 
            this.itReservChambres.Name = "itReservChambres";
            this.itReservChambres.Size = new System.Drawing.Size(269, 30);
            this.itReservChambres.Text = "Reservation chambres";
            this.itReservChambres.Click += ReservationChambre;
            // 
            // itVisualiserRapp
            // 
            this.itVisualiserRapp.Name = "itVisualiserRapp";
            this.itVisualiserRapp.Size = new System.Drawing.Size(269, 30);
            this.itVisualiserRapp.Text = "Visualiser Rapports";
            this.itVisualiserRapp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.itRappSoinsClients,
                this.itRappReservChambres,
                this.itRappSoinsAssist
            });
                // 
                // itRappSoinsClients
                // 
                this.itRappSoinsClients.Name = "itRappSoinsClients";
                this.itRappSoinsClients.Size = new System.Drawing.Size(269, 30);
                this.itRappSoinsClients.Text = "Rapport des soins offerts aux clients et aux invités";
                this.itRappSoinsClients.Click += RappSoinsClients;
                // 
                // itRappReservChambres
                // 
                this.itRappReservChambres.Name = "itRappReservChambres";
                this.itRappReservChambres.Size = new System.Drawing.Size(269, 30);
                this.itRappReservChambres.Text = "Rapport des réservations de chambres";
                this.itRappReservChambres.Click += RappReservChambres;
                // 
                // itRappSoinsAssist
                // 
                this.itRappSoinsAssist.Name = "itRappSoinsAssist";
                this.itRappSoinsAssist.Size = new System.Drawing.Size(269, 30);
                this.itRappSoinsAssist.Text = "Rapport des soins journaliers des assistants";
                this.itRappSoinsAssist.Click += RappSoinsAssist;
            // 
            // itDeconnect
            // 
            this.itDeconnect.Name = "itDeconnect";
            this.itDeconnect.Size = new System.Drawing.Size(269, 30);
            this.itDeconnect.Text = "Déconnexion";
            this.itDeconnect.Click += Deconnecter;
            // 
            // itQuit
            // 
            this.itQuit.Name = "itQuit";
            this.itQuit.Size = new System.Drawing.Size(269, 30);
            this.itQuit.Text = "Quitter";
            this.itQuit.Click += Quitter;
            // 
            // MenuAdmin
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itMenuAdmin});
            this.Text = "Menu Admin";
            this.ResumeLayout(false);

        }

        public override event EventHandler Deconnexion;
    }
}

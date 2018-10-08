using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1_5B6.Forms_Admin;
using Projet1_5B6.Forms_Commun;
using Projet1_5B6.Forms_Commun.Forms_Gestion_Soins;

namespace Projet1_5B6.Models
{
    class MenuAdmin: MenuUtilisateur
    {
        private ToolStripMenuItem itMenuAdmin;
        private ToolStripMenuItem itGestionClientsInvs;
        private ToolStripMenuItem itGestSoins;
        private ToolStripMenuItem itGestAssistants;
        private ToolStripMenuItem itGestChambres;
        private ToolStripMenuItem itReservChambres;
        private ToolStripMenuItem itVisualiserRapp;
        private ToolStripMenuItem itDeconnect;
        private ToolStripMenuItem itQuit;

        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void GestionAssistants(object sender, EventArgs e)
        {
            FindForm()?.Hide();
            new FrmGestionAssistants(this).Show();
        }

        private void GestionClientInvites(object sender, EventArgs e)
        {
            FindForm()?.Hide();
            new FrmGestionClientsInvites(this).Show();
        }

        private void GestionSoins(object sender, EventArgs e)
        {
            FindForm()?.Hide();
            new FrmGestionSoins(this).Show();
        }

        private void GestionChambres(object sender, EventArgs e)
        {
            FindForm()?.Hide();
            new FrmGestionChambresEtTypes(this).Show();
        }

        private void Quitter(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Deconnecter(object sender, EventArgs e)
        {
            FindForm()?.Hide();
            new FrmConnexion().Show();
            Deconnexion?.Invoke(this, null);
        }

        private void PlanificationSoins(object sender, EventArgs e)
        {
            FindForm()?.Hide();
            new FrmPlanificationSoins(this).Show();
        }

        private void ReservationChambre(object sender, EventArgs e)
        {
            //TODO: Implémenter (Vincent)
            throw new NotImplementedException();
        }

        private void VisualiserRapport(object sender, EventArgs e)
        {
            //TODO: Implémenter (Vincent)
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem itPlanifSoins;
            this.itMenuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.itGestionClientsInvs = new System.Windows.Forms.ToolStripMenuItem();
            this.itGestSoins = new System.Windows.Forms.ToolStripMenuItem();
            this.itGestAssistants = new System.Windows.Forms.ToolStripMenuItem();
            this.itGestChambres = new System.Windows.Forms.ToolStripMenuItem();
            this.itReservChambres = new System.Windows.Forms.ToolStripMenuItem();
            this.itVisualiserRapp = new System.Windows.Forms.ToolStripMenuItem();
            this.itDeconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.itQuit = new System.Windows.Forms.ToolStripMenuItem();
            itPlanifSoins = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // itMenuAdmin
            // 
            this.itMenuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itVisualiserRapp.Click += VisualiserRapport;
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

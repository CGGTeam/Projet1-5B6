using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters;
using Projet1_5B6.Forms_Commun.Forms_Gestion_Clients;
using Projet1_5B6.Models;

namespace Projet1_5B6.Forms_Commun
{
    public partial class FrmGestionClientsInvites : BaseFormGestion
    {
        public FrmGestionClientsInvites(MenuUtilisateur menu) : base(menu)
        {
            InitializeComponent();
        }

        private void FormClientsInvites_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Invite' table. You can move, or remove it, as needed.
            this.inviteTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Invite);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Client);
            // TODO: This line of code loads data into the 'bD5B6TP1_ConstantinBrassardLaheyDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bD5B6TP1_ConstantinBrassardLaheyDataSet.Client);

            if (clientBindingSource.Current != null)
            {
                btnSupprimerCli.Enabled = ClientEstSupprimable((DataRowView)clientBindingSource.Current);
            }
            else
            {
                btnSupprimerCli.Enabled = false;
            }

            if (inviteBindingSource.Current != null)
            {
                btnSupprimerInvite.Enabled = InviteEstSupprimable((DataRowView)inviteBindingSource.Current);
            }
            else
            {
                btnSupprimerInvite.Enabled = false;
            }

            clientBindingSource.CurrentChanged += OnChangeCurrentClient;
            inviteBindingSource.CurrentChanged += OnChangeCurrentInvite;
        }

        private void btnAjoutCli_Click(object sender, EventArgs e)
        {
            var nouveauClient = bD5B6TP1_ConstantinBrassardLaheyDataSet.Client.NewClientRow();

            nouveauClient.NoClient = DeterminerNoNouveauClient();

            FrmAjoutClient frmAjout = new FrmAjoutClient(nouveauClient);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.Client.AddClientRow(nouveauClient);
            clientBindingSource.MoveLast();
        }

        private int DeterminerNoNouveauClient()
        {
            int plusGrandId = 0;

            foreach (BD5B6TP1_ConstantinBrassardLaheyDataSet.ClientRow rangee in bD5B6TP1_ConstantinBrassardLaheyDataSet.Client)
            {
                if (rangee.NoClient > plusGrandId)
                {
                    plusGrandId = rangee.NoClient;
                }
            }

            return plusGrandId + 10;
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Validate();
            clientBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.bD5B6TP1_ConstantinBrassardLaheyDataSet);
        }

        private void OnChangeCurrentClient(object sender, EventArgs e)
        {
            if (clientBindingSource.Current == null)
            {
                btnSupprimerInvite.Enabled = false;
                return;
            }
            btnSupprimerCli.Enabled = ClientEstSupprimable((DataRowView)clientBindingSource.Current);
        }

        private void OnChangeCurrentInvite(object sender, EventArgs e)
        {
            if (inviteBindingSource.Count == 0) return;
            if (inviteBindingSource.Current == null)
            {
                btnSupprimerInvite.Enabled = false;
                return;
            }
            btnSupprimerInvite.Enabled = InviteEstSupprimable((DataRowView)inviteBindingSource.Current);
        }

        private void btnSupprimerCli_Click(object sender, EventArgs e)
        {
            ADOUtils.SupprimerSelection(clientBindingSource, ClientEstSupprimable);
        }

        private bool ClientEstSupprimable(DataRowView selection)
        {
            bool peutEtreSupprime = true;
            string texteTooltip = "Le client sélectionné ne peut pas être supprimé car:";
            ttpSupprimer.SetToolTip(btnSupprimerCli, "");

            int noClientSelectionne = (int)selection["NoClient"];


            if (bD5B6TP1_ConstantinBrassardLaheyDataSet.Invite.Any(invite => invite.NoClient == noClientSelectionne))
            {
                texteTooltip += "\n\t- Il a des invités associés";
                peutEtreSupprime = false;
            }

            ReservationChambreTableAdapter reservationTableAdapter = new ReservationChambreTableAdapter();
            reservationTableAdapter.Fill(bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre);
            BD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambreDataTable reservationTable =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.ReservationChambre;

            if (reservationTable.Any(reservation => reservation.NoClient == noClientSelectionne))
            {
                texteTooltip += "\n\t- Il a réservé au moins une chambre";
                peutEtreSupprime = false;
            }

            PlanifSoinTableAdapter planifSoinTableAdapter = new PlanifSoinTableAdapter();
            planifSoinTableAdapter.Fill(bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin);
            BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinDataTable planifSoinTable =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin;

            if (planifSoinTable.Any(reservation => reservation.NoPersonne == noClientSelectionne))
            {
                texteTooltip += "\n\t- Il a au moins un soin de planifié";
                peutEtreSupprime = false;
            }

            if (!peutEtreSupprime)
            {
                ttpSupprimer.Show(texteTooltip, btnSupprimerCli, 3000);
            }

            return peutEtreSupprime;
        }

        private bool InviteEstSupprimable(DataRowView selection)
        {
            bool peutEtreSupprime = true;
            string texteTooltip = "L'invité sélectionné ne peut pas être supprimé car:";
            ttpSupprimer.SetToolTip(btnSupprimerInvite, "");

            int noClientSelectionne = (int)selection["NoClient"];

            PlanifSoinTableAdapter planifSoinTableAdapter = new PlanifSoinTableAdapter();
            planifSoinTableAdapter.Fill(bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin);
            BD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoinDataTable planifSoinTable =
                bD5B6TP1_ConstantinBrassardLaheyDataSet.PlanifSoin;

            if (planifSoinTable.Any(reservation => reservation.NoPersonne == noClientSelectionne))
            {
                texteTooltip += "\n\t- Il a au moins un soin de planifié";
                peutEtreSupprime = false;
            }

            if (!peutEtreSupprime)
            {
                ttpSupprimer.Show(texteTooltip, btnSupprimerInvite, 3000);
            }

            return peutEtreSupprime;
        }

        private int DeterminerNoNouvelInvite()
        {
            int plusPetitNoLibre = IdClientCourant + 1;

            IEnumerable<DataRowView> listeInvites = inviteBindingSource.List.Cast<DataRowView>();

            foreach (DataRowView invite in listeInvites.Where(IdNonNull).OrderBy(SortParId))
            {
                var noInvite = invite["NoInvite"];

                if (plusPetitNoLibre == Convert.ToInt32(noInvite))
                {
                    plusPetitNoLibre++;
                }
            }

            return plusPetitNoLibre;
        }

        private bool IdNonNull(DataRowView invite)
        {
            return !(invite["NoInvite"] is DBNull);
        }

        private int SortParId(DataRowView invite)
        {
            return Convert.ToInt32(invite["NoInvite"]);
        }

        private int IdClientCourant
        {
            get
            {
                DataRowView clientCourant = (DataRowView)clientBindingSource.Current;

                int idClientCourant = Convert.ToInt32(clientCourant["NoClient"]);

                return idClientCourant;
            }
        }

        private void VerifierNbInvites()
        {
            bool nbInvitesEnDessousDeLimite = inviteBindingSource.List.Count < 9;
            btnAjouterInvite.Enabled = nbInvitesEnDessousDeLimite;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bD5B6TP1_ConstantinBrassardLaheyDataSet.RejectChanges();
            clientBindingSource.ResetBindings(false);
        }

        private void btnSupprimerInvite_Click(object sender, EventArgs e)
        {
            ADOUtils.SupprimerSelection(inviteBindingSource, InviteEstSupprimable);
            VerifierNbInvites();
            ClientEstSupprimable((DataRowView)clientBindingSource.Current);
        }

        private void btnAjouterInvite_Click(object sender, EventArgs e)
        {
            var nouvelInvite = bD5B6TP1_ConstantinBrassardLaheyDataSet.Invite.NewInviteRow();

            nouvelInvite.NoInvite = DeterminerNoNouvelInvite();
            nouvelInvite.NoClient = (int)((DataRowView)clientBindingSource.Current)["NoClient"];

            FrmAjoutInvite frmAjout = new FrmAjoutInvite(nouvelInvite);

            DialogResult resultat = frmAjout.ShowDialog();

            if (resultat == DialogResult.Cancel) return;

            bD5B6TP1_ConstantinBrassardLaheyDataSet.Invite.AddInviteRow(nouvelInvite);
            inviteBindingSource.MoveLast();
            VerifierNbInvites();
        }
    }
}

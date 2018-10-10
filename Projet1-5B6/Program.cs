using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters;

namespace Projet1_5B6
{
    static class Program
    {
        private const string DOSSIER_XML = "sauvegarde_xml";
        private const XmlWriteMode MODE_ECRITURE_XML = XmlWriteMode.WriteSchema;
        private static bool sauvegardeEffectue = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += SauvegarderDataSetXml;
            AppDomain.CurrentDomain.ProcessExit += SauvegarderDataSetXml;

            GestionForms gf = new GestionForms();
            gf.Demarrer();
        }

        private static void SauvegarderDataSetXml(object sender, EventArgs e)
        {
            if (sauvegardeEffectue) return;

            sauvegardeEffectue = true;

            string cheminAbsolu = Path.Combine(Application.StartupPath, DOSSIER_XML);

            Directory.CreateDirectory(cheminAbsolu);

            BD5B6TP1_ConstantinBrassardLaheyDataSet dataset = new BD5B6TP1_ConstantinBrassardLaheyDataSet();
            
            SoinTableAdapter soinTableAdapter = new SoinTableAdapter();
            ClientTableAdapter clientTableAdapter = new ClientTableAdapter();
            AssistantSoinTableAdapter assistanSoinDescriptionTableAdapter = new AssistantSoinTableAdapter();
            AssistantTableAdapter assistantTableAdapter = new AssistantTableAdapter();
            ChambreTableAdapter chambreTableAdapter = new ChambreTableAdapter();
            ChambreEtPrixTableAdapter chambreEtPrixTableAdapter = new ChambreEtPrixTableAdapter();
            InviteTableAdapter inviteTableAdapter = new InviteTableAdapter();
            PlanifSoinTableAdapter planifSoinTableAdapter = new PlanifSoinTableAdapter();
            ReservationChambreTableAdapter reservationChambreTableAdapter = new ReservationChambreTableAdapter();
            TypeChambreTableAdapter typeChambreTableAdapter = new TypeChambreTableAdapter();
            SoinsPersonnesTableAdapter soinsPersonnesTableAdapter = new SoinsPersonnesTableAdapter();
            TypeSoinTableAdapter typeSoinTableAdapter = new TypeSoinTableAdapter();
            TypeUtilisateurTableAdapter typeUtilisateurTableAdapter = new TypeUtilisateurTableAdapter();
            UtilisateurTableAdapter utilisateurTableAdapter = new UtilisateurTableAdapter();
            AssistantSoinTableAdapter assistantSoinTableAdapter = new AssistantSoinTableAdapter();

            soinTableAdapter.Fill(dataset.Soin);
            clientTableAdapter.Fill(dataset.Client);
            assistantTableAdapter.Fill(dataset.Assistant);
            assistantSoinTableAdapter.Fill(dataset.AssistantSoin);
            chambreTableAdapter.Fill(dataset.Chambre);
            chambreEtPrixTableAdapter.Fill(dataset.ChambreEtPrix);
            inviteTableAdapter.Fill(dataset.Invite);
            planifSoinTableAdapter.Fill(dataset.PlanifSoin);
            reservationChambreTableAdapter.Fill(dataset.ReservationChambre);
            typeChambreTableAdapter.Fill(dataset.TypeChambre);
            typeSoinTableAdapter.Fill(dataset.TypeSoin);
            typeUtilisateurTableAdapter.Fill(dataset.TypeUtilisateur);
            soinsPersonnesTableAdapter.Fill(dataset.SoinsPersonnes);
            utilisateurTableAdapter.Fill(dataset.Utilisateur);

            foreach (DataTable table in dataset.Tables)
            {
                string nomFichier = CamelCaseToSnakeCase(table.TableName);

                table.WriteXml($"{cheminAbsolu}\\{nomFichier}.xml", MODE_ECRITURE_XML);
            }
        }

        private static string CamelCaseToSnakeCase(string input)
        {
            string snakeCase = Regex.Replace(input, "(?<=[a-z0-9])[A-Z]", m => "_" + m.Value);
            return snakeCase.ToLowerInvariant();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6
{
    public static class GestionConflits
    {
        private static void AfficherErreur(string message)
        {
            MessageBox.Show(message,
                "Conflit d'accès",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }

        public static SqlRowUpdatedEventHandler GenererGestionConflit(string colonneID, string nom)
        {
            return (sender, e) =>
            {
                if (e.RecordsAffected == 0)
                {
                    string id = FormaterId(e.Row[colonneID]);

                    AfficherErreur($"Conflit d'accès concurrentiel pour {nom} {id}. Cet enregistrement ne sera pas sauvegardé.");

                    e.Status = UpdateStatus.Continue;
                }
            };
        }

        private static string FormaterId(object id)
        {
            if (id is DateTime)
            {
                return ((DateTime) id).ToLongDateString();
            }
            else
            {
                return id.ToString();
            }
        }
    }
}

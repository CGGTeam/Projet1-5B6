using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters;

namespace Projet1_5B6
{
    public static class Validation
    {
        public static CancelEventHandler ValiderDateHeureReservation(ErrorProvider errorProvider)
        {
            return (sender, e) =>
            {
                DateTimePicker controle = (DateTimePicker) sender;
                DateTime dateSaisie = controle.Value;
                TimeSpan debutJournee = new TimeSpan(8, 0, 0);
                TimeSpan finJournee = new TimeSpan(17, 0, 0);

                errorProvider.SetError(controle, "");

                if (dateSaisie < DateTime.Now)
                {
                    e.Cancel = true;
                    errorProvider.SetError(controle, "La date saisie doit être ultérieure à la date d'aujourd'hui");
                }
                else if (dateSaisie.DayOfWeek == DayOfWeek.Saturday || dateSaisie.DayOfWeek == DayOfWeek.Sunday)
                {
                    e.Cancel = true;
                    errorProvider.SetError(controle, "Une réservation ne peut pas être faite un samedi ou un dimanche");
                }
                else if (dateSaisie.TimeOfDay < debutJournee || dateSaisie.TimeOfDay > finJournee)
                {
                    e.Cancel = true;
                    errorProvider.SetError(controle, "L'heure de la réservation doit être entre 8h et 17h");
                }
            };
        }

        public static CancelEventHandler ValiderPrix(ErrorProvider errorProvider)
        {
            return (sender, e) =>
            {
                TextBox controle = (TextBox) sender;
                errorProvider.SetError(controle, "");

                try
                {
                    Convert.ToDecimal(controle.Text);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(controle, "Le prix doit être un montant décimal valide");
                }
            };
        }

        public static CancelEventHandler ValiderDescriptionSoin(ErrorProvider errorProvider)
        {
            return (sender, e) =>
            {
                TextBox controle = (TextBox) sender;
                errorProvider.SetError(controle, "");

                BD5B6TP1_ConstantinBrassardLaheyDataSet dataSet = new BD5B6TP1_ConstantinBrassardLaheyDataSet();
                SoinTableAdapter soinAdapter = new SoinTableAdapter();
                soinAdapter.Fill(dataSet.Soin);

                foreach (DataRow rangee in dataSet.Soin.Rows)
                {
                    if (controle.Text == (string) rangee["Description"])
                    {
                        e.Cancel = true;
                        errorProvider.SetError(controle, "Il existe déjà un soin ayant cette description");
                        break;
                    }
                }
            };
        }

        public static CancelEventHandler ValiderDescriptionTypeChambre(ErrorProvider errorProvider)
        {
            return (sender, e) =>
            {
                TextBox controle = (TextBox)sender;
                errorProvider.SetError(controle, "");

                BD5B6TP1_ConstantinBrassardLaheyDataSet dataSet = new BD5B6TP1_ConstantinBrassardLaheyDataSet();
                TypeChambreTableAdapter typeChambreAdapter = new TypeChambreTableAdapter();
                typeChambreAdapter.Fill(dataSet.TypeChambre);

                foreach (DataRow rangee in dataSet.TypeChambre.Rows)
                {
                    if (controle.Text == (string)rangee["Description"])
                    {
                        e.Cancel = true;
                        errorProvider.SetError(controle, "Il existe déjà un type de chambre ayant cette description");
                        break;
                    }
                }
            };
        }

        public static CancelEventHandler ValiderNonVide(ErrorProvider errorProvider)
        {
            return (sender, e) =>
            {
                TextBox controle = (TextBox)sender;
                errorProvider.SetError(controle, "");

                if (controle.Text == "")
                {
                    e.Cancel = true;
                    errorProvider.SetError(controle, "Ce champs doit être rempli");
                }
            };
        }
    }
}

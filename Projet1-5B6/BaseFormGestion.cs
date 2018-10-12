using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6
{
    public partial class BaseFormGestion : Form
    {
        public static bool estSavegarder = true;
        public static bool estDeconnexion = false;
        public static bool aAccepte = false;

        public BaseFormGestion()
        {
            InitializeComponent();
        }

        public BaseFormGestion(MenuStrip menu)
        {
            InitializeComponent();

            this.Controls.Remove(placeholderMenu);
            this.Controls.Add(menu);
        }

        private void confirmationClosing(object sender, FormClosingEventArgs e)
        {
            if (aAccepte) return;

            if (estSavegarder==false && estDeconnexion == false)
            {
                DialogResult result = MessageBox.Show("Vous êtes sur le point de quitter sans avoir sauvegarder! \n Êtes-vous sûr de vouloir quitter?","lol", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (result == DialogResult.Yes)
                {
                    aAccepte = true;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

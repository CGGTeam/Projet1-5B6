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
            if (estSavegarder==false && estDeconnexion == false)
            {
                DialogResult result = MessageBox.Show("Vous êtes sur le point de quitter sans avoir sauvegarder! \n Êtes-vous sûr de vouloir quitter?",e.CloseReason.ToString(), MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (result == DialogResult.Yes)
                {
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

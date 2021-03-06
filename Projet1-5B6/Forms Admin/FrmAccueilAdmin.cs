﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6.Forms_Admin
{
    public partial class FrmAccueilAdmin : BaseFormGestion
    {
        public FrmAccueilAdmin(MenuStrip menu) : base(menu)
        {
            InitializeComponent();
        }

        private void FrmAccueilAdmin_Load(object sender, EventArgs e)
        {
            String strAcceuil = "";
            strAcceuil = "Bonjour " + GestionForms.utilisateurConnecte.NomUtilisateur + "!";
            strAcceuil += "\n\nVous pouvez sélectionner un \nitem dans le menu supérieur! ";
            strAcceuil += "\n\nBonne journée!";
            lblAcceuil.Text = strAcceuil;
        }
    }
}

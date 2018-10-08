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
    }
}

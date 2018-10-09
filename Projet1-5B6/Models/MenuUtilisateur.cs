using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6.Models
{
    public class MenuUtilisateur: MenuStrip
    {
        public MenuUtilisateur()
        {
            this.Dock = DockStyle.Top;
        }

        public virtual event EventHandler Deconnexion;

        public static implicit operator MainMenu(MenuUtilisateur v)
        {
            throw new NotImplementedException();
        }
    }
}

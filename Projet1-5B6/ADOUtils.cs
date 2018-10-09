using System;
using System.Data;
using System.Windows.Forms;

namespace Projet1_5B6
{
    public static class ADOUtils
    {
        public static void SupprimerSelection(BindingSource bindingSource, Predicate<DataRowView> estSupprimable)
        {
            DataRowView selection = (DataRowView)bindingSource.Current;
            if (!estSupprimable(selection)) return;
            var confirmResult = MessageBox.Show("Êtes-vous sure de vouloir supprimer cet élément?",
                                    "Confirmation",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                selection.Delete();
            }
        }
    }
}

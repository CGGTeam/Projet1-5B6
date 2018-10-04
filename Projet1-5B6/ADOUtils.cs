using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1_5B6
{
    public static class ADOUtils
    {
        public static void SupprimerSelection(BindingSource bindingSource, Predicate<DataRowView> estSupprimable)
        {
            DataRowView selection = (DataRowView)bindingSource.Current;

            if (!estSupprimable(selection)) return;

            selection.Delete();
        }
    }
}

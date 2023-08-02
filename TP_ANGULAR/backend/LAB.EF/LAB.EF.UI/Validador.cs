using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LAB.EF.UI
{
    internal class Validador
    {
        public bool ValidarStringBox(TextBox textBox)
        {
            bool result = true;
            if (textBox.Text == string.Empty)
                return false;
            return result;
        }

        public bool HaySeleccion(DataGridView dgv)
        {
            bool result= true;
            if (dgv.SelectedRows.Count==0)
                return false;
            return result;
        }
    }
}

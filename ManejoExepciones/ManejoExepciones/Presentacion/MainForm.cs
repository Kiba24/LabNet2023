using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejoExepciones.Dominio;

namespace ManejoExepciones.Presentacion
{
    public partial class MainForm : Form
    {
        CalcuExepciones calc = new CalcuExepciones();
        Logic logic = new Logic();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDividirZero_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtDivZero.Text);
                a.DividirPorCero();
            }

            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception)
            {
                MessageBox.Show("No ingresaste nada?");
            }

            finally { MessageBox.Show("Operacion finalizada"); }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                int Div = calc.Dividir(Convert.ToInt32(txtDividendo.Text) , Convert.ToInt32(txtDivisor.Text));
                MessageBox.Show(Div.ToString());
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show($"Solo chuck Norris divide por 0! ({ex.Message})");
            }

            catch (Exception)
            {
                MessageBox.Show("Seguro ingreso una letra o no ingreso nada!");
            }
        }

        private void btnCustomExepcion_Click(object sender, EventArgs e)
        {
            try
            {
                logic.DisparadorExepcionCustom();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, de tipo: {ex.GetType()}");
            }

        }

        private void btnExepcion_Click(object sender, EventArgs e)
        {
            try
            {
                logic.DisparadorExepcion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, de tipo: {ex.GetType()}");
            }
        }
    }
}

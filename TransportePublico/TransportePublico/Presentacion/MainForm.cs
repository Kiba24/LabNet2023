using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportePublico.Dominio;

namespace TransportePublico.Presentacion
{
    public partial class MainForm : Form
    {
        List<Transporte> ltransporte = new List<Transporte>();

        public MainForm()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            //Algunos arreglos para el lado del "front del winforms"
            txtPasajeros.TextAlign = HorizontalAlignment.Center;

            dgvTransporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            //Desactivo la primera columna invisible porque tambien puede concluir en errores
            dgvTransporte.RowHeadersVisible = false;

        }



        #region EventosBotones

        private void btnTaxi_Click(object sender, EventArgs e)
        {
            int counterTaxi = 0;
            foreach (var v in ltransporte)
            {
                if (v is Taxi)
                {
                    counterTaxi++;
                }
            }

            //Validaciones
            if (counterTaxi > 4)
                MessageBox.Show("Lista de 5 taxis llena!", "ERROR");
            else
                if (ValidarTexto() && ValidPasajeros(5))
                {
                    
                    ltransporte.Add(new Taxi(Convert.ToInt32(txtPasajeros.Text)));
                    dgvTransporte.Rows.Add("Taxi", txtPasajeros.Text);
                }
                else MessageBox.Show("Por favor ingrese una cantidad valida de pasajeros \n" +
                    "(Maximo 4 pasajeros por Taxi)", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void btnBus_Click(object sender, EventArgs e)
        {
            int counterBus = 0;
            foreach (var v in ltransporte)
            {
                if (v is Omnibus)
                {
                    counterBus++;
                }
            }

            

            //Validaciones
            if (counterBus > 4)
                MessageBox.Show("Lista de 5 ominbus llena!", "ERROR");
            else
                if (ValidarTexto() && ValidPasajeros(100))
                {
                    dgvTransporte.Rows.Add("Omnibus", txtPasajeros.Text);
                    ltransporte.Add(new Omnibus(Convert.ToInt32(txtPasajeros.Text)));
                }
                else MessageBox.Show("Por favor ingrese una cantidad valida de pasajeros \n" +
                    "(Maximo 99 pasajeros por omnibus)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }


        private void dgvTransporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = dgvTransporte.CurrentCell.RowIndex;


            if (dgvTransporte.CurrentCell.ColumnIndex == 2)
            {
                MessageBox.Show(ltransporte[row].Avanzar());
            }

            if (dgvTransporte.CurrentCell.ColumnIndex == 3)
            {
                MessageBox.Show(ltransporte[row].Detenerse());
            }
        }


        #endregion


        #region MetodosValidar

        //Metodo para validar que haya un numero racional de pasajeros dependiendo el transporte
        //Le paso el MaxPasajeros asi puedo reutilizar el mismo metodo para ambos tipos.
        public bool ValidPasajeros(int MaxPasajeros)
        {
            if (txtPasajeros.Text != String.Empty && Convert.ToInt32(txtPasajeros.Text) < MaxPasajeros &&
                Convert.ToInt32(txtPasajeros.Text) > 0)
            {
                return true;
            }
            return false;
        }

        //Metodo para validar que el contenido del textbox solo sean numeros.
        public bool ValidarTexto()
        {
            if (Int32.TryParse(txtPasajeros.Text, out int result))
            {
                return true;
            }
            return false;
        }


        #endregion

    }
}

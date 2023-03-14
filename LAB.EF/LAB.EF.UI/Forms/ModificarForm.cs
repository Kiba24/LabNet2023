using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB.EF.Entities;
using LAB.EF.Logic;

namespace LAB.EF.UI.Forms
{
    public partial class ModificarForm : Form
    {
        Validador validador = new Validador();
        Customers customer;

        public ModificarForm(Customers c)
        {
            InitializeComponent();
            txtCiudad.Text = c.City;
            txtNombre.Text = c.ContactName;
            customer = c;
        }

        private void ModificarForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (validador.ValidarStringBox(txtCiudad) && validador.ValidarStringBox(txtNombre))
            {
                ClientesLogic clientesLogic = new ClientesLogic();
                customer.City = txtCiudad.Text;
                customer.ContactName = txtNombre.Text;
                clientesLogic.Update(customer);
                MessageBox.Show("Cliente modificado con exito");
                this.Close();

            }
            else MessageBox.Show("Los campos no pueden estar vacios");
        }
    }
}

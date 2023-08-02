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
using LAB.EF.Logic ;

namespace LAB.EF.UI
{
    public partial class AddClienteForm : Form
    {
        
        Validador Validador = new Validador();
        public AddClienteForm()
        {
            InitializeComponent();
        }

        public AddClienteForm(Customers c)
        {
            InitializeComponent();
            c.CustomerID=txtID.Text;
        }

        private void AddClienteForm_Load(object sender, EventArgs e)
        {
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesLogic clientesLogic = new ClientesLogic();
                Customers c = new Customers();
                if (Validador.ValidarStringBox(txtCompanyName) && Validador.ValidarStringBox(txtID)
                    && txtID.Text.Length<=4)
                {
                    c.CustomerID = txtID.Text;
                    c.CompanyName = txtCompanyName.Text;
                    clientesLogic.Add(c);
                    MessageBox.Show("Cliente agregado con exito!", "EXITO");
                    this.Close();
                }
                else MessageBox.Show("Los campos no pueden ser nulos ni mayores a 5 caracteres", "ERROR");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

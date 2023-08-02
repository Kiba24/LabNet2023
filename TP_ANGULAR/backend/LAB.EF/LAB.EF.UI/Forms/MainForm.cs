﻿using LAB.EF.Entities;
using LAB.EF.Logic;
using LAB.EF.UI.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LAB.EF.UI
{
    public partial class MainForm : Form
    {

        Validador v = new Validador();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CargarTablas();
        }


        public void CargarTablas()
        {
            try
            {
                ClientesLogic clientesLogic = new ClientesLogic();
                foreach(var c in clientesLogic.GetAll())
                {
                    dgvClientes.Rows.Add(c.CustomerID, c.CompanyName, c.ContactName, c.City);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void lblEmpleados_Click(object sender, EventArgs e)
        {
        }

        // -- EVENTOS DEL CRUD -- 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddClienteForm addForm = new AddClienteForm();
            addForm.ShowDialog();
            RefrescarTablas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesLogic clientesLogic = new ClientesLogic();
                string index = dgvClientes.SelectedCells[0].Value.ToString();
                Customers selected = clientesLogic.GetById(index);
                ////Obtengo el objeto tipo cliente para pasarlo por parametro al update


                ModificarForm ModiForm = new ModificarForm(selected);
                ModiForm.ShowDialog();
                RefrescarTablas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            try
            {

                if (v.HaySeleccion(dgvClientes))
                {
                    if (MessageBox.Show("Desea eliminar el cliente?", "ELIMINAR CLIENTE",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ClientesLogic clientesLogic = new ClientesLogic();
                        string index = dgvClientes.SelectedCells[0].Value.ToString();
                        clientesLogic.Delete(index);
                        MessageBox.Show($"Cliente con id {index} eliminado con exito!", "EXITO");
                        RefrescarTablas();
                    }

                }
                else MessageBox.Show("NO HAY NINGUN CLIENTE SELECCIONADO", "ERROR");
            }
            catch (Exception)
            {
                MessageBox.Show("No puede eliminarse el cliente por relacion con otra tabla\n" +
                    "(Intente con un cliente agregado manualmente)","ERROR");
            }
        }

        private void RefrescarTablas()
        {
            dgvClientes.Rows.Clear();
            CargarTablas();
        }
    }

}

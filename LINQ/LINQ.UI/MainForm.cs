using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Logic;
using LINQ.Entities;
using System.Windows.Forms;

namespace LINQ.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void LlenarProductos(string textolbl, List<Products> lproductos)
        {
            lstGenerica.Items.Clear();
            lblMostrar.Text = textolbl;
            foreach (var item in lproductos)
            {
                lstGenerica.Items.Add($"{item.ProductName} , Precio: {item.UnitPrice} " +
                    $", Stock: {item.UnitsInStock}");
            }
        }

        private void LlenarCustomers(string textolbl, List<Customers> lcustomers)
        {
            lstGenerica.Items.Clear();
            lblMostrar.Text = textolbl;
            foreach (var item in lcustomers)
            {
                lstGenerica.Items.Add($"ID: {item.CustomerID} Nombre: {item.ContactName}, Region: {item.Region}");
            }
        }

        private void LlenarString(string textolbl, List<String> lstring)
        {
            lstGenerica.Items.Clear();
            lblMostrar.Text = textolbl;
            foreach (var item in lstring)
            {
                lstGenerica.Items.Add(item);
            }
        }

        private void btnEJ1_Click(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            CustomerLogic clogic = new CustomerLogic();
            lblMostrar.Text = "Objeto customer.";

            lstGenerica.Items.Add(
                $"{clogic.DevolverCustomer().ContactName} | {clogic.DevolverCustomer().Country}");
        }


        private void btnEJ2_Click(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            ProductLogic plogic = new ProductLogic();
            LlenarProductos("Productos sin stock", plogic.SinStock());
        }

        private void btnEJ3_Click(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            ProductLogic plogic = new ProductLogic();
            LlenarProductos("Productos que tienen stock y que cuestan más de 3 por unidad", plogic.PrecioMayorA3());
        }

        private void btnEJ4_Click(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            CustomerLogic clogic = new CustomerLogic();
            LlenarCustomers("Todos los customers de la region WA", clogic.FiltrarPorRegion("WA"));
        }

        private void btnEJ5_Click(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            ProductLogic plogic = new ProductLogic();
            lblMostrar.Text = "primer elemento o nulo de una lista de productos donde el ID de\n" +
                " producto sea igual a 789";

            if (plogic.PrimeroEncontrado(789)==null)
            {
                MessageBox.Show("Objeto nulo");
            }
            else
            {
                lstGenerica.Items.Add($" ID:{plogic.PrimeroEncontrado(789).ProductID.ToString()}" +
                                      $"Nombre: {plogic.PrimeroEncontrado(789).ProductName}");
            }

        }

        private void btnEJ6_Click(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            CustomerLogic clogic = new CustomerLogic();
            LlenarString("Nombres de clienets en Mayusculas y minusculas", clogic.GetUpperAndLower());
        }

        private void btnEJ7_Click(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            CustomerLogic clogic = new CustomerLogic();
            LlenarString("Clientes con region WA con ordenes mayores a 1/1/1997.", clogic.JoinConOrders());
        }

        private void btnEJ8_Click(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            CustomerLogic clogic = new CustomerLogic();
            LlenarCustomers("Primeros 3 clientes con region WA", clogic.Top3Region("WA"));
        }

        private void btnEJ9_Click(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            ProductLogic plogic = new ProductLogic();
            LlenarProductos("Productos ordenados por nombre", plogic.GetAllPorNombre());
        }

        private void btnEJ10_Click(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            ProductLogic plogic = new ProductLogic();
            LlenarProductos("Productos ordenados por stock", plogic.GetAllPorStock());
        }


        private void btnEJ11_Click_1(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            ProductLogic plogic = new ProductLogic();
            LlenarString("Productos joineados a categorias", plogic.ProductoXCategoria());
        }

        private void btnEJ12_Click(object sender, EventArgs e)
        {
            lstGenerica.Items.Clear();
            ProductLogic plogic = new ProductLogic();
            lblMostrar.Text = "Primer producto de lista";
            Products item = plogic.PrimerProducto(plogic.GetAll()); //Inserto la lista con todos los productos
                                                                    //pero puede ser cualquiera
            lstGenerica.Items.Add($"{item.ProductName} , Precio: {item.UnitPrice} , Stock: {item.UnitsInStock}");
        }
    }
}

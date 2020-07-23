using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Final
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Salir_Principal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registro_FarmaceuticosP_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
        }

        private void Registrar_ClientesP_Click(object sender, EventArgs e)
        {
            Form formulario = new Clientes();
            formulario.Show();
        }

        private void Registrar_ProductoP_Click(object sender, EventArgs e)
        {
            Form formulario = new Productos();
            formulario.Show();
        }

        private void button_Eliminar_Farmaceutico_Click(object sender, EventArgs e)
        {
            Form formulario = new LoginDeConfirmacion();
            formulario.Show();
        }

        private void buttonMostrarStock_Click(object sender, EventArgs e)
        {
            Form formulario = new Mostrar_Stocks();
            formulario.Show();
        }

        private void buttonRegistrar_ServicioP_Click(object sender, EventArgs e)
        {
            Form formulario = new Servicios_Realizados();
            formulario.Show();
        }

        private void buttonRegistrarServicios_Click(object sender, EventArgs e)
        {

        }
    }
}

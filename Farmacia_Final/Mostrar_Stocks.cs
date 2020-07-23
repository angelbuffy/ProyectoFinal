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
    public partial class Mostrar_Stocks : Form
    {
        public Mostrar_Stocks()
        {
            InitializeComponent();
        }

        private void buttonSalir_MS_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonActualizar_MS_Click(object sender, EventArgs e)
        {
            Mostrar_Stock mos = new Mostrar_Stock();
            dataGridView1.DataSource = mos.MostrarStock();
        }

        private void buttonBuscar_MS_Click(object sender, EventArgs e)
        {
            Buscar_Producto bus = new Buscar_Producto(textBoxNombre_Producto.Text);
            dataGridView1.DataSource = bus.BuscarDatos();
        }
    }
}

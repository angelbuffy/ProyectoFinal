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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Registrar_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevoFarmaceutico = new Cliente(textBoxDNIC.Text,textBoxNombresC.Text,textApePatC.Text,
                    textBoxApeMatC.Text,textBoxDireccionC.Text,dateTimePickerC.Text);
                nuevoFarmaceutico.Registrar_Clientes();
            }

            catch (ArgumentNullException error)
            {
                MessageBox.Show("Complete los datos requeridos." + "\n" + error.ParamName, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                /*textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();*/
                textBoxDNIC.SelectAll();
                textBoxNombresC.SelectAll();
                textApePatC.SelectAll();
                textBoxApeMatC.SelectAll();
                textBoxDireccionC.SelectAll();
                //textBox6.SelectAll();
                textBoxDNIC.Focus();
                textBoxNombresC.Focus();
                textApePatC.Focus();
                textBoxApeMatC.Focus();
                textBoxDireccionC.Focus();
                //textBox6.Focus();
                return;
            }

            catch (ArgumentOutOfRangeException error)
            {
                MessageBox.Show(error.ParamName, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                /*textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();*/
                textBoxDNIC.SelectAll();
                textBoxNombresC.SelectAll();
                textApePatC.SelectAll();
                textBoxApeMatC.SelectAll();
                textBoxDireccionC.SelectAll();
                //textBox6.SelectAll();
                textBoxDNIC.Focus();
                textBoxNombresC.Focus();
                textApePatC.Focus();
                textBoxApeMatC.Focus();
                textBoxDireccionC.Focus();
                //textBox6.Focus();
                return;
            }

            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error." + "\n" + "Detalle: " + error.Message, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                /*textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();*/
                textBoxDNIC.SelectAll();
                textBoxNombresC.SelectAll();
                textApePatC.SelectAll();
                textBoxApeMatC.SelectAll();
                textBoxDireccionC.SelectAll();
                //textBox6.SelectAll();
                textBoxDNIC.Focus();
                textBoxNombresC.Focus();
                textApePatC.Focus();
                textBoxApeMatC.Focus();
                textBoxDireccionC.Focus();
                //textBox6.Focus();
                return;
            }

            MessageBox.Show("Inserción completada.", "lex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxDNIC.Clear();
            textBoxNombresC.Clear();
            textApePatC.Clear();
            textBoxApeMatC.Clear();
            textBoxDireccionC.Clear();
            //textBox6.Clear();
            textBoxDNIC.Focus();
            textBoxNombresC.Focus();
            textApePatC.Focus();
            textBoxApeMatC.Focus();
            textBoxDireccionC.Focus();
            //textBox6.Focus();

        }

        private void Salir_Cliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

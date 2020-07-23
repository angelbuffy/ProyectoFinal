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
    public partial class Servicios_Realizados : Form
    {
        public Servicios_Realizados()
        {
            InitializeComponent();
        }

        private void buttonSalirSR_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonRegistrarSR_Click(object sender, EventArgs e)
        {
            /*Servicios_Realizado ser = new Servicios_Realizado(textBoxDNI_SR.Text,textBoxNombres_SR.Text,
                textBoxApellidos_SR.Text,textBoxServicio_SR.Text);
            ser.RegistrarServicioRealizado();*/

            try
            {
                Servicios_Realizado ser = new Servicios_Realizado(textBoxDNI_SR.Text, textBoxNombres_SR.Text,
                textBoxApellidos_SR.Text, textBoxServicio_SR.Text);
                ser.RegistrarServicioRealizado();
            }

            catch (ArgumentNullException error)
            {
                MessageBox.Show("Complete los datos requeridos." + "\n" + error.ParamName, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 
                return;
            }

            catch (ArgumentOutOfRangeException error)
            {
                MessageBox.Show(error.ParamName, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error." + "\n" + "Detalle: " + error.Message, "Demo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            MessageBox.Show("Inserción completada.", "lex", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

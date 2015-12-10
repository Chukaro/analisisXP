using AnalisisXP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisXP
{
    public partial class Form1 : Form
    {
        private BuscarCliente buscar;
        private BuscarTarifa buscarTarifa;
        private int picture01Clik = 0;
        private int picture02Clik = 0;

        public Form1()
        {
            InitializeComponent();
            buscar = new BuscarCliente();
            buscarTarifa = new BuscarTarifa();
        }

        private void crearNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCliente registro = new RegistroCliente();
            registro.ShowDialog();
        }

        private void búsquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbNumero02.Controls.Clear();
            pbNumero02.Controls.Add(buscar);
        }

        private void crearTarifaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaTarifa nueva = new NuevaTarifa();
            nueva.ShowDialog();
        }

        private void buscarTarifaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbNumero02.Controls.Clear();
            pbNumero02.Controls.Add(buscarTarifa);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            llenarRegistro(picture01Clik);
        }

        private void pbNumero02_Click(object sender, EventArgs e)
        {
            llenarRegistro(picture02Clik);
        }


        private void llenarRegistro(int contador)
        {
            if (contador == 0)
            {
                RegistroEstacionamiento registroEstacionamiento = new RegistroEstacionamiento();
                registroEstacionamiento.ShowDialog();
                //pbNumero01.ImageLocation = @"\Imagenes\prueba.png";
                pbNumero01.Image = Resources.prueba;
                contador++;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Desea liberar el espacio?", "Espacio disponible", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    pbNumero01.Image = null;
                    contador = 0;
                }
            }
        }

        private void crearReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservacion reserva = new Reservacion();
            reserva.ShowDialog();
        }
    }
}

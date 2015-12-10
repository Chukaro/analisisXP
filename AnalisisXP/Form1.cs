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
        private int[] contadores = new int[11];
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

        private void llenarRegistro(PictureBox posicion, int i)
        {
            if (contadores[i] == 0)
            {
                RegistroEstacionamiento registroEstacionamiento = new RegistroEstacionamiento("" + i);
                registroEstacionamiento.ShowDialog();
                //pbNumero01.ImageLocation = @"\Imagenes\prueba.png";
                posicion.Image = Resources.prueba;
                contadores[i] = 1;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Desea liberar el espacio?", "Espacio disponible", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    posicion.Image = null;
                    contadores[i] = 0;
                }
            }
        }

        private void pos_01Click(object sender, EventArgs e)
        {
            llenarRegistro(pos_01, 0);
        }

        private void pos_02_Click(object sender, EventArgs e)
        {
            llenarRegistro(pos_02, 1);
        }

        private void pos_03_Click(object sender, EventArgs e)
        {
            llenarRegistro(pos_03, 2);
        }

        private void pos_04_Click(object sender, EventArgs e)
        {
            llenarRegistro(pos_04, 3);
        }

        private void pos_05_Click(object sender, EventArgs e)
        {
            llenarRegistro(pos_05, 4);
        }

        private void pos_06_Click(object sender, EventArgs e)
        {
            llenarRegistro(pos_06, 5);
        }

        private void pos_07_Click(object sender, EventArgs e)
        {
            llenarRegistro(pos_07, 6);
        }

        private void pos_08_Click(object sender, EventArgs e)
        {
            llenarRegistro(pos_08, 7);
        }

        private void pos_09_Click(object sender, EventArgs e)
        {
            llenarRegistro(pos_09, 8);
        }

        private void pos_10_Click(object sender, EventArgs e)
        {
            llenarRegistro(pos_10, 9);
        }

        private void pos_11_Click(object sender, EventArgs e)
        {
            llenarRegistro(pos_11, 10);
        }
    }
}

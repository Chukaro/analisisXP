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
        public Form1()
        {
            InitializeComponent();
        }

        private void crearNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCliente registro = new RegistroCliente();
            registro.ShowDialog();
        }

        private void búsquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCliente busqClient = new BuscarCliente();
            busqClient.Show();
        }
    }
}

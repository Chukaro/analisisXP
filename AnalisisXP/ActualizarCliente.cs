using DAL;
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
    public partial class ActualizarCliente : Form 
    {
        private int idCliente;

        public ActualizarCliente(Cliente cli)
        {
            InitializeComponent();
            idCliente = cli.IdCliente;

            txb_NombreClient.Text = cli.Nombre;
            txb_PaternoClient.Text = cli.Paterno;
            txb_MaternoCLient.Text = cli.Materno;
            txb_CedulaClient.Text = Convert.ToString(cli.Cedula);
            txb_TelfClient.Text = Convert.ToString(cli.Telefono);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Vaidacion.SoloNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Vaidacion.SoloNumeros(e);
        }

        private void btn_CancelarACtCLient_Click(object sender, EventArgs e)
        {
            this.Close();
            //hhgrtf
        }

        private void btn_ActClient_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea guardar los cambios?", "Modificar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                BRL.ClienteBRL.actClient(idCliente, txb_NombreClient.Text, txb_PaternoClient.Text, txb_MaternoCLient.Text, txb_CedulaClient.Text, txb_TelfClient.Text);
                this.Close();
            }
        }
    }
}

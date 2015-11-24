using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace AnalisisXP
{
    public partial class BuscarCliente : UserControl

    {
        Cliente cli = new Cliente();
        private int idVehiculo;
        
        public BuscarCliente()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            dgv_ListClient.DataSource = BRL.ClienteBRL.listaCliente();
            dgv_ListClient.Columns[0].Visible = false;
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            int opcion = Convert.ToInt32(cbx_TipoClient.SelectedIndex);

            switch(opcion)
            {
                case 0:
                    dgv_ListClient.DataSource = BRL.ClienteBRL.listaClientNombre(txb_DetBusqClient.Text);
                    dgv_ListClient.Columns[0].Visible = false;
                    break;

                case 1:
                    dgv_ListClient.DataSource = BRL.ClienteBRL.listaClienteApaterno(txb_DetBusqClient.Text);
                    dgv_ListClient.Columns[0].Visible = false;
                    break;

                case 2:
                    dgv_ListClient.DataSource = BRL.ClienteBRL.listClienteAmaterno(txb_DetBusqClient.Text);
                    dgv_ListClient.Columns[0].Visible = false;
                    break;

                case 3:
                    dgv_ListClient.DataSource = BRL.ClienteBRL.listCliCedula(txb_DetBusqClient.Text);
                    dgv_ListClient.Columns[0].Visible = false;
                    break;  
            }
        }

        private void dgv_ListClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cli.IdCliente = Convert.ToInt32(dgv_ListClient.CurrentRow.Cells[0].Value.ToString());
            dgv_ListAutos.DataSource = BRL.VehiculoBRL.listVehic(cli.IdCliente);
            dgv_ListAutos.Columns[0].Visible = false;
        }

        private void dgv_ListAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //idVehiculo = Convert.ToInt32(dgv_ListAutos.CurrentRow.Cells[0].Value.ToString());
            
        }

        private void btn_ClientElim_Click(object sender, EventArgs e)
        {
            cli.IdCliente = Convert.ToInt32(dgv_ListClient.CurrentRow.Cells[0].Value.ToString());
            DialogResult resultado = MessageBox.Show("¿Desea eliminar al Cliente: " + dgv_ListClient.CurrentRow.Cells[2].Value.ToString() + " " + dgv_ListClient.CurrentRow.Cells[3].Value.ToString() + " " + dgv_ListClient.CurrentRow.Cells[4].Value.ToString()+"?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                BRL.ClienteBRL.elimClient(cli.IdCliente);
                dgv_ListClient.DataSource = BRL.ClienteBRL.listaCliente();
                dgv_ListClient.Columns[0].Visible = false;
            }
        }

        private void btn_VehicElim_Click(object sender, EventArgs e)
        {
            idVehiculo = Convert.ToInt32(dgv_ListAutos.CurrentRow.Cells[0].Value.ToString());

            DialogResult resultado = MessageBox.Show("¿Desea eliminar al Vehiculo: " + dgv_ListAutos.CurrentRow.Cells[1].Value.ToString() + " " + dgv_ListAutos.CurrentRow.Cells[2].Value.ToString() + "?", "Eliminar Vehiculo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                BRL.VehiculoBRL.elimVehic(idVehiculo);
                dgv_ListAutos.DataSource = BRL.VehiculoBRL.listVehic(cli.IdCliente);
                dgv_ListAutos.Columns[0].Visible = false;
            }
        }

        private void btn_ClientAct_Click(object sender, EventArgs e)
        {
            Cliente clie = new Cliente();
            clie.IdCliente = Convert.ToInt32(dgv_ListClient.CurrentRow.Cells[0].Value.ToString());
            clie.Nombre = dgv_ListClient.CurrentRow.Cells[4].Value.ToString();
            clie.Paterno = dgv_ListClient.CurrentRow.Cells[2].Value.ToString();
            clie.Materno = dgv_ListClient.CurrentRow.Cells[3].Value.ToString();
            clie.Cedula = Convert.ToInt32(dgv_ListClient.CurrentRow.Cells[1].Value.ToString());
            clie.Telefono = Convert.ToInt32(dgv_ListClient.CurrentRow.Cells[5].Value.ToString());

            ActualizarCliente actualizar = new ActualizarCliente(clie);
            actualizar.ShowDialog();

            dgv_ListClient.DataSource = BRL.ClienteBRL.listaCliente();
            dgv_ListClient.Columns[0].Visible = false;
        }
    }
}

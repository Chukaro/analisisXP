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
        Vehiculo vei = new Vehiculo();
        TipoVehiculo tipo = new TipoVehiculo();
        Modelo modelo = new Modelo();
        private int idVehiculo, j;
        
        public BuscarCliente()
        {
            InitializeComponent();
            DatosComoboBox();
            this.Dock = DockStyle.Fill;
            dgv_ListClient.DataSource = BRL.ClienteBRL.listaCliente();
            dgv_ListClient.Columns[0].Visible = false;
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            int opcion = Convert.ToInt32(cbx_TipoClient.SelectedIndex);

            if (txb_DetBusqClient.Text == " ")
            {
                dgv_ListClient.DataSource = BRL.ClienteBRL.listaCliente();
            }

            switch(opcion)
            {
                case 0:
                    dgv_ListClient.DataSource = BRL.ClienteBRL.listaClientNombre(txb_DetBusqClient.Text);
                    dgv_ListClient.Columns[0].Visible = false;

                    dgv_ListAutos.Rows.Clear();
                    cargaAutos(cli.IdCliente);
                    break;

                case 1:
                    dgv_ListClient.DataSource = BRL.ClienteBRL.listaClienteApaterno(txb_DetBusqClient.Text);
                    dgv_ListClient.Columns[0].Visible = false;

                    dgv_ListAutos.Rows.Clear();
                    cargaAutos(cli.IdCliente);
                    break;

                case 2:
                    dgv_ListClient.DataSource = BRL.ClienteBRL.listClienteAmaterno(txb_DetBusqClient.Text);
                    dgv_ListClient.Columns[0].Visible = false;

                    dgv_ListAutos.Rows.Clear();
                    cargaAutos(cli.IdCliente);
                    break;

                case 3:
                    dgv_ListClient.DataSource = BRL.ClienteBRL.listCliCedula(txb_DetBusqClient.Text);
                    dgv_ListClient.Columns[0].Visible = false;

                    dgv_ListAutos.Rows.Clear();
                    cargaAutos(cli.IdCliente);
                    break;  
            }
        }

        private void dgv_ListClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_ListAutos.Rows.Clear();

            cli.IdCliente = Convert.ToInt32(dgv_ListClient.CurrentRow.Cells[0].Value.ToString());
            cargaAutos(cli.IdCliente);

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

                foreach (DataGridViewRow tabla in dgv_ListAutos.Rows)
                {
                    if (tabla.Cells[0].Value != null)
                    {
                        j = Convert.ToInt32(tabla.Cells[0].Value.ToString());
                        BRL.VehiculoBRL.elimVehic(j);
                    }
                }
                dgv_ListAutos.Rows.Clear();
                cargaAutos(cli.IdCliente);

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

        private void DatosComoboBox()
        {
            DataGridViewComboBoxColumn comboboxModelo = dgv_ListAutos.Columns["Modelo"] as DataGridViewComboBoxColumn;
            comboboxModelo.DataSource = BRL.ClienteBRL.ComBoxModelo();
            comboboxModelo.DisplayMember = "Nombre";
            comboboxModelo.ValueMember = "IdModelo";

            DataGridViewComboBoxColumn comboboxTipo = dgv_ListAutos.Columns["Tipo"] as DataGridViewComboBoxColumn;
            comboboxTipo.DataSource = BRL.ClienteBRL.ComBoxTipoVehiculo();
            comboboxTipo.DisplayMember = "Nombre";
            comboboxTipo.ValueMember = "IdTipoVehiculo";
            //comboboxModelo.Value = comboboxModelo.Items[0];asdfasfasdfas
        }

        private void cargaAutos(int idCliente)
        {
            List<DAL.Vehiculo> autos = BRL.VehiculoBRL.listVehic(cli.IdCliente);
            foreach (var item in autos)
            {
                dgv_ListAutos.Rows.Add(item.IdVehiculo, item.Placa, item.TipoVehiculo.IdTipoVehiculo, item.Modelo.IdModelo);
            }
        }

        private void btn_VehicAct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow tabla in dgv_ListAutos.Rows)
            {
                if (tabla.Cells[0].Value != null)
                {
                    vei.IdVehiculo = Convert.ToInt32(tabla.Cells[0].Value.ToString());
                    vei.Placa = tabla.Cells[1].Value.ToString();
                    modelo.IdModelo = Convert.ToInt32(tabla.Cells[3].Value.ToString());
                    vei.Modelo = modelo;
                    tipo.IdTipoVehiculo = Convert.ToInt32(tabla.Cells[2].Value.ToString());
                    vei.TipoVehiculo = tipo;

                    BRL.VehiculoBRL.actualVehi(vei);

                }
            }
            dgv_ListAutos.Rows.Clear();
            cargaAutos(cli.IdCliente);
        }

        private void btn_AgregarVehiculo_Click(object sender, EventArgs e)
        {
            Agregar_Vehiculo agregarVehi = new Agregar_Vehiculo(cli.IdCliente);
            agregarVehi.ShowDialog();
        }

    }
}

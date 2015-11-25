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
    public partial class Agregar_Vehiculo : Form
    {
        Vehiculo vehic = new Vehiculo();
        int idCLiente;

        public Agregar_Vehiculo(int idCliente)
        {
            InitializeComponent();
            idCLiente = idCliente;
            cbx_Modelo.DataSource = BRL.ClienteBRL.ComBoxModelo();
            cbx_Modelo.DisplayMember = "Nombre";
            cbx_Modelo.ValueMember = "IdModelo";

            cbx_Tipo.DataSource = BRL.ClienteBRL.ComBoxTipoVehiculo();
            cbx_Tipo.DisplayMember = "Nombre";
            cbx_Tipo.ValueMember = "IdTipoVehiculo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehic.Placa = txb_Placa.Text;
            vehic.Modelo.IdModelo = Convert.ToInt32(cbx_Modelo.SelectedValue);
            vehic.TipoVehiculo.IdTipoVehiculo = Convert.ToInt32(cbx_Tipo.SelectedValue.ToString());

            BRL.VehiculoBRL.agregarVehic(vehic, idCLiente);
        }
    }
}

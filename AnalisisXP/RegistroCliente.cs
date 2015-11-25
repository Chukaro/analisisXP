using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisXP
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
            DatosComoboBox();
        }

        private void DatosComoboBox()
        {
            DataGridViewComboBoxColumn comboboxModelo = dgvAutos.Columns["Modelo"] as DataGridViewComboBoxColumn;
            comboboxModelo.DataSource = BRL.ClienteBRL.ComBoxModelo();
            comboboxModelo.DisplayMember = "Nombre";
            comboboxModelo.ValueMember = "IdModelo";

            DataGridViewComboBoxColumn comboboxTipo = dgvAutos.Columns["TipoVehiculo"] as DataGridViewComboBoxColumn;
            comboboxTipo.DataSource = BRL.ClienteBRL.ComBoxTipoVehiculo();
            comboboxTipo.DisplayMember = "Nombre";
            comboboxTipo.ValueMember = "IdTipoVehiculo";
            //comboboxModelo.Value = comboboxModelo.Items[0];
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DAL.Vaidacion.validarTxtBox(panel1))
                {
                    DAL.Cliente ingreso = new DAL.Cliente();

                    ingreso.Nombre = txtNombre.Text;
                    ingreso.Paterno = txtPaterno.Text;
                    ingreso.Materno = txtMaterno.Text;
                    ingreso.Cedula = Convert.ToInt32(txtCedula.Text);
                    ingreso.Telefono = Convert.ToInt32(txtTelefono.Text);
                    ingreso.Eliminar = 0;

                    if (dgvAutos.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow item in dgvAutos.Rows)
                        {
                            if (item.Cells[0].Value != null)
                            {
                                DAL.Vehiculo v = new DAL.Vehiculo();

                                v.Placa = item.Cells[0].Value.ToString();
                                v.Modelo.IdModelo = Convert.ToInt32(item.Cells["Modelo"].Value);
                                v.TipoVehiculo.IdTipoVehiculo = Convert.ToInt32(item.Cells["TipoVehiculo"].Value);

                                ingreso.setVehiculo(v);
                            }
                        }
                    }

                    BRL.ClienteBRL.GuardarCliente(ingreso);
                    MessageBox.Show("Datos Agregados");
                    dgvAutos.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Campos requeridos vacios", "ERROR");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error " + ex, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Datos incorrectos", "Error Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Vaidacion.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Vaidacion.SoloNumeros(e);
            ///vgjfhjj
        }

    }
}

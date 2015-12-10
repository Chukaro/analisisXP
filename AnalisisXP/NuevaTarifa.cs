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
    public partial class NuevaTarifa : Form
    {
        public NuevaTarifa()
        {
            InitializeComponent();
            LLenaCmbBoxTipoAuto();
            FilasDvgReserva();
            FilasDvgReservaLibre();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool guardarLibre = true;
            bool guardarReserva = true;
            List<DAL.Tarifa> tarifas = new List<DAL.Tarifa>();

            DateTime fechaHoy = DateTime.Now;

            foreach (DataGridViewRow item in dgvLibre.Rows)
            {
                if (item.Cells[1].Value != null || Convert.ToInt32(item.Cells[1].Value) != 0)
                {
                    DAL.Tarifa t = new DAL.Tarifa();

                    t.CantidadHora = Convert.ToInt32(item.Cells[0].Value);
                    t.Precio = Convert.ToDecimal(item.Cells[1].Value);
                    t.TipoAuto = Convert.ToInt32(item.Cells[2].Value);
                    t.TipoReserva = item.Cells[3].Value.ToString();

                    t.Fecha = fechaHoy;
                    tarifas.Add(t);
                }
                else
                {
                    guardarLibre = false;
                    break;
                }
            }


            foreach (DataGridViewRow item in dgvReserva.Rows)
            {
                if (item.Cells[1].Value != null || Convert.ToInt32(item.Cells[1].Value) != 0)
                {
                    DAL.Tarifa t = new DAL.Tarifa();

                    t.CantidadHora = Convert.ToInt32(item.Cells[0].Value);
                    t.Precio = Convert.ToDecimal(item.Cells[1].Value);
                    t.TipoAuto = Convert.ToInt32(item.Cells[2].Value);
                    t.TipoReserva = item.Cells[3].Value.ToString();

                    t.Fecha = fechaHoy;
                    tarifas.Add(t);
                }
                else
                {
                    guardarReserva = false;
                    break;
                }
            }

            if (guardarLibre && guardarReserva)
            {
                BRL.ClienteBRL.NuevaTarifa(tarifas);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Campo Precio Requerido verificar datos", "ERROR");
                          
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilasDvgReserva()
        {
            dgvReserva.Rows.Add(1, null, 1, "Reserva");
            dgvReserva.Rows.Add(1, null, 2, "Reserva");
        }

        private void LLenaCmbBoxTipoAuto()
        {
            DataGridViewComboBoxColumn comboboxTipo = dgvReserva.Columns["Tipo"] as DataGridViewComboBoxColumn;
            comboboxTipo.DataSource = BRL.ClienteBRL.ComBoxTipoVehiculo();
            comboboxTipo.DisplayMember = "Nombre";
            comboboxTipo.ValueMember = "IdTipoVehiculo";

            DataGridViewComboBoxColumn comboboxTipoLibre = dgvLibre.Columns["TipoL"] as DataGridViewComboBoxColumn;
            comboboxTipoLibre.DataSource = BRL.ClienteBRL.ComBoxTipoVehiculo();
            comboboxTipoLibre.DisplayMember = "Nombre";
            comboboxTipoLibre.ValueMember = "IdTipoVehiculo";
        }

        private void FilasDvgReservaLibre()
        {
            dgvLibre.Rows.Add(1, null, 1, "Libre");
            dgvLibre.Rows.Add(1, null, 2, "Libre");
        }

        private void dgvLibre_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvLibre.CurrentCell.ColumnIndex == 1)
            {
                DataGridViewTextBoxEditingControl txtPrecio = (DataGridViewTextBoxEditingControl)e.Control;
                txtPrecio.KeyPress += new KeyPressEventHandler(txtPrecioLibre_KeyPress);
            }
        }

        private void txtPrecioLibre_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Vaidacion.NumerosDecimales(e, sender);
        }

        private void dgvReserva_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvReserva.CurrentCell.ColumnIndex == 1)
            {
                DataGridViewTextBoxEditingControl txtPrecio = (DataGridViewTextBoxEditingControl)e.Control;
                txtPrecio.KeyPress += new KeyPressEventHandler(txtPrecioReserva_KeyPress);
            }
        }

        private void txtPrecioReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Vaidacion.NumerosDecimales(e, sender);
        }

    }
}

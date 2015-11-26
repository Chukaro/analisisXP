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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<DAL.Tarifa> tarifas = new List<DAL.Tarifa>();

            DateTime fechaHoy = DateTime.Now;

            if (dgvTarifa.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dgvTarifa.Rows)
                {
                    if (item.Cells[0].Value != null)
                    {
                        DAL.Tarifa t = new DAL.Tarifa();

                        t.Precio = Convert.ToDecimal(item.Cells[0].Value.ToString());
                        t.TipoReserva = item.Cells[1].Value.ToString();
                        t.Fecha = fechaHoy;
                        tarifas.Add(t);
                    }
                }

                BRL.ClienteBRL.NuevaTarifa(tarifas);
                dgvTarifa.Rows.Clear();

            }
            else
            {
                MessageBox.Show("Campos vacios", "ERROR");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTarifa_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvTarifa.CurrentCell.ColumnIndex == 0)
            {
                DataGridViewTextBoxEditingControl txtPrecio = (DataGridViewTextBoxEditingControl)e.Control;
                txtPrecio.KeyPress += new KeyPressEventHandler(txtPrecio_KeyPress);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            DAL.Vaidacion.NumerosDecimales(e, sender);
        }

    }
}

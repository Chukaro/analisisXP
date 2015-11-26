using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisXP
{
    public partial class BuscarTarifa : UserControl
    {
        public BuscarTarifa()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            if (dtpFin.Value.CompareTo(fechaHoy) <= 0 && dtpInicio.Value.CompareTo(fechaHoy) <= 0)
            {
                ResultadoTarifa();

            }
            else
                MessageBox.Show("Fecha fuera de rango", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResultadoTarifa()
        {
            List<DAL.Tarifa> tarifas = BRL.ClienteBRL.BuscarTarifa(dtpInicio.Value, dtpFin.Value);

            foreach (var item in tarifas)
            {
                this.dgvResultado.Rows.Add(String.Format("{0:0.00}", item.Precio), item.TipoReserva, item.Fecha);
            }
        }
    }
}

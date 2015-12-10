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
    public partial class RegistroEstacionamiento : Form
    {
        private Alquiler alq = new Alquiler();
        private DateTime x = DateTime.Now;
        DateTime thisDay = DateTime.Today;
        private String posicion;

        public RegistroEstacionamiento(String pos)
        {
            InitializeComponent();
            posicion = pos;
            dtp_HoraInicio.ShowUpDown = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            alq.FechaInicio = String.Format("{0:dd/MM/yy HH:mm:ss}", thisDay);
            alq.HoraInicio = "" + x.Hour + ":" + x.Minute + ":" + x.Second;
            alq.Placa = txb_Placa.Text;
            alq.Posicion = posicion;
            alq.Observacion = txb_Oservacion.Text;
            alq.Tarifa_IdTarifa = 1;

            BRL.AlquilerBRL.insertarAlquiler(alq);
        }

        private void btnCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}


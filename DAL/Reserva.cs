using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Reserva
    {
        private int idReserva;
        private DateTime fecha_I;
        private DateTime fecha_F;
        private int idTarifa;
        private int idCliente;
        private List<DetalleReserva> reservaCliente;

        public Reserva()
        {
            reservaCliente = new List<DetalleReserva>();
        }

        public int IdReserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }

        public DateTime Fecha_I
        {
            get { return fecha_I; }
            set { fecha_I = value; }
        }

        public DateTime Fecha_F
        {
            get { return fecha_F; }
            set { fecha_F = value; }
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public int IdTarifa
        {
            get { return idTarifa; }
            set { idTarifa = value; }
        }

        public void setReservaCliente(DetalleReserva dr)
        {
            reservaCliente.Add(dr);
        }

        public List<DetalleReserva> getReservaCliente()
        {
            return reservaCliente;
        }
    }
}

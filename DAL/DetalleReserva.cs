using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetalleReserva
    {
        private int idDetalleReserva;
        private string placa;
        private int idTipoVehiculo;
        private string hora_I;
        private string hora_F;
        private int idPosicion;
        private int idReserva;

        public int IdReserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }

        public int IdDetalleReserva
        {
            get { return idDetalleReserva; }
            set { idDetalleReserva = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public int IdTipoVehiculo
        {
            get { return idTipoVehiculo; }
            set { idTipoVehiculo = value; }
        }

        public string Hora_I
        {
            get { return hora_I; }
            set { hora_I = value; }
        }

        public string Hora_F
        {
            get { return hora_F; }
            set { hora_F = value; }
        }

        public int IdPosicion
        {
            get { return idPosicion; }
            set { idPosicion = value; }
        }
    }
}

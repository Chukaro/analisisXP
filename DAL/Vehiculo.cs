using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Vehiculo
    {
        private int idVehiculo;
        private string placa;
        private TipoVehiculo tipoVehiculo;
        private Modelo modelo;

        public int IdVehiculo
        {
            get { return idVehiculo; }
            set { idVehiculo = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public Modelo Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public TipoVehiculo TipoVehiculo
        {
            get { return tipoVehiculo; }
            set { tipoVehiculo = value; }
        }

    }
}

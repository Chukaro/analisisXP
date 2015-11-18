using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TipoVehiculo
    {
        private int idTipoVehiculo;
        private string nombre;

        public int IdTipoVehiculo
        {
            get { return idTipoVehiculo; }
            set { idTipoVehiculo = value; }
        }
      
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}

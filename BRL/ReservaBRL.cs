using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRL
{
    public class ReservaBRL
    {
        public static DAL.Tarifa TarifaActualReserva()
        {
            return DAL.Referencias.tarifaActualReserva();
        }

        public static List<DAL.Espacio> EspacioDisponible()
        {
            return DAL.Referencias.espacioDisponible();
        }
        
    }
}

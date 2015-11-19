using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRL
{
    public class ClienteBRL
    {
        public static List<DAL.Modelo> ComBoxModelo()
        {
            return DAL.Referencias.comBoxModelo();
        }

        public static List<DAL.TipoVehiculo> ComBoxTipoVehiculo()
        {
            return DAL.Referencias.comBoxTipoVehiculo();
        }

        public static void GuardarCliente(DAL.Cliente cliente)
        {
            DAL.ClienteList.guardarCliente(cliente);
        }
    }
}

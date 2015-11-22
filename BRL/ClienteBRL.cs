using System;
using System.Collections.Generic;
using System.Data;
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

        #region Busqueda

        public static DataTable listaCliente()
        {
            return DAL.ClienteList.listaCliente();
        }

        public static DataTable listaClientNombre(String nombre)
        {
            return DAL.ClienteList.listaClientNombre(nombre);
        }

        public static DataTable listaClienteApaterno(String paterno)
        {
            return DAL.ClienteList.listaClienteApaterno(paterno);
        }

        public static DataTable listClienteAmaterno(String materno)
        {
            return DAL.ClienteList.listClienteAmaterno(materno);
        }

        public static DataTable listCliCedula(String cedula)
        {
            return DAL.ClienteList.listCliCedula(cedula);
        }

        #endregion

    }
}

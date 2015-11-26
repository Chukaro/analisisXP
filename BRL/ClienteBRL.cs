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
        #region ComboBox
        public static List<DAL.Modelo> ComBoxModelo()
        {
            return DAL.Referencias.comBoxModelo();
        }

        public static List<DAL.TipoVehiculo> ComBoxTipoVehiculo()
        {
            return DAL.Referencias.comBoxTipoVehiculo();
        }
        #endregion

        #region Inseratr
        public static void GuardarCliente(DAL.Cliente cliente)
        {
            DAL.ClienteList.guardarCliente(cliente);
        }
        #endregion

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

        #region Eliminar
        public static void elimClient(int idClient)
        {
            DAL.Cliente.elimClient(idClient);
        }
        #endregion

        #region Actualizar
        public static void actClient(int idCliente, String nombre, String paterno, String materno, String cedula, String telefono)
        {
            DAL.Cliente.actualizClient(idCliente, nombre, paterno, materno, cedula, telefono);
        }
        #endregion

        #region tarifa
        public static void NuevaTarifa(List<DAL.Tarifa> nueva)
        {
            DAL.Tarifa.nuevaTarifa(nueva);
        }

        public static List<DAL.Tarifa> BuscarTarifa(DateTime inico, DateTime fin)
        {
            return DAL.Tarifa.buscarTarifa(inico, fin);
        }
        #endregion
    }
}

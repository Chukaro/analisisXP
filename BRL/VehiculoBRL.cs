using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRL
{
    public class VehiculoBRL
    {
        public static List<DAL.Vehiculo> listVehic(int idCliente)
        {
            return DAL.Vehiculo.listVehiculo(idCliente);
        }

        public static void elimVehic(int idVehic)
        {
            DAL.Vehiculo.elimVehic(idVehic);
        }

        public static void actualVehi(Vehiculo vei)
        {
            DAL.Vehiculo.actVehic(vei);
        }

        public static void agregarVehic(Vehiculo vehic, int idCLient)
        {
            DAL.Vehiculo.agregarVehic(vehic, idCLient);
        }
    }
}

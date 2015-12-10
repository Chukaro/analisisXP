using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRL
{
    public class AlquilerBRL
    {
        public static void insertarAlquiler(Alquiler alq)
        {
            DAL.Alquiler.insertarAlquiler(alq);
        }

        public static void actualizarAlquilerCompleto(DateTime fechaFin, String horaFin)
        {
            DAL.Alquiler.actualizarAlquilerCompleto(fechaFin, horaFin);
        }

        public static Alquiler busquedaporPlaca(String placa)
        {
            return DAL.Alquiler.buscarPorPlaca(placa);
        }
    }
}

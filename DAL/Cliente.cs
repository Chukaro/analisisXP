using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cliente
    {
        private int idCliente;
        private int telefono;
        private string nombre;
        private string paterno;
        private string materno;
        private int cedula;
        private List<Vehiculo> vehiculo;

        public Cliente()
        {
            vehiculo = new List<Vehiculo>();
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Paterno
        {
            get { return paterno; }
            set { paterno = value; }
        }

        public string Materno
        {
            get { return materno; }
            set { materno = value; }
        }

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public void setVehiculo(Vehiculo v)
        {
            vehiculo.Add(v);
        }

        public List<Vehiculo> getVehiculo()
        {
            return vehiculo;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        #region Metodos
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
        #endregion

        #region Eliminar
        public static void elimClient(int idClient)
        {
            // Proporciona la cadena de conexion a base de datos desde el archivo de configuracion
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            // Proporcionar la cadena de consulta 
            string consulta1 = "update dbo.Cliente Set Eliminar = 1 where idCliente = @id";


            // Crear y abrir la conexión en un bloque using. 
            // Esto asegura que todos los recursos serán cerrados 
            // y dispuestos cuando el código sale 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el objeto Command.
                //consulta para realizar la insercion de un telefono

                SqlCommand command = new SqlCommand(consulta1, connection);
                command.Parameters.AddWithValue("@id", idClient);
                // Abre la conexión en un bloque try / catch. 
                // Crear y ejecutar el DataReader, escribiendo 
                // el conjunto de resultados a la ventana de la consola.
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
        #endregion

        #region Actualizar
        public static void actualizClient(int idCliente, String nombre, String paterno, String materno, String cedula, String telefono)
        {
            // Proporciona la cadena de conexion a base de datos desde el archivo de configuracion
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            // Proporcionar la cadena de consulta 
            string consulta2 = "update dbo.Cliente Set Nombre = @nomb, Paterno = @patern, Materno = @matern, Cedula = @cedu, Telefono = @telf where idCliente = @id";


            // Crear y abrir la conexión en un bloque using. 
            // Esto asegura que todos los recursos serán cerrados 
            // y dispuestos cuando el código sale 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el objeto Command.
                //consulta para realizar la insercion de un telefono

                SqlCommand command = new SqlCommand(consulta2, connection);
                command.Parameters.AddWithValue("@id", idCliente);
                command.Parameters.AddWithValue("@nomb", nombre);
                command.Parameters.AddWithValue("@patern", paterno);
                command.Parameters.AddWithValue("@matern", materno);
                command.Parameters.AddWithValue("@cedu", cedula);
                command.Parameters.AddWithValue("@telf", telefono);
                // Abre la conexión en un bloque try / catch. 
                // Crear y ejecutar el DataReader, escribiendo 
                // el conjunto de resultados a la ventana de la consola.
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
        #endregion
    }
}

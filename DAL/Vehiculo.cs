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
    public class Vehiculo
    {
        private int idVehiculo;
        private string placa;
        private TipoVehiculo tipoVehiculo;
        private Modelo modelo;

        public Vehiculo()
        {
            tipoVehiculo = new TipoVehiculo();
            modelo = new Modelo();
        }
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

        #region Lista
        public static DataTable listVehic(int idClient)
        {
            DataTable vehicList = new DataTable();

            // Proporciona la cadena de conexion a base de datos desde el archivo de configuracion
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            // Crear y abrir la conexión en un bloque using. 
            // Esto asegura que todos los recursos serán cerrados 
            // y dispuestos cuando el código sale 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el objeto Command.
                SqlCommand command = new SqlCommand("[PA_ListaVehic]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("idClient", idClient);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    SqlDataAdapter tableAdapter = new SqlDataAdapter(command);

                    tableAdapter.Fill(vehicList);
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
            return vehicList;
        }
        #endregion

        #region Eliminar
        public static void elimVehic(int idVehic)
        {
            // Proporciona la cadena de conexion a base de datos desde el archivo de configuracion
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            // Proporcionar la cadena de consulta 
            string consulta1 = "update dbo.Vehiculo Set Eliminar = 1 where idVehiculo = @id";


            // Crear y abrir la conexión en un bloque using. 
            // Esto asegura que todos los recursos serán cerrados 
            // y dispuestos cuando el código sale 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el objeto Command.
                //consulta para realizar la insercion de un telefono

                SqlCommand command = new SqlCommand(consulta1, connection);
                command.Parameters.AddWithValue("@id", idVehic);
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

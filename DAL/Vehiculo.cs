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

        #region Metodos
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
        #endregion

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

        public static List<Vehiculo> listVehiculo(int idClient)
        {
            List<Vehiculo> vehiculoList = new List<Vehiculo>();

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
                    SqlDataReader reader =  command.ExecuteReader();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Vehiculo v = new Vehiculo();
                            v.IdVehiculo = reader.GetInt32(0);
                            v.Placa = reader[1].ToString();
                            v.TipoVehiculo.IdTipoVehiculo = reader.GetInt32(2);
                            v.Modelo.IdModelo = reader.GetInt32(3);

                            vehiculoList.Add(v);
                        }
                        reader.NextResult();
                    }

                    
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
            return vehiculoList;
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

        #region Actualizar
        public static void actVehic(Vehiculo vei)
        {
            // Proporciona la cadena de conexion a base de datos desde el archivo de configuracion
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            // Proporcionar la cadena de consulta 
            string consulta2 = "update dbo.Vehiculo Set Placa = @placa, Modelo_IdModelo = @modelo, TipoVehiculo_IdTipo = @tipo where IdVehiculo = @id";


            // Crear y abrir la conexión en un bloque using. 
            // Esto asegura que todos los recursos serán cerrados 
            // y dispuestos cuando el código sale 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el objeto Command.
                //consulta para realizar la insercion de un telefono

                SqlCommand command = new SqlCommand(consulta2, connection);
                command.Parameters.AddWithValue("@id", vei.idVehiculo);
                command.Parameters.AddWithValue("@placa", vei.placa);
                command.Parameters.AddWithValue("@modelo", vei.modelo.IdModelo);
                command.Parameters.AddWithValue("@tipo", vei.tipoVehiculo.IdTipoVehiculo);
                // Abre la conexión en un bloque try / catch. 
                // Crear y ejecutar el DataReader, escribiendo 
                // el conjunto de resultados a la ventana de la consola.sefasdf
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

        #region Agregar
        public static void agregarVehic(Vehiculo vei, int idCli)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            string consulta2 = "INSERT INTO dbo.Vehiculo (Placa, Cliente_IdCliente, Modelo_IdModelo, TipoVehiculo_IdTipo, Eliminar) VALUES (@placa, @idCli, @modelo, @tipo, 0) ";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta2, connection);
                //command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@placa", vei.Placa);
                command.Parameters.AddWithValue("@modelo", vei.Modelo.IdModelo);
                command.Parameters.AddWithValue("@tipo", vei.TipoVehiculo.IdTipoVehiculo);
                command.Parameters.AddWithValue("@idCli", idCli);


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

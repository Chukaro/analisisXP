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
    public class ClienteList
    {
        public static void guardarCliente(Cliente cliente) 
        {
            int idCliente = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("PDB_guardarCliente", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("nombre", cliente.Nombre);
                command.Parameters.AddWithValue("paterno", cliente.Paterno);
                command.Parameters.AddWithValue("materno", cliente.Materno);
                command.Parameters.AddWithValue("cedula", cliente.Cedula);
                command.Parameters.AddWithValue("telefono", cliente.Telefono);
                command.Parameters.AddWithValue("eliminado", cliente.Eliminar);



                command.Parameters.AddWithValue("idCliente", 0);
                command.Parameters["idCliente"].Direction = ParameterDirection.Output;
                try
                {
                    connection.Open();
                    SqlTransaction trato = connection.BeginTransaction();
                    command.Transaction = trato;

                    int fila = command.ExecuteNonQuery();


                    if (fila != 0)
                    {
                        idCliente = Convert.ToInt32(command.Parameters["idCliente"].Value);

                        foreach (Vehiculo item in cliente.getVehiculo())
                        {
                            SqlCommand commandVehiculo = new SqlCommand("PDB_grabarVehiculo", connection);
                            commandVehiculo.CommandType = CommandType.StoredProcedure;

                            commandVehiculo.Parameters.AddWithValue("placa", item.Placa);
                            commandVehiculo.Parameters.AddWithValue("idCliente", idCliente);
                            commandVehiculo.Parameters.AddWithValue("modelo", item.Modelo.IdModelo);
                            commandVehiculo.Parameters.AddWithValue("tipo", item.TipoVehiculo.IdTipoVehiculo);

                            commandVehiculo.Transaction = trato;
                            fila = commandVehiculo.ExecuteNonQuery();

                            if (fila != 0)
                            {
                                fila = 1;
                            }
                            else
                            {
                                fila = 0;
                                return;
                            }
                        }
                    }

                    if (fila != 0)
                    {
                        trato.Commit();
                    }
                    else
                    {
                        trato.Rollback();
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
        }

        #region Busqueda

        public static DataTable listaCliente()
        {

            DataTable clientlist = new DataTable();

            // Proporciona la cadena de conexion a base de datos desde el archivo de configuracion
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            // Crear y abrir la conexión en un bloque using. 
            // Esto asegura que todos los recursos serán cerrados 
            // y dispuestos cuando el código sale 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el objeto Command.
                SqlCommand command = new SqlCommand("[PA_BusqClient]", connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    SqlDataAdapter tableAdapter = new SqlDataAdapter(command);

                    tableAdapter.Fill(clientlist);
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
            return clientlist;

        }

        public static DataTable listaClientNombre(String nombre)
        {
            DataTable clienteNombusqueda = new DataTable();

            // Proporciona la cadena de conexion a base de datos desde el archivo de configuracion
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            // Crear y abrir la conexión en un bloque using. 
            // Esto asegura que todos los recursos serán cerrados 
            // y dispuestos cuando el código sale 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el objeto Command.
                SqlCommand command = new SqlCommand("[PA_BusqClientNom]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("nombre", nombre);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    SqlDataAdapter tableAdapter = new SqlDataAdapter(command);

                    tableAdapter.Fill(clienteNombusqueda);
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
            return clienteNombusqueda;
        }

        public static DataTable listaClienteApaterno(String paterno)
        {
            DataTable clientApaternobusqueda = new DataTable();

            // Proporciona la cadena de conexion a base de datos desde el archivo de configuracion
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            // Crear y abrir la conexión en un bloque using. 
            // Esto asegura que todos los recursos serán cerrados 
            // y dispuestos cuando el código sale 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el objeto Command.
                SqlCommand command = new SqlCommand("[PA_BusqClientApaterno]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("paterno", paterno);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    SqlDataAdapter tableAdapter = new SqlDataAdapter(command);

                    tableAdapter.Fill(clientApaternobusqueda);
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
            return clientApaternobusqueda;
        }

        public static DataTable listClienteAmaterno(String materno)
        {
            DataTable clientAmaternobusqueda = new DataTable();

            // Proporciona la cadena de conexion a base de datos desde el archivo de configuracion
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            // Crear y abrir la conexión en un bloque using. 
            // Esto asegura que todos los recursos serán cerrados 
            // y dispuestos cuando el código sale 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el objeto Command.
                SqlCommand command = new SqlCommand("[PA_BusqClientAmaterno]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("materno", materno);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    SqlDataAdapter tableAdapter = new SqlDataAdapter(command);

                    tableAdapter.Fill(clientAmaternobusqueda);
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
            return clientAmaternobusqueda;
        }

        public static DataTable listCliCedula(String cedula)
        {
            DataTable clientCedulabusqueda = new DataTable();

            // Proporciona la cadena de conexion a base de datos desde el archivo de configuracion
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            // Crear y abrir la conexión en un bloque using. 
            // Esto asegura que todos los recursos serán cerrados 
            // y dispuestos cuando el código sale 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el objeto Command.
                SqlCommand command = new SqlCommand("[PA_BusqClientCedula]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("cedula", cedula);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    SqlDataAdapter tableAdapter = new SqlDataAdapter(command);

                    tableAdapter.Fill(clientCedulabusqueda);
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
            return clientCedulabusqueda;
        }
        #endregion

        public static List<Cliente> clientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("PDB_listaClientes", connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cliente c = new Cliente();

                            c.IdCliente = reader.GetInt32(0);
                            c.Nombre = reader.GetString(1);

                            listaClientes.Add(c);
                        }
                        reader.NextResult();
                    }
                    reader.Close();
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
            return listaClientes;
        }
    }
}

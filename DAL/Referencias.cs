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
    public class Referencias
    {
        public static List<TipoVehiculo> comBoxTipoVehiculo()
        {
            List<TipoVehiculo> lista = new List<TipoVehiculo>();

            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("PBD_cmboxTipoVehiculo", connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TipoVehiculo tipo = new TipoVehiculo();

                            tipo.IdTipoVehiculo = reader.GetInt32(0);
                            tipo.Nombre = reader.GetString(1);

                            lista.Add(tipo);
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
            return lista;
        }

        public static List<Modelo> comBoxModelo()
        {
            List<Modelo> lista = new List<Modelo>();

            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("PBD_cmboxModelo", connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
               
                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Modelo modelo = new Modelo();

                            modelo.IdModelo = reader.GetInt32(0);
                            modelo.Nombre = reader.GetString(1);

                            lista.Add(modelo);
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
            return lista;
        }

        //nuevo Funcion
        public static List<Tarifa> comBoxTarifa()
        {
            List<Tarifa> lista = new List<Tarifa>();

            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("PDB_horasReserva", connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Tarifa t = new Tarifa();

                            t.CantidadHora = reader.GetInt16(0);
                            t.Precio = reader.GetDecimal(1);
                            
                            lista.Add(t);
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
            return lista;
        }

        public static Tarifa tarifaActualReserva()
        {
            Tarifa precio = new Tarifa();
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("PDB_TarifaActual", connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            precio.IdTarifa = reader.GetInt32(0);
                            precio.Precio = reader.GetDecimal(1);
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
            return precio;
        }


        public static List<Espacio> espacioDisponible()
        {
            List<Espacio> espacios = new List<Espacio>();
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("PDB_Posicion", connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Espacio libre = new Espacio();
                            libre.IdEspacio = reader.GetInt32(0);

                            espacios.Add(libre);
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

            return espacios;
        }
    }
}

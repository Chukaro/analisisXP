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
    }
}

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
    public class ReservaList
    {
        public static void guardarReserva(Reserva reserva)
        {
            int idReserva = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("", reserva.Fecha_I);
                command.Parameters.AddWithValue("", reserva.Fecha_F);
                command.Parameters.AddWithValue("", reserva.IdTarifa);
                command.Parameters.AddWithValue("", reserva.IdCliente);

                command.Parameters["idReserva"].Direction = ParameterDirection.Output;
                try
                {
                    connection.Open();
                    SqlTransaction trato = connection.BeginTransaction();
                    command.Transaction = trato;

                    int fila = command.ExecuteNonQuery();


                    if (fila != 0)
                    {
                        idReserva = Convert.ToInt32(command.Parameters["idReserva"].Value);

                        foreach (var item in reserva.getReservaCliente())
                        {
                            SqlCommand commandVehiculo = new SqlCommand("", connection);
                            commandVehiculo.CommandType = CommandType.StoredProcedure;

                            commandVehiculo.Parameters.AddWithValue("", item.Hora_I);
                            commandVehiculo.Parameters.AddWithValue("", item.Hora_F);
                            commandVehiculo.Parameters.AddWithValue("", item.Placa);
                            commandVehiculo.Parameters.AddWithValue("", item.IdTipoVehiculo);
                            commandVehiculo.Parameters.AddWithValue("", item.IdPosicion);
                            commandVehiculo.Parameters.AddWithValue("", idReserva);

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

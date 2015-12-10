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
    public class Tarifa
    {
        private int idTarifa;
        private int cantidadHora;
        private decimal precio;
        private int tipoAuto;
        private string tipoReserva;
        private DateTime fecha;

        public int CantidadHora
        {
            get { return cantidadHora; }
            set { cantidadHora = value; }
        }

        public int TipoAuto
        {
            get { return tipoAuto; }
            set { tipoAuto = value; }
        }

        public int IdTarifa
        {
            get { return idTarifa; }
            set { idTarifa = value; }
        }
        
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string TipoReserva
        {
            get { return tipoReserva; }
            set { tipoReserva = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public static void nuevaTarifa(List<Tarifa> nueva)
        {
            int fila = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlTransaction trato = connection.BeginTransaction();

                    foreach (var item in nueva)
                    {
                        SqlCommand command = new SqlCommand("PDB_nuevaTarifa", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Transaction = trato;

                        command.Parameters.AddWithValue("cantHora", item.CantidadHora);
                        command.Parameters.AddWithValue("precio", item.Precio);
                        command.Parameters.AddWithValue("tipo", item.TipoAuto);
                        command.Parameters.AddWithValue("fecha", item.Fecha);
                        command.Parameters.AddWithValue("tipoReserva", item.TipoReserva);

                        command.Transaction = trato;
                        fila = command.ExecuteNonQuery();

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

        public static List<Tarifa> buscarTarifa(DateTime inicio, DateTime fin)
        {
            List<Tarifa> tarifas = new List<Tarifa>();

            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("PDB_buscarTarifa", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("inicio", inicio);
                command.Parameters.AddWithValue("fin", fin);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Tarifa t = new Tarifa();

                            t.Precio = reader.GetDecimal(0);
                            t.TipoReserva = reader.GetString(1);
                            t.Fecha = reader.GetDateTime(2);

                            tarifas.Add(t);
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
            return tarifas;
        }

    }
}

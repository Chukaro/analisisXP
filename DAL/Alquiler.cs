using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Alquiler
    {
        private int Id;
        private Double precio;


        private String fechaInicio;
        private TimeSpan hora_Inic;

        public TimeSpan Hora_Inic
        {
            get { return hora_Inic; }
            set { hora_Inic = value; }
        }
        private DateTime fechaFin;
        private String horaInicio;
        private String horaFin;
        private String placa;
        private String posicion;
        private String observacion;
        private int tarifa_IdTarifa;

        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }

        public Double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public String FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public String HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        public String HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }


        }

        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public String Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        public String Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        public int Tarifa_IdTarifa
        {
            get { return tarifa_IdTarifa; }
            set { tarifa_IdTarifa = value; }
        }


        public static void insertarAlquiler(Alquiler alq)
        {
            //string Time = "16:23:01"; 
            //DateTime date = DateTime.ParseExact(Time, "hh:mm:ss tt", System.Globalization.CultureInfo.CurrentCulture);
            //DateTime date = DateTime.ParseExact(Time, "HH:mm:ss",CultureInfo.InvariantCulture);

            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            //string consulta2 = "INSERT INTO dbo.Alquler (Fecha_I, Fecha_F, Hora_I, Hora_F, Placa, Posicion, Obsevacion, Tarifa_IdTarifa) VALUES (@fechaInic, @fechaFin, @horaIni, @horaFin, @placa, @posicion, @observacion, @tarifaId) ";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("insertarAlquiler", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("fechaInic", alq.FechaInicio);
                //command.Parameters.AddWithValue("fechaFin", "NULL");
                command.Parameters.AddWithValue("horaInic", alq.horaInicio);
                //command.Parameters.AddWithValue("horaFin", "NULL");
                command.Parameters.AddWithValue("placa", alq.Placa);
                command.Parameters.AddWithValue("posicion", alq.Posicion);
                command.Parameters.AddWithValue("observacion", alq.Observacion);
                command.Parameters.AddWithValue("tarifaId", alq.Tarifa_IdTarifa);

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

        public static void actualizarAlquilerCompleto(DateTime fechaFin, String horaFin)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            string consulta2 = "UPDATE dbo.Alaquiler  SET Fecha_F=@fechaFin, Hora_F=@horaFin ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta2, connection);
                //command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@fechaFin", fechaFin);
                command.Parameters.AddWithValue("@horaFin", horaFin);

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

        public static Alquiler buscarPorPlaca(String placa)
        {
            Alquiler alq = new Alquiler();

            string connectionString = ConfigurationManager.ConnectionStrings["ParkeoConnString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("PA_cuentaVehiculo", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@placa", placa);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            alq.Id1 = reader.GetInt32(0);
                            alq.Placa = reader.GetString(1);
                            alq.Hora_Inic = reader.GetTimeSpan(2);
                            alq.Posicion = reader.GetString(3);
                            alq.Precio = reader.GetDouble(4);
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
            return alq;
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisXP
{
    public partial class Reservacion : Form
    {
        private DateTimePicker timePickerInicio;
        private DateTimePicker timePickerFin;
        private DAL.Tarifa tarifa = BRL.ReservaBRL.TarifaActualReserva();

        public Reservacion()
        {
            InitializeComponent();
            llenarCmBox();
            DatosComoboBox();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarCmBox()
        {
            cmboxCliente.DataSource = BRL.ClienteBRL.Clientes();
            cmboxCliente.DisplayMember = "Nombre";
            cmboxCliente.ValueMember = "IdCliente";
        }

        private void cmboxCliente_SelectedValueChanged(object sender, EventArgs e)
        {

            string idCliente = cmboxCliente.SelectedValue.ToString();
            List<DAL.Vehiculo> autos = BRL.VehiculoBRL.listVehic(Convert.ToInt32(idCliente));
            foreach (var item in autos)
            {
                dgvAutos.Rows.Add(item.IdVehiculo, item.Placa, item.TipoVehiculo.IdTipoVehiculo, null, null);
            }
        }

        private void DatosComoboBox()
        {
            DataGridViewComboBoxColumn comboboxTipo = dgvAutos.Columns["Tipo"] as DataGridViewComboBoxColumn;
            comboboxTipo.DataSource = BRL.ClienteBRL.ComBoxTipoVehiculo();
            comboboxTipo.DisplayMember = "Nombre";
            comboboxTipo.ValueMember = "IdTipoVehiculo";

            DataGridViewComboBoxColumn comboboxEspacio = dgvAutos.Columns["Posicion"] as DataGridViewComboBoxColumn;
            comboboxEspacio.DataSource = BRL.ReservaBRL.EspacioDisponible();
            comboboxEspacio.DisplayMember = "IdEspacio";
            comboboxEspacio.ValueMember = "IdEspacio";
        }

        private void cmboxCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show("Campo Precio Requerido verificar datos  " + cmboxCliente.SelectedValue, "ERROR");
            string idCliente = cmboxCliente.SelectedValue.ToString();

            List<DAL.Vehiculo> autos = BRL.VehiculoBRL.listVehic(Convert.ToInt32(idCliente));
            foreach (var item in autos)
            {
                dgvAutos.Rows.Add(item.IdVehiculo, item.Placa, item.TipoVehiculo.IdTipoVehiculo, null);
            }
        }

        private void dgvAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                //Initialized a new DateTimePicker Control  
                timePickerInicio = new DateTimePicker();

                //Adding DateTimePicker control into DataGridView   
                dgvAutos.Controls.Add(timePickerInicio);

                // Setting the format (i.e. 2014-10-10)  
                timePickerInicio.Format = DateTimePickerFormat.Time;

                timePickerInicio.ShowUpDown = true;

                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = dgvAutos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                timePickerInicio.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                timePickerInicio.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                timePickerInicio.CloseUp += new EventHandler(timePickerInicio_CloseUp);

                // An event attached to dateTimePicker Control which is fired when any date is selected  
                timePickerInicio.TextChanged += new EventHandler(timePickerInicio_OnTextChange);

                // Now make it visible  
                timePickerInicio.Visible = true;
            }

            if (e.ColumnIndex == 4)
            {
                //Initialized a new DateTimePicker Control  
                timePickerFin = new DateTimePicker();

                //Adding DateTimePicker control into DataGridView   
                dgvAutos.Controls.Add(timePickerFin);

                // Setting the format (i.e. 2014-10-10)  
                timePickerFin.Format = DateTimePickerFormat.Time;

                timePickerFin.ShowUpDown = true;

                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = dgvAutos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                timePickerFin.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                timePickerFin.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                timePickerFin.CloseUp += new EventHandler(timePickerFin_CloseUp);

                // An event attached to dateTimePicker Control which is fired when any date is selected  
                timePickerFin.TextChanged += new EventHandler(timePickerFin_OnTextChange);

                // Now make it visible  
                timePickerFin.Visible = true;
            } 
        }

        private void timePickerInicio_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            dgvAutos.CurrentCell.Value = timePickerInicio.Text.ToString();
        }

        private void timePickerInicio_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use   
            timePickerInicio.Visible = false;
        }

        private void timePickerFin_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            dgvAutos.CurrentCell.Value = timePickerFin.Text.ToString();
        }

        private void timePickerFin_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use   
            timePickerFin.Visible = false;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //DateTime fechaHoy = DateTime.Now;
            //MessageBox.Show("Campo   " + fechaHoy, "ERROR");
            try
            {
                
                //tarifa.Precio += 20;
                //MessageBox.Show("Campo   " + tarifa.Precio + "   " + tarifa.IdTarifa, "ERROR");

                DAL.Reserva reservea = new DAL.Reserva();

                reservea.Fecha_I = dtpInicio.Value;
                reservea.Fecha_F = dtpFin.Value;
                reservea.IdCliente = Convert.ToInt32(cmboxCliente.SelectedValue);
                reservea.IdTarifa = tarifa.IdTarifa;

                foreach (DataGridViewRow item in dgvAutos.Rows)
                {
                    if (item.Cells[6].Value != null || Convert.ToInt32(item.Cells[6].Value) != 0)
                    {
                        DAL.DetalleReserva detalle = new DAL.DetalleReserva();

                        detalle.Placa = item.Cells[0].Value.ToString();
                        detalle.IdTipoVehiculo = Convert.ToInt32(item.Cells[1].Value);
                        detalle.Hora_I = item.Cells[2].Value.ToString();
                        detalle.Hora_F = item.Cells[3].Value.ToString();
                        detalle.IdPosicion = Convert.ToInt32(item.Cells[4].Value);

                        reservea.setReservaCliente(detalle);
                    }
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

        private void dgvAutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DateTime hora1 = Convert.ToDateTime(dgvAutos.Rows[e.RowIndex].Cells[3].Value);

                DateTime hora2 = Convert.ToDateTime(dgvAutos.Rows[e.RowIndex].Cells[4].Value);

                //string dato = dgvAutos.Rows[e.RowIndex].Cells[3].Value.ToString();

                TimeSpan diferencia = hora1 - hora2;//hora2.Substract(hora1);
                int hora = diferencia.Hours;

                MessageBox.Show("Campo  " + hora, "ERROR");
            }
        }

    }
}

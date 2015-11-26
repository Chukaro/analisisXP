namespace AnalisisXP
{
    partial class BuscarCliente
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.cbx_TipoClient = new System.Windows.Forms.ComboBox();
            this.txb_DetBusqClient = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ListClient = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ListAutos = new System.Windows.Forms.DataGridView();
            this.IdAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ClientAct = new System.Windows.Forms.Button();
            this.btn_VehicElim = new System.Windows.Forms.Button();
            this.btn_ClientElim = new System.Windows.Forms.Button();
            this.btn_VehicAct = new System.Windows.Forms.Button();
            this.btn_AgregarVehiculo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListClient)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListAutos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn_BuscarCliente);
            this.panel1.Controls.Add(this.cbx_TipoClient);
            this.panel1.Controls.Add(this.txb_DetBusqClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 54);
            this.panel1.TabIndex = 0;
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.BackColor = System.Drawing.Color.LightGreen;
            this.btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarCliente.Location = new System.Drawing.Point(699, 9);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(160, 30);
            this.btn_BuscarCliente.TabIndex = 2;
            this.btn_BuscarCliente.Text = "Buscar";
            this.btn_BuscarCliente.UseVisualStyleBackColor = false;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            // 
            // cbx_TipoClient
            // 
            this.cbx_TipoClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_TipoClient.DisplayMember = "0";
            this.cbx_TipoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TipoClient.FormattingEnabled = true;
            this.cbx_TipoClient.Items.AddRange(new object[] {
            "Nombre",
            "Apellido Paterno",
            "Apellido Materno",
            "Cedula de identidad"});
            this.cbx_TipoClient.Location = new System.Drawing.Point(258, 13);
            this.cbx_TipoClient.Name = "cbx_TipoClient";
            this.cbx_TipoClient.Size = new System.Drawing.Size(219, 24);
            this.cbx_TipoClient.TabIndex = 1;
            // 
            // txb_DetBusqClient
            // 
            this.txb_DetBusqClient.Location = new System.Drawing.Point(11, 15);
            this.txb_DetBusqClient.Name = "txb_DetBusqClient";
            this.txb_DetBusqClient.Size = new System.Drawing.Size(187, 20);
            this.txb_DetBusqClient.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 344);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.98722F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.01278F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(870, 344);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ListClient);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 338);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de clientes";
            // 
            // dgv_ListClient
            // 
            this.dgv_ListClient.AllowUserToAddRows = false;
            this.dgv_ListClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListClient.Location = new System.Drawing.Point(3, 18);
            this.dgv_ListClient.Name = "dgv_ListClient";
            this.dgv_ListClient.ReadOnly = true;
            this.dgv_ListClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListClient.Size = new System.Drawing.Size(431, 317);
            this.dgv_ListClient.TabIndex = 0;
            this.dgv_ListClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListClient_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ListAutos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(446, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 338);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de autos";
            // 
            // dgv_ListAutos
            // 
            this.dgv_ListAutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAuto,
            this.Placa,
            this.Tipo,
            this.Modelo});
            this.dgv_ListAutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListAutos.Location = new System.Drawing.Point(3, 18);
            this.dgv_ListAutos.Name = "dgv_ListAutos";
            this.dgv_ListAutos.Size = new System.Drawing.Size(415, 317);
            this.dgv_ListAutos.TabIndex = 0;
            // 
            // IdAuto
            // 
            this.IdAuto.HeaderText = "IdAuto";
            this.IdAuto.Name = "IdAuto";
            this.IdAuto.ReadOnly = true;
            this.IdAuto.Visible = false;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_ClientAct, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_VehicElim, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_ClientElim, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_VehicAct, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_AgregarVehiculo, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 413);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(870, 31);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_ClientAct
            // 
            this.btn_ClientAct.BackColor = System.Drawing.Color.LightBlue;
            this.btn_ClientAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ClientAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClientAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientAct.Location = new System.Drawing.Point(225, 3);
            this.btn_ClientAct.Name = "btn_ClientAct";
            this.btn_ClientAct.Size = new System.Drawing.Size(216, 25);
            this.btn_ClientAct.TabIndex = 1;
            this.btn_ClientAct.Text = "Actualizar";
            this.btn_ClientAct.UseVisualStyleBackColor = false;
            this.btn_ClientAct.Click += new System.EventHandler(this.btn_ClientAct_Click);
            // 
            // btn_VehicElim
            // 
            this.btn_VehicElim.BackColor = System.Drawing.Color.Tomato;
            this.btn_VehicElim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_VehicElim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VehicElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VehicElim.Location = new System.Drawing.Point(447, 3);
            this.btn_VehicElim.Name = "btn_VehicElim";
            this.btn_VehicElim.Size = new System.Drawing.Size(151, 25);
            this.btn_VehicElim.TabIndex = 2;
            this.btn_VehicElim.Text = "Eliminar";
            this.btn_VehicElim.UseVisualStyleBackColor = false;
            this.btn_VehicElim.Click += new System.EventHandler(this.btn_VehicElim_Click);
            // 
            // btn_ClientElim
            // 
            this.btn_ClientElim.BackColor = System.Drawing.Color.Tomato;
            this.btn_ClientElim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ClientElim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClientElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientElim.Location = new System.Drawing.Point(3, 3);
            this.btn_ClientElim.Name = "btn_ClientElim";
            this.btn_ClientElim.Size = new System.Drawing.Size(216, 25);
            this.btn_ClientElim.TabIndex = 0;
            this.btn_ClientElim.Text = "Eliminar";
            this.btn_ClientElim.UseVisualStyleBackColor = false;
            this.btn_ClientElim.Click += new System.EventHandler(this.btn_ClientElim_Click);
            // 
            // btn_VehicAct
            // 
            this.btn_VehicAct.BackColor = System.Drawing.Color.LightBlue;
            this.btn_VehicAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_VehicAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VehicAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VehicAct.Location = new System.Drawing.Point(604, 3);
            this.btn_VehicAct.Name = "btn_VehicAct";
            this.btn_VehicAct.Size = new System.Drawing.Size(115, 25);
            this.btn_VehicAct.TabIndex = 3;
            this.btn_VehicAct.Text = "Actualizar";
            this.btn_VehicAct.UseVisualStyleBackColor = false;
            this.btn_VehicAct.Click += new System.EventHandler(this.btn_VehicAct_Click);
            // 
            // btn_AgregarVehiculo
            // 
            this.btn_AgregarVehiculo.BackColor = System.Drawing.Color.LightGreen;
            this.btn_AgregarVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarVehiculo.Location = new System.Drawing.Point(725, 3);
            this.btn_AgregarVehiculo.Name = "btn_AgregarVehiculo";
            this.btn_AgregarVehiculo.Size = new System.Drawing.Size(142, 25);
            this.btn_AgregarVehiculo.TabIndex = 4;
            this.btn_AgregarVehiculo.Text = "Agregar Vehiculo";
            this.btn_AgregarVehiculo.UseVisualStyleBackColor = false;
            this.btn_AgregarVehiculo.Click += new System.EventHandler(this.btn_AgregarVehiculo_Click);
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BuscarCliente";
            this.Size = new System.Drawing.Size(876, 447);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListClient)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListAutos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.ComboBox cbx_TipoClient;
        private System.Windows.Forms.TextBox txb_DetBusqClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_VehicAct;
        private System.Windows.Forms.Button btn_VehicElim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ClientAct;
        private System.Windows.Forms.DataGridView dgv_ListClient;
        private System.Windows.Forms.Button btn_ClientElim;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_ListAutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Modelo;
        private System.Windows.Forms.Button btn_AgregarVehiculo;
    }
}

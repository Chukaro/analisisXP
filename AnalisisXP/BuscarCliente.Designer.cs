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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_VehicAct = new System.Windows.Forms.Button();
            this.btn_VehicElim = new System.Windows.Forms.Button();
            this.dgv_ListAutos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ClientAct = new System.Windows.Forms.Button();
            this.dgv_ListClient = new System.Windows.Forms.DataGridView();
            this.btn_ClientElim = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListAutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListClient)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 479);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_BuscarCliente);
            this.panel1.Controls.Add(this.cbx_TipoClient);
            this.panel1.Controls.Add(this.txb_DetBusqClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 54);
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
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 413);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_VehicAct);
            this.groupBox2.Controls.Add(this.btn_VehicElim);
            this.groupBox2.Controls.Add(this.dgv_ListAutos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(424, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 404);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de autos";
            // 
            // btn_VehicAct
            // 
            this.btn_VehicAct.BackColor = System.Drawing.Color.LightBlue;
            this.btn_VehicAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VehicAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VehicAct.Location = new System.Drawing.Point(275, 375);
            this.btn_VehicAct.Name = "btn_VehicAct";
            this.btn_VehicAct.Size = new System.Drawing.Size(160, 23);
            this.btn_VehicAct.TabIndex = 3;
            this.btn_VehicAct.Text = "Actualizar";
            this.btn_VehicAct.UseVisualStyleBackColor = false;
            // 
            // btn_VehicElim
            // 
            this.btn_VehicElim.BackColor = System.Drawing.Color.Tomato;
            this.btn_VehicElim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VehicElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VehicElim.Location = new System.Drawing.Point(6, 375);
            this.btn_VehicElim.Name = "btn_VehicElim";
            this.btn_VehicElim.Size = new System.Drawing.Size(151, 23);
            this.btn_VehicElim.TabIndex = 2;
            this.btn_VehicElim.Text = "Eliminar";
            this.btn_VehicElim.UseVisualStyleBackColor = false;
            this.btn_VehicElim.Click += new System.EventHandler(this.btn_VehicElim_Click);
            // 
            // dgv_ListAutos
            // 
            this.dgv_ListAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListAutos.Location = new System.Drawing.Point(6, 19);
            this.dgv_ListAutos.Name = "dgv_ListAutos";
            this.dgv_ListAutos.ReadOnly = true;
            this.dgv_ListAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListAutos.Size = new System.Drawing.Size(429, 350);
            this.dgv_ListAutos.TabIndex = 1;
            this.dgv_ListAutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListAutos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ClientAct);
            this.groupBox1.Controls.Add(this.dgv_ListClient);
            this.groupBox1.Controls.Add(this.btn_ClientElim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 404);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de clientes";
            // 
            // btn_ClientAct
            // 
            this.btn_ClientAct.BackColor = System.Drawing.Color.LightBlue;
            this.btn_ClientAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClientAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientAct.Location = new System.Drawing.Point(228, 375);
            this.btn_ClientAct.Name = "btn_ClientAct";
            this.btn_ClientAct.Size = new System.Drawing.Size(184, 23);
            this.btn_ClientAct.TabIndex = 1;
            this.btn_ClientAct.Text = "Actualizar";
            this.btn_ClientAct.UseVisualStyleBackColor = false;
            this.btn_ClientAct.Click += new System.EventHandler(this.btn_ClientAct_Click);
            // 
            // dgv_ListClient
            // 
            this.dgv_ListClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListClient.Location = new System.Drawing.Point(8, 19);
            this.dgv_ListClient.Name = "dgv_ListClient";
            this.dgv_ListClient.ReadOnly = true;
            this.dgv_ListClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListClient.Size = new System.Drawing.Size(404, 350);
            this.dgv_ListClient.TabIndex = 0;
            this.dgv_ListClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListClient_CellClick);
            // 
            // btn_ClientElim
            // 
            this.btn_ClientElim.BackColor = System.Drawing.Color.Tomato;
            this.btn_ClientElim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClientElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientElim.Location = new System.Drawing.Point(8, 375);
            this.btn_ClientElim.Name = "btn_ClientElim";
            this.btn_ClientElim.Size = new System.Drawing.Size(169, 23);
            this.btn_ClientElim.TabIndex = 0;
            this.btn_ClientElim.Text = "Eliminar";
            this.btn_ClientElim.UseVisualStyleBackColor = false;
            this.btn_ClientElim.Click += new System.EventHandler(this.btn_ClientElim_Click);
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BuscarCliente";
            this.Size = new System.Drawing.Size(874, 479);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListAutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListClient)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_ListAutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ClientAct;
        private System.Windows.Forms.DataGridView dgv_ListClient;
        private System.Windows.Forms.Button btn_ClientElim;
    }
}

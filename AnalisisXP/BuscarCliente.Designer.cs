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
            this.dgv_ListAutos = new System.Windows.Forms.DataGridView();
            this.dgv_ListClient = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListClient)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(745, 461);
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
            this.panel1.Size = new System.Drawing.Size(739, 54);
            this.panel1.TabIndex = 0;
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.Location = new System.Drawing.Point(471, 5);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(114, 39);
            this.btn_BuscarCliente.TabIndex = 2;
            this.btn_BuscarCliente.Text = "Buscar";
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            // 
            // cbx_TipoClient
            // 
            this.cbx_TipoClient.FormattingEnabled = true;
            this.cbx_TipoClient.Items.AddRange(new object[] {
            "Nombre",
            "Apellido Paterno",
            "Cedula de identidad",
            "Placa"});
            this.cbx_TipoClient.Location = new System.Drawing.Point(196, 14);
            this.cbx_TipoClient.Name = "cbx_TipoClient";
            this.cbx_TipoClient.Size = new System.Drawing.Size(219, 21);
            this.cbx_TipoClient.TabIndex = 1;
            // 
            // txb_DetBusqClient
            // 
            this.txb_DetBusqClient.Location = new System.Drawing.Point(19, 15);
            this.txb_DetBusqClient.Name = "txb_DetBusqClient";
            this.txb_DetBusqClient.Size = new System.Drawing.Size(100, 20);
            this.txb_DetBusqClient.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 335);
            this.panel2.TabIndex = 1;
            // 
            // dgv_ListAutos
            // 
            this.dgv_ListAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListAutos.Location = new System.Drawing.Point(6, 19);
            this.dgv_ListAutos.Name = "dgv_ListAutos";
            this.dgv_ListAutos.Size = new System.Drawing.Size(290, 290);
            this.dgv_ListAutos.TabIndex = 1;
            // 
            // dgv_ListClient
            // 
            this.dgv_ListClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListClient.Location = new System.Drawing.Point(8, 19);
            this.dgv_ListClient.Name = "dgv_ListClient";
            this.dgv_ListClient.Size = new System.Drawing.Size(404, 290);
            this.dgv_ListClient.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 54);
            this.panel3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ListClient);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 315);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de clientes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ListAutos);
            this.groupBox2.Location = new System.Drawing.Point(434, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 315);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de autos";
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BuscarCliente";
            this.Size = new System.Drawing.Size(745, 461);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListClient)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.ComboBox cbx_TipoClient;
        private System.Windows.Forms.TextBox txb_DetBusqClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_ListAutos;
        private System.Windows.Forms.DataGridView dgv_ListClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

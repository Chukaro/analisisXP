namespace AnalisisXP
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clietneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTarifaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTarifaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbNumero02 = new System.Windows.Forms.Panel();
            this.pbNumero01 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pbNumero02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumero01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbNumero02, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 430F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 631);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clietneToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.tarifaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // clietneToolStripMenuItem
            // 
            this.clietneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoClienteToolStripMenuItem,
            this.reservacionToolStripMenuItem,
            this.búsquedaToolStripMenuItem});
            this.clietneToolStripMenuItem.Name = "clietneToolStripMenuItem";
            this.clietneToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.clietneToolStripMenuItem.Text = "Cliente";
            // 
            // crearNuevoClienteToolStripMenuItem
            // 
            this.crearNuevoClienteToolStripMenuItem.Name = "crearNuevoClienteToolStripMenuItem";
            this.crearNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.crearNuevoClienteToolStripMenuItem.Text = "Crear nuevo cliente";
            this.crearNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoClienteToolStripMenuItem_Click);
            // 
            // reservacionToolStripMenuItem
            // 
            this.reservacionToolStripMenuItem.Name = "reservacionToolStripMenuItem";
            this.reservacionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reservacionToolStripMenuItem.Text = "Reservacion";
            // 
            // búsquedaToolStripMenuItem
            // 
            this.búsquedaToolStripMenuItem.Name = "búsquedaToolStripMenuItem";
            this.búsquedaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.búsquedaToolStripMenuItem.Text = "Búsqueda";
            this.búsquedaToolStripMenuItem.Click += new System.EventHandler(this.búsquedaToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.gananciaToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // gananciaToolStripMenuItem
            // 
            this.gananciaToolStripMenuItem.Name = "gananciaToolStripMenuItem";
            this.gananciaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.gananciaToolStripMenuItem.Text = "Ganancia";
            // 
            // tarifaToolStripMenuItem
            // 
            this.tarifaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTarifaToolStripMenuItem,
            this.buscarTarifaToolStripMenuItem});
            this.tarifaToolStripMenuItem.Name = "tarifaToolStripMenuItem";
            this.tarifaToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.tarifaToolStripMenuItem.Text = "Tarifa";
            // 
            // crearTarifaToolStripMenuItem
            // 
            this.crearTarifaToolStripMenuItem.Name = "crearTarifaToolStripMenuItem";
            this.crearTarifaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.crearTarifaToolStripMenuItem.Text = "Crear tarifa";
            this.crearTarifaToolStripMenuItem.Click += new System.EventHandler(this.crearTarifaToolStripMenuItem_Click);
            // 
            // buscarTarifaToolStripMenuItem
            // 
            this.buscarTarifaToolStripMenuItem.Name = "buscarTarifaToolStripMenuItem";
            this.buscarTarifaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.buscarTarifaToolStripMenuItem.Text = "Buscar tarifa";
            this.buscarTarifaToolStripMenuItem.Click += new System.EventHandler(this.buscarTarifaToolStripMenuItem_Click);
            // 
            // pbNumero02
            // 
            this.pbNumero02.BackColor = System.Drawing.Color.Transparent;
            this.pbNumero02.BackgroundImage = global::AnalisisXP.Properties.Resources.PARQUEO;
            this.pbNumero02.Controls.Add(this.pictureBox1);
            this.pbNumero02.Controls.Add(this.pbNumero01);
            this.pbNumero02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbNumero02.Location = new System.Drawing.Point(3, 30);
            this.pbNumero02.Name = "pbNumero02";
            this.pbNumero02.Size = new System.Drawing.Size(912, 598);
            this.pbNumero02.TabIndex = 2;
            this.pbNumero02.Click += new System.EventHandler(this.pbNumero02_Click);
            // 
            // pbNumero01
            // 
            this.pbNumero01.Location = new System.Drawing.Point(591, 257);
            this.pbNumero01.Name = "pbNumero01";
            this.pbNumero01.Size = new System.Drawing.Size(40, 108);
            this.pbNumero01.TabIndex = 0;
            this.pbNumero01.TabStop = false;
            this.pbNumero01.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(639, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 108);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 631);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(934, 670);
            this.MinimumSize = new System.Drawing.Size(934, 670);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pbNumero02.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNumero01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clietneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciaToolStripMenuItem;
        private System.Windows.Forms.Panel pbNumero02;
        private System.Windows.Forms.ToolStripMenuItem tarifaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearTarifaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTarifaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbNumero01;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


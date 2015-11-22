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
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTarifaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paneImagen = new System.Windows.Forms.Panel();
            this.picBoxMoto1 = new System.Windows.Forms.PictureBox();
            this.búsquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.paneImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.paneImagen, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 430F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1015, 717);
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
            this.menuStrip1.Size = new System.Drawing.Size(1015, 25);
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
            this.crearTarifaToolStripMenuItem});
            this.tarifaToolStripMenuItem.Name = "tarifaToolStripMenuItem";
            this.tarifaToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.tarifaToolStripMenuItem.Text = "Tarifa";
            // 
            // crearTarifaToolStripMenuItem
            // 
            this.crearTarifaToolStripMenuItem.Name = "crearTarifaToolStripMenuItem";
            this.crearTarifaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.crearTarifaToolStripMenuItem.Text = "Crear tarifa";
            // 
            // paneImagen
            // 
            this.paneImagen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paneImagen.BackgroundImage = global::AnalisisXP.Properties.Resources.imagenFondo;
            this.paneImagen.Controls.Add(this.picBoxMoto1);
            this.paneImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneImagen.Location = new System.Drawing.Point(3, 30);
            this.paneImagen.Name = "paneImagen";
            this.paneImagen.Size = new System.Drawing.Size(1009, 684);
            this.paneImagen.TabIndex = 2;
            // 
            // picBoxMoto1
            // 
            this.picBoxMoto1.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMoto1.ErrorImage = null;
            this.picBoxMoto1.Location = new System.Drawing.Point(29, 49);
            this.picBoxMoto1.Name = "picBoxMoto1";
            this.picBoxMoto1.Size = new System.Drawing.Size(172, 50);
            this.picBoxMoto1.TabIndex = 0;
            this.picBoxMoto1.TabStop = false;
            // 
            // búsquedaToolStripMenuItem
            // 
            this.búsquedaToolStripMenuItem.Name = "búsquedaToolStripMenuItem";
            this.búsquedaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.búsquedaToolStripMenuItem.Text = "Búsqueda";
            this.búsquedaToolStripMenuItem.Click += new System.EventHandler(this.búsquedaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 717);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1031, 756);
            this.MinimumSize = new System.Drawing.Size(1031, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.paneImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMoto1)).EndInit();
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
        private System.Windows.Forms.Panel paneImagen;
        private System.Windows.Forms.PictureBox picBoxMoto1;
        private System.Windows.Forms.ToolStripMenuItem tarifaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearTarifaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaToolStripMenuItem;
    }
}


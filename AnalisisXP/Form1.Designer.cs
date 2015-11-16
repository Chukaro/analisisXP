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
            this.paneImagen = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clietneToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
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
            this.reservacionToolStripMenuItem});
            this.clietneToolStripMenuItem.Name = "clietneToolStripMenuItem";
            this.clietneToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.clietneToolStripMenuItem.Text = "Cliente";
            // 
            // crearNuevoClienteToolStripMenuItem
            // 
            this.crearNuevoClienteToolStripMenuItem.Name = "crearNuevoClienteToolStripMenuItem";
            this.crearNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.crearNuevoClienteToolStripMenuItem.Text = "Crear nuevo cliente";
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
            // paneImagen
            // 
            this.paneImagen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paneImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneImagen.Location = new System.Drawing.Point(3, 30);
            this.paneImagen.Name = "paneImagen";
            this.paneImagen.Size = new System.Drawing.Size(778, 533);
            this.paneImagen.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(800, 604);
            this.MinimumSize = new System.Drawing.Size(800, 604);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}


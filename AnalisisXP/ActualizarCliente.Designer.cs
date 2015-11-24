namespace AnalisisXP
{
    partial class ActualizarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_NombreClient = new System.Windows.Forms.TextBox();
            this.txb_PaternoClient = new System.Windows.Forms.TextBox();
            this.txb_MaternoCLient = new System.Windows.Forms.TextBox();
            this.txb_CedulaClient = new System.Windows.Forms.TextBox();
            this.txb_TelfClient = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ActClient = new System.Windows.Forms.Button();
            this.btn_CancelarACtCLient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cedula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefono:";
            // 
            // txb_NombreClient
            // 
            this.txb_NombreClient.Location = new System.Drawing.Point(147, 29);
            this.txb_NombreClient.MaxLength = 30;
            this.txb_NombreClient.Name = "txb_NombreClient";
            this.txb_NombreClient.Size = new System.Drawing.Size(190, 22);
            this.txb_NombreClient.TabIndex = 1;
            // 
            // txb_PaternoClient
            // 
            this.txb_PaternoClient.Location = new System.Drawing.Point(147, 82);
            this.txb_PaternoClient.MaxLength = 30;
            this.txb_PaternoClient.Name = "txb_PaternoClient";
            this.txb_PaternoClient.Size = new System.Drawing.Size(190, 22);
            this.txb_PaternoClient.TabIndex = 1;
            // 
            // txb_MaternoCLient
            // 
            this.txb_MaternoCLient.Location = new System.Drawing.Point(147, 140);
            this.txb_MaternoCLient.MaxLength = 30;
            this.txb_MaternoCLient.Name = "txb_MaternoCLient";
            this.txb_MaternoCLient.Size = new System.Drawing.Size(190, 22);
            this.txb_MaternoCLient.TabIndex = 1;
            // 
            // txb_CedulaClient
            // 
            this.txb_CedulaClient.Location = new System.Drawing.Point(147, 198);
            this.txb_CedulaClient.MaxLength = 10;
            this.txb_CedulaClient.Name = "txb_CedulaClient";
            this.txb_CedulaClient.Size = new System.Drawing.Size(189, 22);
            this.txb_CedulaClient.TabIndex = 3;
            this.txb_CedulaClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // txb_TelfClient
            // 
            this.txb_TelfClient.Location = new System.Drawing.Point(147, 256);
            this.txb_TelfClient.MaxLength = 10;
            this.txb_TelfClient.Name = "txb_TelfClient";
            this.txb_TelfClient.Size = new System.Drawing.Size(190, 22);
            this.txb_TelfClient.TabIndex = 1;
            this.txb_TelfClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_TelfClient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_CedulaClient);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_MaternoCLient);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txb_PaternoClient);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txb_NombreClient);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 289);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_CancelarACtCLient);
            this.groupBox2.Controls.Add(this.btn_ActClient);
            this.groupBox2.Location = new System.Drawing.Point(4, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 64);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btn_ActClient
            // 
            this.btn_ActClient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ActClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ActClient.Location = new System.Drawing.Point(8, 19);
            this.btn_ActClient.Name = "btn_ActClient";
            this.btn_ActClient.Size = new System.Drawing.Size(126, 36);
            this.btn_ActClient.TabIndex = 0;
            this.btn_ActClient.Text = "Actualizar";
            this.btn_ActClient.UseVisualStyleBackColor = false;
            this.btn_ActClient.Click += new System.EventHandler(this.btn_ActClient_Click);
            // 
            // btn_CancelarACtCLient
            // 
            this.btn_CancelarACtCLient.BackColor = System.Drawing.Color.Tomato;
            this.btn_CancelarACtCLient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CancelarACtCLient.Location = new System.Drawing.Point(234, 19);
            this.btn_CancelarACtCLient.Name = "btn_CancelarACtCLient";
            this.btn_CancelarACtCLient.Size = new System.Drawing.Size(126, 36);
            this.btn_CancelarACtCLient.TabIndex = 0;
            this.btn_CancelarACtCLient.Text = "Cancelar";
            this.btn_CancelarACtCLient.UseVisualStyleBackColor = false;
            this.btn_CancelarACtCLient.Click += new System.EventHandler(this.btn_CancelarACtCLient_Click);
            // 
            // ActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActualizarCliente";
            this.Text = "Actualizar Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_NombreClient;
        private System.Windows.Forms.TextBox txb_PaternoClient;
        private System.Windows.Forms.TextBox txb_MaternoCLient;
        private System.Windows.Forms.TextBox txb_CedulaClient;
        private System.Windows.Forms.TextBox txb_TelfClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ActClient;
        private System.Windows.Forms.Button btn_CancelarACtCLient;
    }
}
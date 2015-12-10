namespace AnalisisXP
{
    partial class CuentaAlquiler
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
            this.label_Placa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Cuenta = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // label_Placa
            // 
            this.label_Placa.AutoSize = true;
            this.label_Placa.Font = new System.Drawing.Font("Lucida Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Placa.Location = new System.Drawing.Point(286, 28);
            this.label_Placa.Name = "label_Placa";
            this.label_Placa.Size = new System.Drawing.Size(329, 75);
            this.label_Placa.TabIndex = 1;
            this.label_Placa.Text = "_ _ _ _ _ _";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 75);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuenta:";
            // 
            // label_Cuenta
            // 
            this.label_Cuenta.AutoSize = true;
            this.label_Cuenta.Font = new System.Drawing.Font("Lucida Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cuenta.Location = new System.Drawing.Point(289, 118);
            this.label_Cuenta.Name = "label_Cuenta";
            this.label_Cuenta.Size = new System.Drawing.Size(192, 75);
            this.label_Cuenta.TabIndex = 3;
            this.label_Cuenta.Text = "_____";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(133, 223);
            this.btn_Aceptar.MaximumSize = new System.Drawing.Size(380, 42);
            this.btn_Aceptar.MinimumSize = new System.Drawing.Size(380, 42);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(380, 42);
            this.btn_Aceptar.TabIndex = 4;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            // 
            // CuentaAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(647, 271);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label_Cuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Placa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CuentaAlquiler";
            this.Text = "Cuenta de Alquiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Placa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Cuenta;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}
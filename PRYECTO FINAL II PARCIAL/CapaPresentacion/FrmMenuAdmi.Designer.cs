namespace CapaPresentacion
{
    partial class FrmMenuAdmi
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
            this.lblusuario = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnIngresarDatos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(292, 36);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(249, 25);
            this.lblusuario.TabIndex = 27;
            this.lblusuario.Text = "ROL DE ADMINISTRADOR";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(542, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 38);
            this.button5.TabIndex = 26;
            this.button5.Text = "Reportes";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(288, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 38);
            this.button4.TabIndex = 25;
            this.button4.Text = "Buscar Usuario:";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(43, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 38);
            this.button3.TabIndex = 24;
            this.button3.Text = "Eliminar Usuario:";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnIngresarDatos
            // 
            this.BtnIngresarDatos.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresarDatos.Location = new System.Drawing.Point(43, 103);
            this.BtnIngresarDatos.Name = "BtnIngresarDatos";
            this.BtnIngresarDatos.Size = new System.Drawing.Size(203, 38);
            this.BtnIngresarDatos.TabIndex = 23;
            this.BtnIngresarDatos.Text = "Ingresar Cliente:";
            this.BtnIngresarDatos.UseVisualStyleBackColor = true;
            this.BtnIngresarDatos.Click += new System.EventHandler(this.BtnIngresarDatos_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(542, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 38);
            this.button1.TabIndex = 22;
            this.button1.Text = "Editar por Cédula:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btn
            // 
            this.Btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn.Location = new System.Drawing.Point(288, 103);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(203, 38);
            this.Btn.TabIndex = 21;
            this.Btn.Text = "Editar por Nombre";
            this.Btn.UseVisualStyleBackColor = true;
            // 
            // FrmMenuAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnIngresarDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn);
            this.Name = "FrmMenuAdmi";
            this.Text = "FrmMenuAdmi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnIngresarDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn;
    }
}
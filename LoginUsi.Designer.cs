namespace LoginUnisur
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Aviso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.txtSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.TbContrasena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.Location = new System.Drawing.Point(12, 165);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(10, 13);
            this.Aviso.TabIndex = 4;
            this.Aviso.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(314, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 263);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 252);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // TbUser
            // 
            this.TbUser.Location = new System.Drawing.Point(81, 56);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(157, 20);
            this.TbUser.TabIndex = 8;
            this.TbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            // 
            // txtSalir
            // 
            this.txtSalir.Location = new System.Drawing.Point(128, 252);
            this.txtSalir.Name = "txtSalir";
            this.txtSalir.Size = new System.Drawing.Size(110, 23);
            this.txtSalir.TabIndex = 9;
            this.txtSalir.Text = "Salir";
            this.txtSalir.UseVisualStyleBackColor = true;
            this.txtSalir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(9, 120);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(0, 13);
            this.lblAviso.TabIndex = 12;
            this.lblAviso.Click += new System.EventHandler(this.label4_Click);
            // 
            // TbContrasena
            // 
            this.TbContrasena.Location = new System.Drawing.Point(81, 82);
            this.TbContrasena.Name = "TbContrasena";
            this.TbContrasena.Size = new System.Drawing.Size(157, 20);
            this.TbContrasena.TabIndex = 14;
            this.TbContrasena.TextChanged += new System.EventHandler(this.tbContrasena_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 287);
            this.Controls.Add(this.TbContrasena);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalir);
            this.Controls.Add(this.TbUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aviso);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Aviso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.Button txtSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.TextBox TbContrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


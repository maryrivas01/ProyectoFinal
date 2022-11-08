namespace CapaPresentacion
{
    partial class InicioSesiónPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesiónPaciente));
            this.pbShow = new System.Windows.Forms.PictureBox();
            this.pbHide = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblForgetPass = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbShow
            // 
            this.pbShow.BackColor = System.Drawing.Color.Transparent;
            this.pbShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShow.Image = ((System.Drawing.Image)(resources.GetObject("pbShow.Image")));
            this.pbShow.Location = new System.Drawing.Point(1142, 463);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(45, 45);
            this.pbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShow.TabIndex = 49;
            this.pbShow.TabStop = false;
            this.pbShow.Click += new System.EventHandler(this.pbShow_Click);
            // 
            // pbHide
            // 
            this.pbHide.BackColor = System.Drawing.Color.Transparent;
            this.pbHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHide.Image = ((System.Drawing.Image)(resources.GetObject("pbHide.Image")));
            this.pbHide.Location = new System.Drawing.Point(1142, 463);
            this.pbHide.Name = "pbHide";
            this.pbHide.Size = new System.Drawing.Size(45, 45);
            this.pbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHide.TabIndex = 48;
            this.pbHide.TabStop = false;
            this.pbHide.Click += new System.EventHandler(this.pbHide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(853, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 57);
            this.label1.TabIndex = 46;
            this.label1.Text = "Contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(807, 409);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(807, 284);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(728, 463);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(394, 45);
            this.txtPass.TabIndex = 43;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(707, 330);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(459, 45);
            this.txtUsuario.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(862, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 57);
            this.label4.TabIndex = 41;
            this.label4.Text = "Código";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1298, 9);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(40, 40);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 39;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarSesion.BackgroundImage")));
            this.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 5;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(985, 567);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(202, 73);
            this.btnIniciarSesion.TabIndex = 38;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Font = new System.Drawing.Font("Ink Free", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(592, 9);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(695, 79);
            this.Login.TabIndex = 35;
            this.Login.Text = "Crea una Cuenta Nueva";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 786);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 797);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(577, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(723, 632);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ink Free", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(725, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 36);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ya estás registrado? Inicia Sesión";
            // 
            // lblForgetPass
            // 
            this.lblForgetPass.AutoSize = true;
            this.lblForgetPass.BackColor = System.Drawing.Color.Transparent;
            this.lblForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgetPass.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPass.ForeColor = System.Drawing.Color.White;
            this.lblForgetPass.Location = new System.Drawing.Point(833, 660);
            this.lblForgetPass.Name = "lblForgetPass";
            this.lblForgetPass.Size = new System.Drawing.Size(210, 20);
            this.lblForgetPass.TabIndex = 47;
            this.lblForgetPass.Text = "He olvidado mi Contraseña";
            this.lblForgetPass.Click += new System.EventHandler(this.lblForgetPass_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearUsuario.BackgroundImage")));
            this.btnCrearUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearUsuario.FlatAppearance.BorderSize = 5;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearUsuario.Location = new System.Drawing.Point(691, 567);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(202, 73);
            this.btnCrearUsuario.TabIndex = 37;
            this.btnCrearUsuario.Text = "Registrarse";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // InicioSesiónPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 770);
            this.Controls.Add(this.pbShow);
            this.Controls.Add(this.pbHide);
            this.Controls.Add(this.lblForgetPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSesiónPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InicioSesión_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbShow;
        private System.Windows.Forms.PictureBox pbHide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblForgetPass;
        private System.Windows.Forms.Button btnCrearUsuario;
    }
}


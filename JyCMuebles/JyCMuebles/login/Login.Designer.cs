
namespace login
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ingresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.registrarse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.Label();
            this.agregar = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ingresar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.registrarse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.contraseña);
            this.groupBox1.Controls.Add(this.usuario);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "agregar usuario";
            // 
            // ingresar
            // 
            this.ingresar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ingresar.Location = new System.Drawing.Point(20, 253);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(95, 31);
            this.ingresar.TabIndex = 8;
            this.ingresar.Text = "ingresar";
            this.ingresar.UseVisualStyleBackColor = false;
            this.ingresar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(542, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // registrarse
            // 
            this.registrarse.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.registrarse.Location = new System.Drawing.Point(20, 304);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(95, 28);
            this.registrarse.TabIndex = 6;
            this.registrarse.Text = "registrarse";
            this.registrarse.UseVisualStyleBackColor = false;
            this.registrarse.Click += new System.EventHandler(this.registrarse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(474, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "J&C Muebles";
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(131, 122);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(200, 20);
            this.contraseña.TabIndex = 3;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(131, 47);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(200, 20);
            this.usuario.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(26, 120);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(99, 20);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.Text = "contraseña";
            // 
            // txtnombre
            // 
            this.txtnombre.AutoSize = true;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(26, 47);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(68, 20);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.Text = "usuario";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "500_F_136619762_hdHS8NtdAeWJwZr3aAhVSg5HIJ0X6Z9e.jpg");
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(667, 389);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "JyCmuebles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label txtpassword;
        private System.Windows.Forms.Label txtnombre;
        private System.ComponentModel.BackgroundWorker agregar;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button registrarse;
        private System.Windows.Forms.ImageList imageList1;
    }
}


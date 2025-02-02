namespace ahhhcreatee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titulo = new Label();
            registrar = new Button();
            usuario = new Label();
            textBox1 = new TextBox();
            password = new Label();
            cajaContrasena = new TextBox();
            informacion = new Label();
            iniciarSesion = new Button();
            ingresar = new Button();
            accion = new Label();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.BackColor = Color.CadetBlue;
            titulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.MidnightBlue;
            titulo.Location = new Point(167, 18);
            titulo.Name = "titulo";
            titulo.Size = new Size(84, 40);
            titulo.TabIndex = 0;
            titulo.Text = "titulo";
            // 
            // registrar
            // 
            registrar.Location = new Point(321, 190);
            registrar.Name = "registrar";
            registrar.Size = new Size(75, 23);
            registrar.TabIndex = 1;
            registrar.Text = "registrar";
            registrar.UseVisualStyleBackColor = true;
            registrar.Click += registrar_Click;
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Font = new Font("Segoe UI", 11F);
            usuario.Location = new Point(237, 68);
            usuario.Name = "usuario";
            usuario.Size = new Size(57, 20);
            usuario.TabIndex = 2;
            usuario.Text = "usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(321, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 3;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 11F);
            password.Location = new Point(222, 119);
            password.Name = "password";
            password.Size = new Size(72, 20);
            password.TabIndex = 4;
            password.Text = "password";
            // 
            // cajaContrasena
            // 
            cajaContrasena.Location = new Point(321, 119);
            cajaContrasena.Name = "cajaContrasena";
            cajaContrasena.Size = new Size(170, 23);
            cajaContrasena.TabIndex = 5;
            // 
            // informacion
            // 
            informacion.AutoSize = true;
            informacion.Location = new Point(264, 159);
            informacion.Name = "informacion";
            informacion.Size = new Size(72, 15);
            informacion.TabIndex = 6;
            informacion.Text = "informacion";
            // 
            // iniciarSesion
            // 
            iniciarSesion.Location = new Point(416, 190);
            iniciarSesion.Name = "iniciarSesion";
            iniciarSesion.Size = new Size(75, 23);
            iniciarSesion.TabIndex = 7;
            iniciarSesion.Text = "iniciarSesion";
            iniciarSesion.UseVisualStyleBackColor = true;
            iniciarSesion.Click += iniciarSesion_Click;
            // 
            // ingresar
            // 
            ingresar.Location = new Point(364, 235);
            ingresar.Name = "ingresar";
            ingresar.Size = new Size(75, 23);
            ingresar.TabIndex = 8;
            ingresar.Text = "ingresar";
            ingresar.UseVisualStyleBackColor = true;
            ingresar.Click += ingresar_Click;
            // 
            // accion
            // 
            accion.AutoSize = true;
            accion.Font = new Font("Segoe UI", 11F);
            accion.Location = new Point(335, 291);
            accion.Name = "accion";
            accion.Size = new Size(52, 20);
            accion.TabIndex = 9;
            accion.Text = "accion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(accion);
            Controls.Add(ingresar);
            Controls.Add(iniciarSesion);
            Controls.Add(informacion);
            Controls.Add(cajaContrasena);
            Controls.Add(password);
            Controls.Add(textBox1);
            Controls.Add(usuario);
            Controls.Add(registrar);
            Controls.Add(titulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Button registrar;
        private Label usuario;
        private TextBox textBox1;
        private Label password;
        private TextBox cajaContrasena;
        private Label informacion;
        private Button iniciarSesion;
        private Button ingresar;
        private Label accion;
    }
}

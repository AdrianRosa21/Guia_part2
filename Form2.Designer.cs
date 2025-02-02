namespace ahhhcreatee
{
    partial class boton1
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
            titulo = new Label();
            texto1 = new Label();
            peso1 = new TextBox();
            texto2 = new Label();
            estatura = new TextBox();
            boton = new Button();
            resultado = new Label();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 13F);
            titulo.Location = new Point(222, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(53, 25);
            titulo.TabIndex = 0;
            titulo.Text = "titulo";
            // 
            // texto1
            // 
            texto1.AutoSize = true;
            texto1.Font = new Font("Segoe UI", 11F);
            texto1.Location = new Point(222, 74);
            texto1.Name = "texto1";
            texto1.Size = new Size(51, 20);
            texto1.TabIndex = 1;
            texto1.Text = "texto1";
            // 
            // peso1
            // 
            peso1.Location = new Point(297, 74);
            peso1.Name = "peso1";
            peso1.Size = new Size(230, 23);
            peso1.TabIndex = 2;
            // 
            // texto2
            // 
            texto2.AutoSize = true;
            texto2.Font = new Font("Segoe UI", 11F);
            texto2.Location = new Point(197, 134);
            texto2.Name = "texto2";
            texto2.Size = new Size(51, 20);
            texto2.TabIndex = 3;
            texto2.Text = "texto2";
            // 
            // estatura
            // 
            estatura.Location = new Point(297, 135);
            estatura.Name = "estatura";
            estatura.Size = new Size(230, 23);
            estatura.TabIndex = 4;
            // 
            // boton
            // 
            boton.Font = new Font("Segoe UI", 11F);
            boton.Location = new Point(369, 185);
            boton.Name = "boton";
            boton.Size = new Size(81, 31);
            boton.TabIndex = 5;
            boton.Text = "button1";
            boton.UseVisualStyleBackColor = true;
            boton.Click += boton_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Segoe UI", 12F);
            resultado.Location = new Point(375, 262);
            resultado.Name = "resultado";
            resultado.Size = new Size(75, 21);
            resultado.TabIndex = 6;
            resultado.Text = "resultado";
            
            // 
            // boton1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultado);
            Controls.Add(boton);
            Controls.Add(estatura);
            Controls.Add(texto2);
            Controls.Add(peso1);
            Controls.Add(texto1);
            Controls.Add(titulo);
            Name = "boton1";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label texto1;
        private TextBox peso1;
        private Label texto2;
        private TextBox estatura;
        private Button boton;
        private Label resultado;
    }
}
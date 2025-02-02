using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahhhcreatee
{
    public partial class boton1 : Form
    {
        public boton1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            titulo.Text = "Calculadora de Índice de Masa Corporal (IMC)";
            texto1.Text = "Peso (kg)";
            texto2.Text = "Altura (metros)";
            boton.Text = "Calcular IMC";
            resultado.Text = "";
            resultado.Visible = false;
        }

        private void boton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(peso1.Text) || string.IsNullOrEmpty(estatura.Text))//verificar sí alguno de los textbox esta vacio
            {
                MostrarMensaje("Porfavor rellene los campos.", Color.Red);
                return;
            }

            bool verificar1 = double.TryParse(peso1.Text, out double peso);
            bool verificar2 = double.TryParse(estatura.Text, out double altura);
            if (verificar1 && verificar2)
            {
                double IMC = peso / (altura * altura);
                MostrarMensaje($"Su indice de masa corporal es: {IMC}", Color.Green);
            }
            else
            {
                MostrarMensaje("Porfavor ingrese un número.", Color.Red);
            }

        }

        private void MostrarMensaje(string mensaje, Color color)
        {
            resultado.Visible = true;
            resultado.Text = mensaje;
            resultado.ForeColor = color;
        }

       
    }
}

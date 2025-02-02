namespace ahhhcreatee
{
    public partial class Form1 : Form
    {
        private int operador; // 1 = registro 2 = inicio de sesión
        private string usuarioRegistrado = "";
        private string passwordRegistrada = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            titulo.Text = "Formulario para inicio de sesión";
            usuario.Text = "Usuario";
            informacion.Text = "Seleccione una acción y luego presione 'Ingresar'.";
            registrar.Text = "Registrarse";
            iniciarSesion.Text = "Iniciar Sesión";
            ingresar.Text = "Ingresar";
            password.Text = "Contraseña";
            cajaContrasena.PasswordChar = '*';
            accion.Text = "";
            accion.Visible = false;

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            operador = 1;
            registrar.BackColor = Color.Green;
            iniciarSesion.BackColor = Color.White;

        }

        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            operador = 2;
            iniciarSesion.BackColor = Color.Green;
            registrar.BackColor = Color.White;
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = textBox1.Text;
            string passwordIngresada = cajaContrasena.Text;

            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(passwordIngresada))
            {
                MostrarMensaje("Por favor, complete todos los campos.", Color.Red);
                return;//Este return es para evitar que los demas if se ejecuten si estan vacios.
            }

            if (operador == 1) // Registrar
            {
                usuarioRegistrado = usuarioIngresado;
                passwordRegistrada = passwordIngresada;
                MostrarMensaje("Registro exitoso. Ahora puede iniciar sesión.", Color.Green);
            }
            else if (operador == 2) // Iniciar sesión
            {
                if (usuarioIngresado == usuarioRegistrado && passwordIngresada == passwordRegistrada)
                {
                    MostrarMensaje("Inicio de sesión correcto.", Color.Green);
                }
                else
                {
                    MostrarMensaje("Usuario o contraseña incorrectos.", Color.Red);
                }
            }
            else
            {
                MostrarMensaje("Porfavor seleccione una opción.", Color.Red);
            }
        }

        private void MostrarMensaje(string mensaje, Color color)//Esto lo investigue tipo pa mostrar un mensaje
        {
            accion.Text = mensaje;//esta variable sera el primer parametro que recibira para luego mandar a llamar ese metodo
            accion.ForeColor = color;//y primero poner el texto, luego el color ASJSADJKKJSAD goat va
            accion.Visible = true;
        }

       
    }
}




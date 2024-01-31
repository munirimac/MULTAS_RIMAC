using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApp15
{
    public partial class iniarSesion : Form
    {
        string connectionString = "Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$";
        MDIParent1 formPrincipal; // Mantén una referencia al formulario principal

        public iniarSesion()
        {
            InitializeComponent();
            txtIniciarSesion.Font = new Font(txtIniciarSesion.Font.FontFamily, 15);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true; // Habilitar la vista previa de las teclas en el formulario
            this.KeyDown += iniarSesion_KeyDown; // Suscribirte al evento KeyDown
        }

        private void iniarSesion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
        }

        public static class DatosCompartidos
        {
            public static string Usuario { get; set; }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Cierra la aplicación por completo
        }

        public void ClearFields()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Ocultar la contraseña en el TextBox
            txtContraseña.UseSystemPasswordChar = true;

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (ValidarCredenciales(usuario, contraseña))
            {
                DatosCompartidos.Usuario = usuario;
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario de inicio de sesión
                this.Hide();

                // Abrir la interfaz principal (MDIParent1)
                formPrincipal = new MDIParent1();
                formPrincipal.FormClosed += FormPrincipal_FormClosed; // Manejar el evento FormClosed
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar nuevamente el formulario de inicio de sesión y limpiar campos
            this.Show();
            ClearFields();
        }

        private bool ValidarCredenciales(string usuario, string contraseña)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM M_USARIOS_NEW WHERE USUARIO = @Usuario AND CONTRASENA = @Contraseña";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}

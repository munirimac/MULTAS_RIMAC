using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FormLogin
{
    public partial class Login : Form
    {
        string connectionString = "Data Source=171.15.10.2;Initial Catalog=SATMUNXP;User ID=sa;Password=12345";

        public Login()
        {
            InitializeComponent();
            this.FormClosed += Form2_FormClosed;

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
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Ocultar la contraseña en el TextBox
            txtContraseña.UseSystemPasswordChar = true;

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (ValidarCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Credenciales inválidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // En el código del Form1
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.ClearFields(); // Limpia los campos del Form2
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (ValidarCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir Form1
                Form1 formReportes = new Form1();
                formReportes.FormClosed += Form1_FormClosed; // Manejar el evento FormClosed
                formReportes.Show();

                // Cerrar Form2
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar una nueva instancia del Form2 y limpiar los campos
            Form2 form2 = new Form2();
            form2.ClearFields();
            form2.Show();
        }

        private bool ValidarCredenciales(string usuario, string contraseña)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_7");
                string decryptedQuery = Decrypt(encryptedQuery);
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

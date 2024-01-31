using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class RegistrarInspector : Form
    {
        private string nombreLocal;
        private int codigoTENO;
        public int CodigoTecnico { get { return codigoTENO; } }
        public string NombreInspectorSeleccionado { get { return nombreLocal; } }
        public RegistrarInspector()
        {
            InitializeComponent();
            btnSeleccionar.Visible = false;
        }

        public RegistrarInspector(ref string nombreInspector, int codigoTecnico)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtCodNom.ReadOnly = true;
            //dataGridView1.AutoGenerateColumns = true;
            nombreLocal = nombreInspector;
            codigoTENO = codigoTecnico;
            this.FormClosed += RegistrarInspector_FormClosed;
        }


        private void RegistrarInspector_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verificar si se seleccionó una dirección y si el formulario se cerró de forma aceptada (OK)
            if (codigoTENO != -1)
            {
                // Actualizar el valor de DireCodDir en el formulario RegistroNIC
                RegistroNIC formularioRegistroNIC = Application.OpenForms.OfType<RegistroNIC>().FirstOrDefault();
                if (formularioRegistroNIC != null)
                {
                    formularioRegistroNIC.codigoTecnico = codigoTENO;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el número de DNI ingresado en el cuadro de texto txtNumDoc
                string dniBuscado = txtNumDoc.Text;

                // Consulta para buscar el código de persona (PERS_P_inCODPER) a partir del DNI ingresado
                string queryPersona = "SELECT VRELA.PERS_P_inCODPER " +
                                      "FROM V_RELA_DOCU VRELA " +
                                      "WHERE VRELA.REDO_chNUMRED = @DniBuscado AND ESTADO=1";

                using (SqlConnection con = new SqlConnection("Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$"))
                {
                    con.Open();

                    // Obtener el código de persona (PERS_P_inCODPER) a partir del DNI
                    int codPer;
                    using (SqlCommand cmdPersona = new SqlCommand(queryPersona, con))
                    {
                        cmdPersona.Parameters.AddWithValue("@DniBuscado", dniBuscado);
                        object result = cmdPersona.ExecuteScalar();
                        if (result != null)
                        {
                            codPer = Convert.ToInt32(result);
                            MessageBox.Show("EL CODPER DE ESTA PERSONA ES :" + codPer, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            codPer = 0;
                        }
                    }

                    if (codPer > 0)
                    {
                        // Realizar la consulta para obtener la información del inspector
                        string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_8");
                        string decryptedQuery = Decrypt(encryptedQuery);

                        using (SqlCommand cmdInspectores = new SqlCommand(queryInspectores, con))
                        {
                            cmdInspectores.Parameters.AddWithValue("@CodPer", codPer);

                            SqlDataAdapter adp = new SqlDataAdapter(cmdInspectores);
                            DataTable dtInspectores = new DataTable();
                            adp.Fill(dtInspectores);

                            // Mostrar los valores en el TextBox "txtCodNom" utilizando la función mostraValores
                            mostraValores(dtInspectores);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna persona con ese DNI.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de que ocurra un error, puedes manejarlo aquí
                // Por ejemplo, mostrar un mensaje de error o registrar el error en un archivo de log
                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void mostraValores(DataTable dt)
        {
            // Limpiar el TextBox antes de mostrar los valores
            txtCodNom.Text = "";



            // Recorre las filas de la tabla
            foreach (DataRow fila in dt.Rows)
            {
                // Accede al valor del nombre del inspector y agrégalo al TextBox con un salto de línea
                string nombre = fila["PERS_chNOMCOM"].ToString();
                txtCodNom.Text += nombre + Environment.NewLine;

                string tipoDocumento = fila["TIDO_chDESTID"].ToString();
                cboTipoDoc.Text = tipoDocumento;
                MessageBox.Show("SE ENCONTRÓ EL TIPO DE DOCUMENTO: " + tipoDocumento, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        // Agregar el siguiente método a la clase RegistrarInspector
        private int ObtenerTENO_P_inCODNOT(int codPer)
        {
            int codigoTENO = 0;

            try
            {
                // Consulta para obtener el valor de TENO_P_inCODNOT asociado al inspector
                string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_9");
                string decryptedQuery = Decrypt(encryptedQuery);

                using (SqlConnection con = new SqlConnection("Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$"))
                {
                    con.Open();

                    using (SqlCommand cmdTENO = new SqlCommand(queryTENO, con))
                    {
                        cmdTENO.Parameters.AddWithValue("@CodPer", codPer);
                        object result = cmdTENO.ExecuteScalar();
                        if (result != null)
                        {
                            codigoTENO = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de que ocurra un error, puedes manejarlo aquí
                // Por ejemplo, mostrar un mensaje de error o registrar el error en un archivo de log
                MessageBox.Show("Error al obtener el valor de TENO_P_inCODNOT: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return codigoTENO;
        }

        // Modificar el evento btnGuardarClick
        private void btnGuardarClick(object sender, EventArgs e)
        {
            // Obtener el número de DNI ingresado en el cuadro de texto txtNumDoc
            string dniBuscado = txtNumDoc.Text;
            if (string.IsNullOrWhiteSpace(dniBuscado))
            {
                MessageBox.Show("Por favor, ingrese un número de DNI válido.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$"))
                {
                    con.Open();

                    // Consulta para buscar el código de persona (PERS_P_inCODPER) a partir del DNI ingresado
                    string queryPersona = "SELECT VRELA.PERS_P_inCODPER " +
                                          "FROM V_RELA_DOCU VRELA " +
                                          "WHERE VRELA.REDO_chNUMRED = @DniBuscado";

                    int codPer;
                    using (SqlCommand cmdPersona = new SqlCommand(queryPersona, con))
                    {
                        cmdPersona.Parameters.AddWithValue("@DniBuscado", dniBuscado);
                        object result = cmdPersona.ExecuteScalar();
                        if (result != null)
                        {
                            codPer = Convert.ToInt32(result);
                        }
                        else
                        {
                            codPer = 0;
                        }
                    }

                    if (codPer > 0)
                    {
                        // Obtener el valor de TENO_P_inCODNOT asociado al inspector
                        int codigoTENO = ObtenerTENO_P_inCODNOT(codPer);

                        if (codigoTENO > 0)
                        {
                            // Mostrar el valor de TENO_P_inCODNOT en un MessageBox
                            //MessageBox.Show("El valor de TENO_P_inCODNOT del inspector es: " + codigoTENO, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Asignar el valor de TENO_P_inCODNOT a la propiedad codigoTENO del formulario RegistroNIC
                            this.codigoTENO = codigoTENO;

                            // Guardar el valor de TENO_P_inCODNOT en la variable nombreLocal y cerrar el formulario
                            nombreLocal = txtCodNom.Text;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún valor asociado al inspector.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna persona con ese DNI.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de que ocurra un error, puedes manejarlo aquí
                // Por ejemplo, mostrar un mensaje de error o registrar el error en un archivo de log
                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

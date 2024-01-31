using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static WindowsFormsApp15.iniarSesion;

namespace WindowsFormsApp15
{
    public partial class DeshabilitarMulta : Form
    {
        private string numeroNotificacion;
        public DeshabilitarMulta(string numeroNotificacion)
        {
            InitializeComponent();
            txtMotivoInfraccion.KeyPress += TxtMotivoInfraccion_KeyPress;
            this.numeroNotificacion = numeroNotificacion;
        }

        private void TxtMotivoInfraccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMotivoInfraccion.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Impide que se ingrese más texto si ya se llegó al límite
            }
        }

        private SqlConnection GetConnection()
        {
            string connectionString = "Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$";
            return new SqlConnection(connectionString);
        }

        private int ObtenerNOTCPInCODNOT(string numeroNotificacion)
        {
            int notcPInCODNOT = -1; // Valor predeterminado en caso de no encontrar el número de notificación

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener el NOTC_P_inCODNOT asociado al número de notificación
                    string query = "SELECT NOTC_P_inCODNOT FROM M_NOTC WHERE NOTC_chNRONOT = @NumeroNotificacion";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroNotificacion", numeroNotificacion);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            notcPInCODNOT = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el NOTC_P_inCODNOT: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return notcPInCODNOT;
        }


        private int obtenerNumeroMulta(int NOTC_P_inCOD)
        {
            int numMultaAnulado = -1; // Valor predeterminado en caso de no encontrar el número de notificación

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener el NOTC_P_inCODNOT asociado al número de notificación
                    string query = "SELECT MULC_P_inCODMUL FROM M_MULC WHERE NOTC_P_inCODNOT = @CodigoNOTC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CodigoNOTC", NOTC_P_inCOD);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            numMultaAnulado = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el NOTC_P_inCODNOT: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return numMultaAnulado;
        }


        private int obtenerCODIRI(int numMulta)
        {
            int numeroMulta = -1;
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener el NOTC_P_inCODNOT asociado al número de notificación
                    string query = "SELECT CCOR_P_inCODORI FROM M_CTAC_ORIG WHERE MULC_P_inCODMUL = @NumeroMulta";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroMulta", numMulta);

                        object result = cmd.ExecuteScalar();

                        numeroMulta = Convert.ToInt32(result);

                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el NOTC_P_inCODNOT: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return numeroMulta;
        }


        private void btnGuardarDoc_Click(object sender, EventArgs e)
        {
            int NOTC_P_inCODNOTDESHA = ObtenerNOTCPInCODNOT(numeroNotificacion);
            int numMulta = obtenerNumeroMulta(NOTC_P_inCODNOTDESHA);
            int CODORI = obtenerCODIRI(numMulta);

            if (string.IsNullOrWhiteSpace(txtNroExpediente.Text) ||
                string.IsNullOrWhiteSpace(txtNumResol.Text) ||
                string.IsNullOrWhiteSpace(txtMotivoInfraccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del evento sin continuar
            }
            try
            {
                DateTime diaRecepcion = dptDiaRecepcion.Value;
                string nroExpediente = txtNroExpediente.Text.Trim();
                string numResol = txtNumResol.Text.Trim();
                string motivoInfraccion = txtMotivoInfraccion.Text.Trim();

                string docRef = $"{diaRecepcion.ToShortDateString()} - {nroExpediente} - {numResol} - {motivoInfraccion}-{DatosCompartidos.Usuario}";

                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string updateQuery = "UPDATE M_CTAC SET CTAC_chDOCREF = @DocRef WHERE CCOR_P_inCODORI=@CODORI";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@DocRef", docRef);
                        cmd.Parameters.AddWithValue("@CODORI", CODORI);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Documento de referencia actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra el formulario actual
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el documento de referencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

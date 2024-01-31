using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp15.iniarSesion;

namespace WindowsFormsApp15
{
    public partial class FormDocumentoResolucion : Form
    {
        private int REMA_P_inCODREC;
        private int guardarESRM;
        public int ESRM_P_inCODEST { get { return guardarESRM; } }
        private int NOTC_P_inCODNOT;
        public FormDocumentoResolucion(ref int notcPInCODNOT, int ESRM_P_inCODEST)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            NOTC_P_inCODNOT = notcPInCODNOT;
            guardarESRM = ESRM_P_inCODEST;
        }

        private void btnGuardarReso_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePickerRegis.Value;
            string fechInicio = fechaInicio.ToString("yyyyMMdd");
            DateTime fechaExpediente = dateTimePickerFechaExp.Value;
            string fechaExpe = fechaExpediente.ToString("yyyyMMdd");
            string AñoExp = txtAñoExp.Text;
            string NroExp = txtNroExp.Text;
            string DocReso = txtResueltoDoc.Text;
            DateTime fechaDocumento = dataTimePickerFechDoc.Value;
            string fechaDoc = fechaDocumento.ToString("yyyyMMdd");
            DateTime fechaNotificacion = dateTimePickerFechaNoti.Value;
            string fechaNot = fechaNotificacion.ToString("yyyyMMdd");
            this.FormClosed += FormDocumentoResolucion_FormClosed;
            string InformeTecnico = txtMotivoInfraccion.Text;

            if (string.IsNullOrWhiteSpace(AñoExp) || string.IsNullOrWhiteSpace(NroExp) || string.IsNullOrWhiteSpace(DocReso))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(AñoExp) || string.IsNullOrEmpty(NroExp) || string.IsNullOrEmpty(DocReso))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fechaInicio > DateTime.Now || fechaExpediente > DateTime.Now || fechaDocumento > DateTime.Now || fechaNotificacion > DateTime.Now)
            {
                MessageBox.Show("No se pueden seleccionar fechas futuras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el valor seleccionado del ComboBox cboEstado
            string estadoSeleccionado = cboEstado.SelectedItem.ToString();

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=171.15.10.113;Initial Catalog=SATMUNXP_30_09_2023;User ID=sa;Password=omega2"))
                {
                    con.Open();

                    int mulcPInCODMUL = ObtenerMULC_P_inCODMUL(con, NOTC_P_inCODNOT);

                    using (SqlCommand cmd = new SqlCommand("s_i_M_RECL_MULC", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@iREMU_P_inCODREC", 0);
                        cmd.Parameters.AddWithValue("@iREMU_chFECREC", fechInicio);//fechaInicio
                        cmd.Parameters.AddWithValue("@iREMA_P_inCODREC", REMA_P_inCODREC);//REMA_P_inCODREC
                        cmd.Parameters.AddWithValue("@iMULC_P_inCODMUL", mulcPInCODMUL);
                        cmd.Parameters.AddWithValue("@iESRM_P_inCODEST", ESRM_P_inCODEST);//ESRM_P_inCODEST
                        cmd.Parameters.AddWithValue("@iREMU_chANOEXP", AñoExp);//AñoExp
                        cmd.Parameters.AddWithValue("@iREMU_chNROEXP", NroExp);//NroExp
                        cmd.Parameters.AddWithValue("@iREMU_chFECEXP", fechaExpe);
                        cmd.Parameters.AddWithValue("@iREMU_chDOCRES", DocReso);
                        cmd.Parameters.AddWithValue("@iREMU_chFECRES", fechaDoc);
                        cmd.Parameters.AddWithValue("@iREMU_chFECNOT", fechaNot);
                        cmd.Parameters.AddWithValue("@iREMU_chOBSREC", InformeTecnico);
                        cmd.Parameters.AddWithValue("@iSEGU_chUSULOG", DatosCompartidos.Usuario);
                        cmd.Parameters.AddWithValue("@iSEGU_chUSUMAQ", Environment.MachineName);
                        cmd.Parameters.AddWithValue("@iSEGU_chUSUFEC", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

                        cmd.Parameters.Add("@oRESULT", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        string resultado = cmd.Parameters["@oRESULT"].Value.ToString();
                        //MessageBox.Show("Procedimiento almacenado ejecutado correctamente." + resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("EL NOTC_P_inCODNOT es: ." + NOTC_P_inCODNOT, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (resultado == "0")
                        {
                            MessageBox.Show("Error al ejecutar el procedimiento almacenado__ERROR_1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Procedimiento almacenado ejecutado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDocumentoResolucion_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verificar si se debe actualizar el valor de ESRM_P_inCODEST
            if (guardarESRM != 0) // Puedes ajustar esta condición según tu lógica
            {
                // Actualizar el valor de ESRM_P_inCODEST en el formulario principal
                ListarNIC formularioPrincipal = Application.OpenForms.OfType<ListarNIC>().FirstOrDefault();
                if (formularioPrincipal != null)
                {
                    formularioPrincipal.ESRM_P_inCODEST = guardarESRM;
                }
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado del ComboBox cboEstado
            string estadoSeleccionado = cboEstado.SelectedItem.ToString();

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=171.15.10.113;Initial Catalog=SATMUNXP_30_09_2023;User ID=sa;Password=omega2"))
                {
                    con.Open();

                    // Obtener el REMA_P_inCODREC correspondiente al estado seleccionado
                    REMA_P_inCODREC = ObtenerREMA_P_inCODREC(con, estadoSeleccionado);

                    //MessageBox.Show($"Valor obtenido de la función ObtenerREMA_P_inCODREC: {REMA_P_inCODREC}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el valor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int ObtenerREMA_P_inCODREC(SqlConnection connection, string estadoSeleccionado)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT REMA_P_inCODREC FROM M_RECU_MADM WHERE REMA_chDESREC = @estadoSeleccionado", connection))
            {
                cmd.Parameters.AddWithValue("@estadoSeleccionado", estadoSeleccionado);
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int REMA_P_inCODREC))
                {
                    return REMA_P_inCODREC;
                }

                return 0; // Valor por defecto o manejo de error
            }
        }

        private void cboDocuReso_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado del ComboBox cboDocuReso
            string estadoSeleccionado = cboDocuReso.SelectedItem.ToString();

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=171.15.10.113;Initial Catalog=SATMUNXP_30_09_2023;User ID=sa;Password=omega2"))
                {
                    con.Open();

                    // Obtener el ESRM_P_inCODEST correspondiente al estado seleccionado
                    guardarESRM = ObtenerESRM_P_inCODEST(con, estadoSeleccionado);

                    // MessageBox.Show($"Valor obtenido de la función ObtenerESRM_P_inCODEST: {guardarESRM}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el valor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private int ObtenerESRM_P_inCODEST(SqlConnection connection, string estadoSeleccionado)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT ESRM_P_inCODEST FROM M_ESTA_RECL_MULC WHERE ESRM_chDESEST = @estadoSeleccionado", connection))
            {
                cmd.Parameters.AddWithValue("@estadoSeleccionado", estadoSeleccionado);
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int esrmPInCODEST))
                {
                    return esrmPInCODEST;
                }

                return 0; // Valor por defecto o manejo de error
            }
        }

        private int ObtenerMULC_P_inCODMUL(SqlConnection connection, int notcPInCODNOT)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT MULC_P_inCODMUL FROM M_MULC WHERE NOTC_P_inCODNOT = @notcPInCODNOT", connection))
            {
                cmd.Parameters.AddWithValue("@notcPInCODNOT", notcPInCODNOT);
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int mulcPInCODMUL))
                {
                    return mulcPInCODMUL;
                }

                return 0; // Valor por defecto o manejo de error
            }
        }

    }
}

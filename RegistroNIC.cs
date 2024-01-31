using DocumentFormat.OpenXml.Office.CustomUI;
using log4net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp15.iniarSesion;

namespace WindowsFormsApp15
{
    public partial class RegistroNIC : Form
    {
        private string nombreInspector;
        private string NombreActividad;
        private string NombreInfraccion;
        private int anioGuardado;
        private string guardaCompleto;
        private string guardaDOC;
        private string guardaDOCU;
        private int codigoPersonaEncontrada;
        public string descripcionInfraccion;
        private int codigoUniInfracc;
        private int codigoUniInfraccionActual;
        public string guardaNomCompleto { get; set; }
        public int guardaCodigoDireFiscal { get; set; }
        public int guardaCodigoPersona { get; set; }
        public string guardaDirecFiscal { get; set; }
        public int guardaCodActi { get; set; }

        private int redoCodRdo; // Declarar la variable para almacenar el resultado

        public int CodDir { get; set; }
        public int codigoTecnico { get; set; }
        private int codigoDireccion;
        private int ORDE_P_inCODORD; // Declarar la variable a nivel de clase
        /*private enum ContextoActual
        {
            Ninguno,
            AgregarInfractor,
            BuscarPersona
        }

        private ContextoActual contextoActual = ContextoActual.Ninguno;
        */

        public RegistroNIC()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            txtNombrePersona.ReadOnly = true;
            textDirecFiscal.ReadOnly = true;
            txtValorUIT.ReadOnly = true;
            txtPorcentajeInfraccion.ReadOnly = true;
            txtValorInfraccion.ReadOnly = true;
            txtMotivoInfraccion.ReadOnly = true;
            textCodUniIfracc.ReadOnly = true;
            groupBox1.Visible = true;
            txtNumOrdenanza.ReadOnly = true;
            txtCantUIT.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            txtValorObra.Visible = false;
            btnGuardarNOTIFIC.Visible = false;
            txtNumOrdenanza.Visible = false;
        }
        private void LimpiarCampos()
        {
            // Reiniciar los campos de notificación
            cboAnioNIC.SelectedItem = null;
            cboOrdenanza.SelectedItem = null;
            //cboTipInfracc.SelectedItem = null;
            txtNumNIC.Text = string.Empty;
            dtpFecRecp.Value = DateTime.Now;
            dtpHoraNic.Value = DateTime.Now;
            txtNumOrdenanza.Text = null;
            txtInfraccion.Text = string.Empty;
            txtMotivoInfraccion.Text = string.Empty;
            txtPorcentajeInfraccion.Text = string.Empty;
            txtValorInfraccion.Text = string.Empty;
            textDirecFiscal.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            txtRepresentanteLegal.Text = string.Empty;
            txtValorUIT.Text = string.Empty;
            textCodUniIfracc.Text = string.Empty;
            cboTipoDoc.SelectedItem = null;

            // Reiniciar los campos de búsqueda de persona
            txtNumDoc.Text = string.Empty;
            txtNombrePersona.Text = string.Empty;
            textDirecFiscal.Text = string.Empty;
            cboTipoDoc.SelectedItem = null;
            txtValorObra.Text = string.Empty;
            txtPorcentaje.Text = string.Empty;
            labelValorObraX.Visible = false;
            label9.Visible = false;
            txtPorcentajeObra.Visible = false;


            // Restablecer el contexto actual a "Ninguno"
            //contextoActual = ContextoActual.Ninguno;
        }

        public static SqlConnection con = null;
        public static SqlConnection getCon()
        {
            string query = "Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$";
            con = new SqlConnection(query);
            return con;
        }
        private void btnBuscarPersona_Click(object sender, EventArgs e)
        {
            //contextoActual = ContextoActual.BuscarPersona;
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumDoc.Text))
                {
                    MessageBox.Show("Por favor, escriba un número de documento antes de hacer la búsqueda.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del evento sin hacer la búsqueda
                }

                // Variables para almacenar los datos obtenidos de la consulta
                string nombreTipoDocumento = "";

                // Obtener el DNI que se ingresó en el cuadro de texto txtNumDoc
                string dniBuscado = txtNumDoc.Text;

                // Consulta para buscar el nombre, PERS_P_inCODPER, dirección y el tipo de documento de la persona con el DNI especificado
                string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_10");
                string decryptedQuery = Decrypt(encryptedQuery);

                using (SqlConnection con = getCon())
                {
                    con.Open();

                    SqlCommand cmdNombreDireccion = new SqlCommand(query, con);
                    cmdNombreDireccion.Parameters.AddWithValue("@DniBuscado", dniBuscado);

                    using (SqlDataReader reader = cmdNombreDireccion.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener el nombre de la persona
                            string nombrePersona = reader["PERS_chNOMCOM"].ToString();

                            // Asignar el nombre de la persona a la caja de texto
                            txtNombrePersona.Text = nombrePersona;

                            // Obtener el valor de PERS_P_inCODPER (código de la persona)
                            codigoPersonaEncontrada = Convert.ToInt32(reader["PERS_P_inCODPER"]);

                            // Obtener el campo DIRE_P_inCODDIR de la tabla M_DIRE
                            codigoDireccion = Convert.ToInt32(reader["DIRE_P_inCODDIR"]);

                            // Asignar la dirección de la persona al campo textDirecFiscal
                            string direccionPersona = reader["Direccion"].ToString();
                            textDirecFiscal.Text = direccionPersona;

                            // Obtener el nombre del tipo de documento
                            nombreTipoDocumento = reader["TIDO_chDESTID"].ToString();

                            // Mostrar el nombre del tipo de documento en el ComboBox
                            cboTipoDoc.Text = nombreTipoDocumento;
                        }
                        else
                        {
                            // Si no se encontró ninguna persona con ese DNI, mostrar un mensaje
                            MessageBox.Show("No se encontró ninguna persona con ese DNI.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Limpiar la caja de texto
                            txtNombrePersona.Text = string.Empty;
                            // Limpiar el campo de texto de dirección
                            textDirecFiscal.Text = string.Empty;
                            // Limpiar el ComboBox de tipo de documento
                            cboTipoDoc.Text = string.Empty;
                        }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadirInfractor_Click(object sender, EventArgs e)
        {
            RegistroInfractor formRegistroInfractor = new RegistroInfractor(ref guardaCompleto, guardaDOC, guardaDOCU, guardaDirecFiscal, guardaCodigoPersona, guardaCodigoDireFiscal, guardaNomCompleto);
            formRegistroInfractor.ShowDialog();
            /*txtNombrePersona.Text = formRegistroInfractor.guardaCompletoNombre;
            cboTipoDoc.Text = formRegistroInfractor.guardarTipoDoc;
            txtNumDoc.Text = formRegistroInfractor.guardaDocum;
            textDirecFiscal.Text = formRegistroInfractor.guardarDireccionFiscal;
            txtNombrePersona.Text = formRegistroInfractor.guardaCompletoNombre;
            contextoActual = ContextoActual.AgregarInfractor;*/
        }

        private void btnAñadirInspector_Click(object sender, EventArgs e)
        {
            RegistrarInspector FormRegistroInspector = new RegistrarInspector(ref nombreInspector, codigoTecnico);
            FormRegistroInspector.ShowDialog();
            codigoTecnico = FormRegistroInspector.CodigoTecnico;
            textBox1.Text = FormRegistroInspector.NombreInspectorSeleccionado;
        }


        private void btnAñadirActividadComercial_Click(object sender, EventArgs e)
        {
            RegistroActividadComercial FormRegistroActividadComercial = new RegistroActividadComercial(ref NombreActividad, guardaCodActi);
            FormRegistroActividadComercial.ShowDialog();
            textBox2.Text = FormRegistroActividadComercial.NombreActividadComercial;
        }

        private void btnBuscInfrac(object sender, EventArgs e)
        {
            RegistrarInfraccion FormRegistrarInfraccion = new RegistrarInfraccion(ref NombreInfraccion, CodDir);
            FormRegistrarInfraccion.ShowDialog();
            textBox3.Text = FormRegistrarInfraccion.DireccionSeleccionada;
        }



        private void cboAnioNIC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se ha seleccionado un elemento en el ComboBox
                if (cboAnioNIC.SelectedItem != null)
                {
                    // Obtener el valor seleccionado en el ComboBox (el año)
                    string anioSeleccionado = cboAnioNIC.SelectedItem.ToString();

                    // Consulta para obtener el campo ANIO_deVALUIT de la base de datos
                    string query = "SELECT ANIO_deVALUIT FROM M_ANIO WHERE ANIO_P_chCODANO= @AnioSeleccionado";

                    using (SqlConnection con = new SqlConnection("Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$"))
                    {
                        //Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$
                        con.Open();

                        // Ejecutar la consulta y obtener el valor de ANIO_deVALUIT
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@AnioSeleccionado", anioSeleccionado);
                            object result = cmd.ExecuteScalar();

                            // Verificar que se obtuvo un valor
                            if (result != null && result != DBNull.Value)
                            {
                                // Convertir el resultado a un valor entero (o al tipo de dato apropiado para ANIO_deVALUIT)
                                int anioDeValor = Convert.ToInt32(result);

                                // Asignar el valor de ANIO_deVALUIT a la variable anioGuardado
                                anioGuardado = anioDeValor;

                                // Puedes mostrar el valor en el cuadro de texto txtValorUIT si deseas
                                txtValorUIT.Text = anioGuardado.ToString();

                                //MessageBox.Show("Se encontro el campo ANIO_deVALUIT.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // Si no se encontró un valor para el año seleccionado, puedes mostrar un mensaje de error o manejarlo como desees.
                                MessageBox.Show("No se encontró el campo ANIO_deVALUIT para el año seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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

        private void cboTipInfracc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string tipoValorSeleccionado = cboTipInfracc.SelectedItem.ToString();

            if (tipoValorSeleccionado == "CANTIDAD")
            {
                txtCantUIT.Visible = true;
                label8.Visible = true;
                label9.Visible = false;
                txtValorObra.Visible = false;
            }
            else if (tipoValorSeleccionado == "VALOR DE OBRA")
            {
                txtCantUIT.Visible = false;
                label8.Visible = false;
                label9.Visible = true;
                txtValorObra.Visible = true;
            }
            else if (tipoValorSeleccionado == "PORCENTAJE")
            {
                label9.Visible = false;
                txtValorObra.Visible = false;
                txtCantUIT.Visible = false;
                label8.Visible = false;
            }
        }


        private void cboOrdenanza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOrdenanza.SelectedItem != null)
            {
                string selectedOrdenanza = cboOrdenanza.SelectedItem.ToString();
                string query = "SELECT ORDE_P_inCODORD FROM M_ORDE WHERE ORDE_chNROORD = @SelectedOrdenanza";

                using (SqlConnection con = getCon())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SelectedOrdenanza", selectedOrdenanza);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            ORDE_P_inCODORD = Convert.ToInt32(result);
                            //MessageBox.Show($"El código ORDE_P_inCODORD para la ordenanza seleccionada ({selectedOrdenanza}) es: {ORDE_P_inCODORD}", "Código de Ordenanza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ORDE_P_inCODORD = -1; // Indicador de valor no encontrado
                            MessageBox.Show($"No se encontró un código ORDE_P_inCODORD para la ordenanza seleccionada ({selectedOrdenanza}).", "Código de Ordenanza no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        private void btnBuscarInfra_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtNumDoc.Text))
                {
                    MessageBox.Show("Por favor, escriba un número de infracción antes de hacer la búsqueda.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del evento sin hacer la búsqueda
                }
                // Obtener el valor ingresado en el cuadro de texto txtInfraccion
                string codigoInfraccionBuscado = txtInfraccion.Text;

                // Consulta para buscar la infracción con el código especificado
                string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_11");
                string decryptedQuery = Decrypt(encryptedQuery);


                using (SqlConnection con = getCon())
                {
                    con.Open();

                    // Ejecutar la consulta y obtener los campos adicionales
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CodigoInfraccionBuscado", codigoInfraccionBuscado);
                        cmd.Parameters.AddWithValue("@CodInfraccion", ORDE_P_inCODORD);

                        // Leer los datos obtenidos de la consulta
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Obtener los valores de los campos
                                string nombreOrdenanza = reader["ORDE_chNROORD"].ToString();
                                string codigoInfraccion = reader["INMA_chCODINF"].ToString();
                                int codigoUniInfracc = Convert.ToInt32(reader["INMA_P_inCODINF"]);
                                string descripcionInfraccion = reader["INMA_chDESINF"].ToString();
                                decimal porcentajeInfraccion = Convert.ToDecimal(reader["INMA_dePORUIT"]);
                                string tipoValor = reader["TAMA_chDESTIP"].ToString();
                                decimal porcentajeObra = Convert.ToDecimal(reader["INMA_dePORUIT"]);
                                // Asignar los valores a los controles correspondientes
                                txtNumOrdenanza.Text = nombreOrdenanza;
                                txtInfraccion.Text = codigoInfraccion;
                                txtMotivoInfraccion.Text = descripcionInfraccion;
                                txtPorcentajeInfraccion.Text = porcentajeInfraccion.ToString();
                                textCodUniIfracc.Text = codigoUniInfracc.ToString();
                                codigoUniInfraccionActual = codigoUniInfracc;
                                cboTipInfracc.SelectedItem = tipoValor;
                                txtPorcentaje.Text = porcentajeObra.ToString();


                                MessageBox.Show("El tipo de valor es: " + tipoValor);
                                if (tipoValor == "PORCENTAJE")
                                {
                                    label22.Visible = true;
                                    txtValorUIT.Visible = true;
                                    label26.Visible = true;
                                    txtPorcentajeInfraccion.Visible = true;
                                    label24.Visible = true;
                                    label27.Visible = true;
                                    label23.Visible = true;
                                    label8.Visible = false;
                                    label9.Visible = false;
                                    txtValorObra.Visible = false;
                                    labelValorObraX.Visible = false;
                                    txtPorcentaje.Visible = false;
                                    txtPorcentajeObra.Visible = false;
                                    label24.Visible = true;


                                    if (decimal.TryParse(txtValorUIT.Text, out decimal valorUIT) && decimal.TryParse(txtPorcentajeInfraccion.Text, out decimal porcentaje))
                                    {
                                        decimal valorInfraccion = valorUIT * (porcentaje / 100);
                                        txtValorInfraccion.Text = valorInfraccion.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al calcular el valor de la infracción. Verifica los valores de UIT y porcentaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                                else if (tipoValor == "CANTIDAD")//digitado y un porcentaje adicional//fija UIT*numero
                                {
                                    label22.Visible = true;
                                    txtValorUIT.Visible = true;
                                    label26.Visible = true;
                                    txtPorcentajeInfraccion.Visible = true;
                                    label24.Visible = true;
                                    label27.Visible = true;
                                    label23.Visible = true;
                                    txtCantUIT.Visible = true;
                                    label8.Visible = true;
                                    label9.Visible = false;
                                    txtValorObra.Visible = false;
                                    labelValorObraX.Visible = false;
                                    txtPorcentaje.Visible = false;
                                    txtPorcentajeObra.Visible = false;

                                    if (decimal.TryParse(txtValorUIT.Text, out decimal valorUIT) && decimal.TryParse(txtPorcentajeInfraccion.Text, out decimal porcentaje) && int.TryParse(txtCantUIT.Text, out int cantidadUITS))
                                    {

                                        decimal valorInfraccion = cantidadUITS * valorUIT * (porcentaje / 100);
                                        txtValorInfraccion.Text = valorInfraccion.ToString();
                                        //MessageBox.Show("La notificación se ha guardado correctamente." + valorInfraccion, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al calcular el valor de la infracción. Verifica los valores de CANTIDAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else if (tipoValor == "VALOR DE OBRA")//digitado y un porcentaje adicional
                                {
                                    txtCantUIT.Visible = false;
                                    label8.Visible = false;
                                    label9.Visible = true;
                                    txtValorObra.Visible = true;
                                    label22.Visible = false;
                                    txtValorUIT.Visible = false;
                                    label26.Visible = false;
                                    txtPorcentajeInfraccion.Visible = false;
                                    label24.Visible = false;
                                    label27.Visible = false;
                                    label23.Visible = false;
                                    txtPorcentaje.Visible = true;
                                    labelValorObraX.Visible = true;
                                    txtPorcentajeObra.Visible = true;
                                    if (decimal.TryParse(txtValorUIT.Text, out decimal valorUIT) && decimal.TryParse(txtPorcentaje.Text, out decimal porcentaje) && decimal.TryParse(txtValorObra.Text, out decimal valorObra))
                                    {

                                        decimal valorInfraccion = valorObra * (porcentaje / 100);
                                        txtValorInfraccion.Text = valorInfraccion.ToString();
                                        //MessageBox.Show("La notificación se ha guardado correctamente." + valorInfraccion, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al calcular el valor de la infracción. Verifica los valores de VALOR OBRA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    //label9.Visible=false;
                                    //txtValorObra.Visible = false;
                                }
                                else if (tipoValor == "FIJO")//digitado
                                {
                                    MessageBox.Show("NO USAR, DESHABILITADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (tipoValor == "PORCENTAJE Y VALOR") //PREGUNTAR 
                                {
                                    MessageBox.Show("NO USAR, DESHABILITADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                // Cálculo del valor de la infracción


                                // También puedes asignar el valor de INMA_chCODINF a una variable si lo deseas.
                                string inmaChCodInf = reader["INMA_chCODINF"].ToString();

                                // Completa los demás campos con los datos de la base de datos
                                // ...
                            }
                            else
                            {
                                // Si no se encontró información para la infracción buscada, puedes mostrar un mensaje o manejarlo como desees.
                                MessageBox.Show("No se encontró información para la infracción buscada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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

        private bool CheckStatus(string numeroNotificacionValidar)
        {
            try
            {
                using (SqlConnection con = getCon())
                {
                    con.Open();

                    string selectQuery = "SELECT COUNT(*) FROM M_NOTC WHERE NOTC_chNRONOT=@numeroNotificacionValidar";

                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                    {
                        selectCmd.Parameters.AddWithValue("@numeroNotificacionValidar", numeroNotificacionValidar);

                        int count = Convert.ToInt32(selectCmd.ExecuteScalar());

                        // Si el count es mayor que 0, significa que la multa ya existe
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el estado de la multa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Devolver false en caso de error
            }
        }


        private void btnGuardarNOTIFIC_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroNotificacion = txtNumNIC.Text;
                string representanteLegal = txtRepresentanteLegal.Text;
                string anio = cboAnioNIC.Text;

                string auxNotificacion = "D";
                DateTime fechaRecibida = dtpFecRecp.Value;//HORA RECIBIDAD
                string fechaRecibidaFormateada = fechaRecibida.ToString("yyyyMMdd");
                DateTime horaNotificacion = dtpHoraNic.Value;// HORA DE NOTIFICACION
                string horaNotificacionFormateada = horaNotificacion.ToString("T");
                int codigoPersona = codigoPersonaEncontrada;
                int estado = 1;
                int codigoDireccionFiscal = codigoDireccion;
                int DireccionInfraccion = CodDir;
                int codigoActividad = guardaCodActi;
                int codigoInspec = codigoTecnico;
                string nombrePC = Environment.MachineName;
                DateTime fechaActual = DateTime.Now;
                string fechaFormateada = fechaActual.ToString("yyyy-MM-dd HH:mm");
                string nombreUsuario = DatosCompartidos.Usuario;


                if (string.IsNullOrWhiteSpace(numeroNotificacion))
                {
                    MessageBox.Show("El campo Número de Notificación no puede estar en blanco.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(representanteLegal))
                {
                    MessageBox.Show("El campo Representante Legal no puede estar en blanco.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*if (!Regex.IsMatch(representanteLegal, @"^[a-zA-Z0-9]+$"))
                {
                    MessageBox.Show("El campo Representante Legal solo puede contener letras y números, sin caracteres especiales ni espacios en blanco.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }*/

                //REVISAR BIEN 

                /*if (fechaNotificacion > fechaRecibida)
                {
                    MessageBox.Show("La fecha de Notificación de Infracción (NIC) no puede ser mayor a la fecha de recepción.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }*/

                if (string.IsNullOrWhiteSpace(txtNumDoc.Text))
                {
                    MessageBox.Show("El campo Número de Documento no puede estar en blanco.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textDirecFiscal.Text))
                {
                    MessageBox.Show("El campo Dirección Fiscal no puede estar en blanco.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("El campo Inspector no puede estar en blanco.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("El campo Actividad Comercial no puede estar en blanco.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(anio))
                {
                    MessageBox.Show("El campo Año no puede estar en blanco.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int numeroAnio;
                if (!int.TryParse(anio, out numeroAnio))
                {
                    MessageBox.Show("El valor ingresado en el campo Año no es un número válido.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que el año no sea mayor al año actual
                int anioActual = DateTime.Now.Year;
                if (numeroAnio > anioActual)
                {
                    MessageBox.Show("El año ingresado no puede ser mayor al año actual.", "Año inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que el año no tenga más de 4 cifras
                if (anio.Length > 4)
                {
                    MessageBox.Show("El año ingresado no puede tener más de 4 cifras.", "Año inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si llega hasta aquí, el año es válido y cumple con los criterios deseados, puedes continuar con el resto del código.

                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("El campo Dirección de Infracción de NIC no puede estar en blanco.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.IsMatch(anio, @"^\d{4}$"))
                {
                    MessageBox.Show("El valor ingresado en el campo Año no es válido. Debe contener exactamente 4 dígitos numéricos.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*
               int codigoUniInfraccion = Convert.ToInt32(textCodUniIfracc.Text);


               //string descripInfraccion = txtMotivoInfraccion.Text;
               //decimal valorInfraccion = decimal.Parse(txtValorInfraccion.Text);

               //string nombreUsuario = Environment.UserName;

                */
                using (SqlConnection con = getCon())
                {
                    con.Open();
                    using (SqlCommand cmdInsert = new SqlCommand("s_i_M_NOTC", con))
                    {
                        cmdInsert.CommandType = CommandType.StoredProcedure;

                        cmdInsert.Parameters.AddWithValue("@iNOTC_P_inCODNOT", 0);
                        cmdInsert.Parameters.AddWithValue("@iANIO_P_chCODANO", anio);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chNRONOT", numeroNotificacion);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chAUXNOT", auxNotificacion);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chFECNOT", fechaRecibidaFormateada);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chHORNOT", horaNotificacionFormateada);
                        cmdInsert.Parameters.AddWithValue("@iESMA_P_inCODEST", estado);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_inCODINF", codigoPersona);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_inCODDIF", codigoDireccionFiscal);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_inCODDIR", DireccionInfraccion);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chREPLEG", representanteLegal);
                        cmdInsert.Parameters.AddWithValue("@iACTI_P_inCODACT", codigoActividad);
                        cmdInsert.Parameters.AddWithValue("@iDEPE_P_inCODDEP", 2);
                        cmdInsert.Parameters.AddWithValue("@iTENO_P_inCODNOT", codigoInspec);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chNROPLA", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chOBSNOT", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chPREDES", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chFECDES", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chOBSDES", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_inDICCOD", 0);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chDICNRO", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chDICINF", " ");
                        cmdInsert.Parameters.AddWithValue("@iREDO_P_inCODRDO", 0);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chMOTANU", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chNROQUE", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_inCODQUE", 0);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chFECINF", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chHORINF", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_inRSDIRE", 0);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chHECVER", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chMANIFE", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chANALIS", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chMANTER", " ");
                        cmdInsert.Parameters.AddWithValue("@iNOTC_inESTURB", 0);
                        cmdInsert.Parameters.AddWithValue("@iNOTC_chNRORES", " ");
                        cmdInsert.Parameters.AddWithValue("@iSEGU_chUSULOG", nombrePC);
                        cmdInsert.Parameters.AddWithValue("@iSEGU_chUSUMAQ", nombreUsuario);
                        cmdInsert.Parameters.AddWithValue("@iSEGU_chUSUFEC", fechaFormateada);

                        SqlParameter outputParameter = new SqlParameter("@oRESULT", SqlDbType.VarChar, 10);
                        outputParameter.Direction = ParameterDirection.Output;
                        cmdInsert.Parameters.Add(outputParameter);

                        cmdInsert.ExecuteNonQuery();

                        string resultado = outputParameter.Value.ToString();

                        if (resultado == "0")
                        {
                            MessageBox.Show("Error al guardar la notificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //MessageBox.Show("La notificación se ha guardado correctamente." + resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            int resultado_1 = Convert.ToInt32(resultado);
                            //MessageBox.Show("Valor de código de notificación: " + resultado_1, "Código de notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la notificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


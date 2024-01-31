using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static WindowsFormsApp15.iniarSesion;

namespace WindowsFormsApp15
{
    public partial class RegistroInfractor : Form
    {
        // Variables para almacenar los valores seleccionados
        private int resultadosEncontrados = 0;
        private string encontrarDirecc;
        private string tipoPersonaSeleccionado;
        private string generoSeleccionado;
        private string tipoDocumentoSeleccionado;
        private string numeroDocumento;
        private string nombres;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string guardarCompleto;
        private string direccionFiscal;
        private int codPersEncontrado;
        private int codigoDireccionFiscal;
        private string nombrePersonaCompleto;
        private int codigoDireccion = -1;
        private int tipoDocumento = -1;
        private int codPer = 0;
        private int tipoViaSeleccionado = -1;


        public string guardarNombreCompleto { get { return nombrePersonaCompleto; } }

        public int guardarCodigoDireccionFiscal { get { return codigoDireccionFiscal; } }
        public int guardarCodigoPersona { get { return codPersEncontrado; } }
        public string guardarDireccionFiscal { get { return direccionFiscal; } }

        public string guardarTipoDoc { get { return tipoDocumentoSeleccionado; } }
        public string guardaCompletoNombre { get { return guardarCompleto; } }
        public string guardaDocum { get { return numeroDocumento; } }

        public RegistroInfractor()
        {
            InitializeComponent();
        }

        public RegistroInfractor(ref string guardaCompleto, string guardaDOC, string guardaDOCU, string guardaDirecFiscal, int guardaCodigoPersona, int guardaCodigoDireFiscal, string guardaNomCompleto)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            guardarCompleto = guardaCompleto;
            tipoDocumentoSeleccionado = guardaDOC;
            numeroDocumento = guardaDOCU;
            direccionFiscal = guardaDirecFiscal;
            codPersEncontrado = guardaCodigoPersona;
            codigoDireccionFiscal = guardaCodigoDireFiscal;
            nombrePersonaCompleto = guardaNomCompleto;
            this.FormClosed += RegistrarDireccionFiscal_FormClosed;
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }


        private void RegistrarDireccionFiscal_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verificar si se seleccionó una dirección y si el formulario se cerró de forma aceptada (OK)
            if (direccionFiscal != "-1" && codPersEncontrado != -1 && codigoDireccionFiscal != -1)
            {
                // Actualizar el valor de DireCodDir en el formulario RegistroNIC
                RegistroNIC formularioRegistroNIC = Application.OpenForms.OfType<RegistroNIC>().FirstOrDefault();
                if (formularioRegistroNIC != null)
                {
                    formularioRegistroNIC.guardaDirecFiscal = direccionFiscal;
                    formularioRegistroNIC.guardaCodigoPersona = codPersEncontrado;
                    formularioRegistroNIC.guardaCodigoDireFiscal = codigoDireccionFiscal;
                }
            }
        }
        // Método para obtener la conexión a la base de datos
        private SqlConnection GetConnection()
        {
            string connectionString = "Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$";
            return new SqlConnection(connectionString);
        }
        private void cboDireccionFiscal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDireccionFiscal.SelectedItem is ComboBoxItem selectedItem)
            {
                codigoDireccion = selectedItem.Value; // Actualiza el valor de codigoDireccion con el valor seleccionado en el ComboBox
                MessageBox.Show($"Código de la dirección seleccionada: {codigoDireccion}", "Código de Dirección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void RegistroInfractor_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            tipoDocumento = 1;
            cboDireccionFiscal.SelectedIndexChanged += cboDireccionFiscal_SelectedIndexChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar que haya un elemento seleccionado
            if (comboBox1.SelectedItem != null)
            {
                string tipoDocumentoSeleccionado = comboBox1.SelectedItem.ToString();
                if (tipoDocumentoSeleccionado == "DNI")
                {
                    tipoDocumento = 1;
                }
                else if (tipoDocumentoSeleccionado == "RUC")
                {
                    tipoDocumento = 2;
                }
                else if (tipoDocumentoSeleccionado == "CE")
                {
                    tipoDocumento = 6;
                }
                else if (tipoDocumentoSeleccionado == "PASAPORTE")
                {
                    tipoDocumento = 5;
                }

                // Mostrar el valor de tipoDocumento en un MessageBox
                //MessageBox.Show($"Valor de tipoDocumento: {tipoDocumento}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarDireccion_Click(object sender, EventArgs e)
        {
            // Limpiar el ComboBox antes de realizar la búsqueda
            cboDireccionFiscal.Items.Clear();

            encontrarDirecc = cboDireccionFiscal.Text;

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener todas las direcciones fiscales que coinciden con el texto ingresado
                    string queryDirecciones = "SELECT DIRE_P_inCODDIR, DIRE_chDESDIR FROM M_DIRE WHERE DIRE_chDESDIR LIKE '%' + @DireccionBuscada + '%'";
                    using (SqlCommand cmdDirecciones = new SqlCommand(queryDirecciones, con))
                    {
                        cmdDirecciones.Parameters.AddWithValue("@DireccionBuscada", encontrarDirecc);

                        SqlDataReader reader = cmdDirecciones.ExecuteReader();

                        while (reader.Read())
                        {
                            // Obtener el código y descripción de la dirección fiscal y agregarlos al ComboBox
                            int codigoDireccion = Convert.ToInt32(reader["DIRE_P_inCODDIR"]);
                            string direccion = reader["DIRE_chDESDIR"].ToString();
                            cboDireccionFiscal.Items.Add(new ComboBoxItem(direccion, codigoDireccion));
                            resultadosEncontrados++;
                        }
                    }
                }
                if (resultadosEncontrados > 0)
                {
                    cboDireccionFiscal.SelectedIndex = 0;
                }
                // Mostrar mensaje con el número de resultados encontrados
                //MessageBox.Show($"Se han encontrado {resultadosEncontrados} resultado(s) asociado(s) a la búsqueda.", "Resultados de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resultadosEncontrados = 0; // Reiniciar el contador de resultados

            }
            catch (Exception ex)
            {
                // Manejo de errores...
                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnRegisInfrac_Click(object sender, EventArgs e)
        {

            // Obtener los valores seleccionados en los ComboBox
            tipoPersonaSeleccionado = comboBox2.SelectedItem.ToString();
            generoSeleccionado = comboBox3.SelectedItem.ToString();
            tipoDocumentoSeleccionado = comboBox1.SelectedItem.ToString();

            // Obtener los valores ingresados en los TextBox
            numeroDocumento = textBox1.Text;
            nombres = textBox2.Text;
            apellidoPaterno = textBox3.Text;
            apellidoMaterno = textBox4.Text;
            int guardarCodigoUnicoDireccion = codigoDireccion;

            // Concatenar los apellidos y nombres en una variable
            string nombreCompleto = $"{apellidoPaterno} {apellidoMaterno} {nombres}";

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener la dirección fiscal asociada al DNI ingresado
                    string queryDireccion = "SELECT  M.PERS_chNOMCOM, MD.DIRE_chDESDIR AS Direccion, MD.DIRE_P_inCODDIR AS CodigoDireccion, M.PERS_P_inCODPER AS CodigoPersona " +
                        "FROM V_RELA_DOCU AS V " +
                        "INNER JOIN M_PERS AS M ON V.PERS_P_inCODPER = M.PERS_P_inCODPER " +
                        "INNER JOIN M_DIRE MD ON M.DIRE_P_inCODDIR = MD.DIRE_P_inCODDIR " +
                        "WHERE V.REDO_chNUMRED = @DniBuscado";

                    using (SqlCommand cmdDireccion = new SqlCommand(queryDireccion, con))
                    {
                        cmdDireccion.Parameters.AddWithValue("@DniBuscado", numeroDocumento);

                        SqlDataReader reader = cmdDireccion.ExecuteReader();

                        if (reader.Read())
                        {
                            // Obtener la dirección fiscal y guardarla en la variable direccionFiscal
                            direccionFiscal = reader["Direccion"].ToString();
                            // Obtener el código de dirección fiscal y guardarla en la variable codigoDireccionFiscal
                            codigoDireccionFiscal = Convert.ToInt32(reader["CodigoDireccion"]);
                            // Obtener el código de persona y guardarla en la variable codPersEncontrado
                            codPersEncontrado = Convert.ToInt32(reader["CodigoPersona"]);
                            nombrePersonaCompleto = reader["PERS_chNOMCOM"].ToString();
                        }
                        else
                        {
                            // Si no se encontró ninguna dirección, asignar un valor por defecto a la variable
                            direccionFiscal = "Dirección no encontrada";
                            // Asignar un valor por defecto a la variable codigoDireccionFiscal, por ejemplo, -1.
                            codigoDireccionFiscal = -1;
                            // Asignar un valor por defecto a la variable codPersEncontrado, por ejemplo, -1.
                            codPersEncontrado = -1;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                // Manejo de errores...
                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Realizar las acciones adicionales que necesites con los valores almacenados
            guardarCompleto = nombreCompleto;

            // Mostrar un mensaje con los valores seleccionados y el nombre completo
            string mensaje = $"Tipo de persona: {tipoPersonaSeleccionado}\n" +
                             $"Género: {generoSeleccionado}\n" +
                             $"Tipo de documento: {tipoDocumentoSeleccionado}\n" +
                             $"Número de documento: {numeroDocumento}\n" +
                             $"Nombre completo: {nombreCompleto}\n " +
                             $"Codigo Persona: {codPersEncontrado}\n" +
                             $"Codigo Direccion Fiscal:{guardarCodigoUnicoDireccion}";
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void MostrarTiposDeVias()
        {
            List<Tuple<int, string>> tiposDeVias = new List<Tuple<int, string>>();

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string queryTiposVias = "SELECT TIPO_P_inCODTIP, TIPO_chDESTIP FROM M_VIAS_TIPO";
                    using (SqlCommand cmdTiposVias = new SqlCommand(queryTiposVias, con))
                    {
                        SqlDataReader reader = cmdTiposVias.ExecuteReader();
                        while (reader.Read())
                        {
                            int tipoCod = Convert.ToInt32(reader["TIPO_P_inCODTIP"]);
                            string tipoNombre = reader["TIPO_chDESTIP"].ToString();
                            tiposDeVias.Add(new Tuple<int, string>(tipoCod, tipoNombre));
                        }
                    }
                }

                Form tipoViaForm = new Form();
                tipoViaForm.Text = "Selecciona un tipo de vía";
                tipoViaForm.Width = 300;
                tipoViaForm.Height = 300;

                ListBox listBoxTiposVias = new ListBox();
                listBoxTiposVias.Dock = DockStyle.Fill;
                foreach (var tipo in tiposDeVias)
                {
                    listBoxTiposVias.Items.Add(tipo.Item2);
                }
                tipoViaForm.Controls.Add(listBoxTiposVias);

                Button buttonAceptar = new Button();
                buttonAceptar.Text = "Aceptar";
                buttonAceptar.Dock = DockStyle.Bottom;
                buttonAceptar.Click += (sender, e) =>
                {
                    if (listBoxTiposVias.SelectedIndex != -1)
                    {
                        tipoViaSeleccionado = tiposDeVias[listBoxTiposVias.SelectedIndex].Item1;
                        tipoViaForm.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecciona un tipo de vía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                tipoViaForm.Controls.Add(buttonAceptar);

                tipoViaForm.ShowDialog();

                tipoViaForm.Dispose(); // Liberar recursos después de cerrar el formulario
            }
            catch (Exception ex)
            {
                // Manejo de errores...
                MessageBox.Show("Error al cargar los tipos de vías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Puedes agregar más validaciones según tus necesidades

            return true;
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            // Obtener los valores seleccionados en los ComboBox
            tipoPersonaSeleccionado = comboBox2.SelectedItem.ToString();
            generoSeleccionado = comboBox3.SelectedItem.ToString();
            tipoDocumentoSeleccionado = comboBox1.SelectedItem.ToString();

            // Obtener los valores ingresados en los TextBox
            numeroDocumento = textBox1.Text;
            nombres = textBox2.Text;
            apellidoPaterno = textBox3.Text;
            apellidoMaterno = textBox4.Text;
            int guardarCodigoUnicoDireccion = codigoDireccion;


            // Concatenar los apellidos y nombres en una variable
            string nombreCompleto = $"{apellidoPaterno} {apellidoMaterno} {nombres}";

            // Truncar las cadenas al primer carácter
            char primerCaracterTipoPersona = tipoPersonaSeleccionado[0];
            char primerCaracterGenero = generoSeleccionado[0];

            // Variable para almacenar el tipo de documento seleccionado en el ComboBox

            if (!ValidarCampos())
            {
                return; // No continuar si hay campos inválidos
            }

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para insertar un nuevo registro en la tabla M_PERS
                    string queryInsertPersona = "INSERT INTO M_PERS (PERS_chPATPER, PERS_chMATPER, PERS_chNOMPER, PERS_chNOMCOM, PERS_chTIPPER, PERS_chTIPSEX, PERS_chCODSIT, DIRE_P_inCODDIR, SEGU_chUSULOG, SEGU_chUSUMAQ, SEGU_chUSUFEC, ESTADO) " +
                        "VALUES (@ApellidoPaterno, @ApellidoMaterno, @Nombres, @NombreCompleto, @TipoPersonaSeleccionado, @GeneroSeleccionado, @TipoDocumentoSeleccionado, @CodigoDireccionFiscal, @UsuarioLog, @UsuarioMaq, @UsuarioFec, @Estado);" +
                        "SELECT SCOPE_IDENTITY();"; // Agregar la consulta para obtener el último valor de identidad generado

                    using (SqlCommand cmdInsertPersona = new SqlCommand(queryInsertPersona, con))
                    {
                        // Agregar los parámetros a la consulta para realizar la inserción
                        cmdInsertPersona.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                        cmdInsertPersona.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                        cmdInsertPersona.Parameters.AddWithValue("@Nombres", nombres);
                        cmdInsertPersona.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                        cmdInsertPersona.Parameters.AddWithValue("@TipoPersonaSeleccionado", primerCaracterTipoPersona);
                        cmdInsertPersona.Parameters.AddWithValue("@GeneroSeleccionado", primerCaracterGenero);
                        cmdInsertPersona.Parameters.AddWithValue("@TipoDocumentoSeleccionado", ' ');
                        cmdInsertPersona.Parameters.AddWithValue("@CodigoDireccionFiscal", guardarCodigoUnicoDireccion);
                        cmdInsertPersona.Parameters.AddWithValue("@UsuarioLog", DatosCompartidos.Usuario);
                        cmdInsertPersona.Parameters.AddWithValue("@UsuarioMaq", Environment.MachineName);
                        cmdInsertPersona.Parameters.AddWithValue("@UsuarioFec", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                        cmdInsertPersona.Parameters.AddWithValue("@Estado", 1);

                        // Ejecutar el comando de inserción en la tabla M_PERS
                        int codPer = Convert.ToInt32(cmdInsertPersona.ExecuteScalar()); // Obtener el último valor de identidad generado (PERS_P_inCODPER)
                        //MessageBox.Show("Datos registrados correctamente en las tablas codPer." + codPer, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Consulta para insertar un nuevo registro en la tabla V_RELA_DOCU
                        string queryInsertRelaDocu = "INSERT INTO V_RELA_DOCU (PERS_P_inCODPER, TIDO_P_inCODTID, REDO_chNUMRED,SEGU_chUSULOG, SEGU_chUSUMAQ, SEGU_chUSUFEC, ESTADO) " +
                            "VALUES (@CodPer, @TipoDocumento, @NumRed,@Usuario, @UsuarioMaq, @UsuarioFec, @Estado)";

                        using (SqlCommand cmdInsertRelaDocu = new SqlCommand(queryInsertRelaDocu, con))
                        {
                            // Agregar los parámetros a la consulta para realizar la inserción en la tabla V_RELA_DOCU
                            //cmdInsertRelaDocu.Parameters.AddWithValue("@CodRed", 0);
                            cmdInsertRelaDocu.Parameters.AddWithValue("@CodPer", codPer); // Usar el valor obtenido de la primera consulta
                            cmdInsertRelaDocu.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                            cmdInsertRelaDocu.Parameters.AddWithValue("@NumRed", numeroDocumento);
                            cmdInsertRelaDocu.Parameters.AddWithValue("@Usuario", DatosCompartidos.Usuario);
                            cmdInsertRelaDocu.Parameters.AddWithValue("@UsuarioMaq", Environment.MachineName);
                            cmdInsertRelaDocu.Parameters.AddWithValue("@UsuarioFec", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                            cmdInsertRelaDocu.Parameters.AddWithValue("@Estado", 1);

                            // Ejecutar el comando de inserción en la tabla V_RELA_DOCU
                            cmdInsertRelaDocu.ExecuteNonQuery();
                        }
                        string queryDireccion = "SELECT  M.PERS_chNOMCOM, MD.DIRE_chDESDIR AS Direccion, MD.DIRE_P_inCODDIR AS CodigoDireccion, M.PERS_P_inCODPER AS CodigoPersona " +
                       "FROM V_RELA_DOCU AS V " +
                       "INNER JOIN M_PERS AS M ON V.PERS_P_inCODPER = M.PERS_P_inCODPER " +
                       "INNER JOIN M_DIRE MD ON M.DIRE_P_inCODDIR = MD.DIRE_P_inCODDIR " +
                       "WHERE V.REDO_chNUMRED = @numeroDocumento";

                        using (SqlCommand cmdDireccion = new SqlCommand(queryDireccion, con))
                        {
                            cmdDireccion.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);

                            SqlDataReader reader = cmdDireccion.ExecuteReader();

                            if (reader.Read())
                            {
                                // Obtener la dirección fiscal y guardarla en la variable direccionFiscal
                                direccionFiscal = reader["Direccion"].ToString();
                                // Obtener el código de dirección fiscal y guardarla en la variable codigoDireccionFiscal
                                codigoDireccionFiscal = Convert.ToInt32(reader["CodigoDireccion"]);
                                // Obtener el código de persona y guardarla en la variable codPersEncontrado
                                codPersEncontrado = Convert.ToInt32(reader["CodigoPersona"]);
                                nombrePersonaCompleto = reader["PERS_chNOMCOM"].ToString();
                            }
                            else
                            {
                                // Si no se encontró ninguna dirección, asignar un valor por defecto a la variable
                                direccionFiscal = "Dirección no encontrada";
                                // Asignar un valor por defecto a la variable codigoDireccionFiscal, por ejemplo, -1.
                                codigoDireccionFiscal = -1;
                                // Asignar un valor por defecto a la variable codPersEncontrado, por ejemplo, -1.
                                codPersEncontrado = -1;
                            }
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Datos registrados correctamente en las tablas M_PERS y V_RELA_DOCU.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores...
                MessageBox.Show("Error al insertar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Realizar las acciones adicionales que necesites con los valores almacenados
            guardarCompleto = nombreCompleto;

            // Mostrar un mensaje con los valores seleccionados y el nombre completo
            string mensaje = $"Tipo de persona: {primerCaracterTipoPersona}\n" +
                             $"Género: {primerCaracterGenero}\n" +
                             $"Tipo de documento: {tipoDocumentoSeleccionado}\n" +
                             $"Número de documento: {numeroDocumento}\n" +
                             $"Nombre completo: {nombreCompleto}\n " +
                             $"Codigo Persona: {codPer}\n" +
                             $"Codigo Direccion Fiscal: {guardarCodigoUnicoDireccion}";
            //MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        //EN CONSTRUCCIÓN
        private Form CrearFormulario(string titulo, List<string> opciones)
        {
            Form formulario = new Form();
            formulario.Text = titulo;
            formulario.Width = 300;
            formulario.Height = 300;

            ListBox listBoxOpciones = new ListBox();
            listBoxOpciones.Dock = DockStyle.Fill;
            foreach (var opcion in opciones)
            {
                listBoxOpciones.Items.Add(opcion);
            }
            formulario.Controls.Add(listBoxOpciones);

            Button buttonAceptar = new Button();
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.Dock = DockStyle.Bottom;
            buttonAceptar.Click += (sender, e) =>
            {
                if (listBoxOpciones.SelectedIndex != -1)
                {
                    formulario.Tag = listBoxOpciones.SelectedItem.ToString();
                    formulario.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una opción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            formulario.Controls.Add(buttonAceptar);

            return formulario;
        }
        private string MostrarDepartamentos()
        {
            List<string> departamentos = new List<string>();

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string queryDepartamentos = "SELECT DISTINCT UBIG_chDESDEP FROM M_UBIG";
                    using (SqlCommand cmdDepartamentos = new SqlCommand(queryDepartamentos, con))
                    {
                        SqlDataReader reader = cmdDepartamentos.ExecuteReader();
                        while (reader.Read())
                        {
                            string departamento = reader["UBIG_chDESDEP"].ToString();
                            departamentos.Add(departamento);
                        }
                    }
                }

                departamentos.Sort(); // Ordenar alfabéticamente

                Form formulario = CrearFormulario("Selecciona un departamento", departamentos);
                DialogResult result = formulario.ShowDialog();

                if (result == DialogResult.OK && formulario.Tag != null)
                {
                    return formulario.Tag.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los departamentos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private string MostrarProvincias(string selectedDepartamento)
        {
            List<string> provincias = new List<string>();

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string queryProvincias = "SELECT DISTINCT UBIG_chDESPRV FROM M_UBIG WHERE UBIG_chDESDEP = @Departamento";
                    using (SqlCommand cmdProvincias = new SqlCommand(queryProvincias, con))
                    {
                        cmdProvincias.Parameters.AddWithValue("@Departamento", selectedDepartamento);
                        SqlDataReader reader = cmdProvincias.ExecuteReader();
                        while (reader.Read())
                        {
                            string provincia = reader["UBIG_chDESPRV"].ToString();
                            provincias.Add(provincia);
                        }
                    }
                }

                provincias.Sort(); // Ordenar alfabéticamente

                Form formulario = CrearFormulario("Selecciona una provincia", provincias);
                DialogResult result = formulario.ShowDialog();

                if (result == DialogResult.OK && formulario.Tag != null)
                {
                    return formulario.Tag.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las provincias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private int MostrarDistritos(string selectedProvincia)
        {
            List<Tuple<int, string>> distritos = new List<Tuple<int, string>>();

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string queryDistritos = "SELECT UBIG_P_inCODUBI, UBIG_chDESDIS FROM M_UBIG WHERE UBIG_chDESPRV = @Provincia";
                    using (SqlCommand cmdDistritos = new SqlCommand(queryDistritos, con))
                    {
                        cmdDistritos.Parameters.AddWithValue("@Provincia", selectedProvincia);
                        SqlDataReader reader = cmdDistritos.ExecuteReader();
                        while (reader.Read())
                        {
                            int distritoCod = Convert.ToInt32(reader["UBIG_P_inCODUBI"]);
                            string distritoNombre = reader["UBIG_chDESDIS"].ToString();
                            distritos.Add(new Tuple<int, string>(distritoCod, distritoNombre));
                        }
                    }
                }

                distritos.Sort((x, y) => x.Item2.CompareTo(y.Item2)); // Ordenar alfabéticamente por nombre de distrito

                Form formulario = CrearFormulario("Selecciona un distrito", distritos.Select(t => t.Item2).ToList());
                DialogResult result = formulario.ShowDialog();

                if (result == DialogResult.OK && formulario.Tag != null)
                {
                    return distritos.Find(t => t.Item2 == formulario.Tag.ToString()).Item1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los distritos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1;
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            // Mostrar cuadro de diálogo para ingresar la dirección
            string direccion = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la dirección:", "Agregar Dirección", "");
            string distrito = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el distrito:", "Agregar Distrito", "");
            string referencia = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una referencia:", "Agregar Referencia", "");
            MostrarTiposDeVias();
            string departamentoSeleccionado = MostrarDepartamentos();
            if (string.IsNullOrEmpty(departamentoSeleccionado))
            {
                MessageBox.Show("Debe seleccionar un departamento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string provinciaSeleccionada = MostrarProvincias(departamentoSeleccionado);
            if (string.IsNullOrEmpty(provinciaSeleccionada))
            {
                MessageBox.Show("Debe seleccionar una provincia válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ubigCod = MostrarDistritos(provinciaSeleccionada);
            if (ubigCod == -1)
            {
                MessageBox.Show("Debe seleccionar un distrito válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(distrito))
            {
                try
                {
                    using (SqlConnection con = GetConnection())
                    {
                        con.Open();

                        // Insertar en la tabla M_VIAS
                        string queryInsertVias = "INSERT INTO M_VIAS (UBIG_P_inCODUBI, TIPO_P_inCODTIP, VIAS_chDESVIA, SEGU_chUSULOG, SEGU_chUSUMAQ, SEGU_chUSUFEC, ESTADO) " +
                            "VALUES (@CodigoUbi, @CodigoTip, @DescripcionVia, @UsuarioLog, @UsuarioMaq, @UsuarioFec, @Estado); SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmdInsertVias = new SqlCommand(queryInsertVias, con))
                        {
                            cmdInsertVias.Parameters.AddWithValue("@CodigoUbi", ubigCod);
                            cmdInsertVias.Parameters.AddWithValue("@CodigoTip", tipoViaSeleccionado);
                            cmdInsertVias.Parameters.AddWithValue("@DescripcionVia", direccion);
                            cmdInsertVias.Parameters.AddWithValue("@UsuarioLog", DatosCompartidos.Usuario);
                            cmdInsertVias.Parameters.AddWithValue("@UsuarioMaq", Environment.MachineName);
                            cmdInsertVias.Parameters.AddWithValue("@UsuarioFec", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                            cmdInsertVias.Parameters.AddWithValue("@Estado", 1);

                            // Ejecutar el comando de inserción en la tabla M_VIAS y obtener el ID insertado
                            int codVia = Convert.ToInt32(cmdInsertVias.ExecuteScalar());
                            //MessageBox.Show("Valor de código de notificación: " + codVia, "Código de notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Insertar en la tabla M_DIRE
                            string queryInsertDire = "INSERT INTO M_DIRE (VIAS_P_inCODVIA, DIRE_chDESDIR, DIRE_chDESAGR, DIRE_chDESREF, DIRE_chDESUBI, SEGU_chUSULOG, SEGU_chUSUMAQ, SEGU_chUSUFEC, ESTADO) " +
                                "VALUES (@CodigoVia, @Direccion, @Distrito, @Referencia, @Distrito, @UsuarioLog, @UsuarioMaq, @UsuarioFec, @Estado);";

                            using (SqlCommand cmdInsertDire = new SqlCommand(queryInsertDire, con))
                            {
                                cmdInsertDire.Parameters.AddWithValue("@CodigoVia", codVia);
                                cmdInsertDire.Parameters.AddWithValue("@Direccion", direccion);
                                cmdInsertDire.Parameters.AddWithValue("@Distrito", distrito);
                                cmdInsertDire.Parameters.AddWithValue("@Referencia", referencia);
                                cmdInsertDire.Parameters.AddWithValue("@UsuarioLog", DatosCompartidos.Usuario);
                                cmdInsertDire.Parameters.AddWithValue("@UsuarioMaq", Environment.MachineName);
                                cmdInsertDire.Parameters.AddWithValue("@UsuarioFec", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                                cmdInsertDire.Parameters.AddWithValue("@Estado", 1);

                                // Ejecutar el comando de inserción en la tabla M_DIRE
                                cmdInsertDire.ExecuteNonQuery();

                                MessageBox.Show("Dirección agregada correctamente en las tablas M_DIRE y M_VIAS.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    // Actualizar el ComboBox con la nueva dirección
                    cboDireccionFiscal.Items.Add(direccion);
                    cboDireccionFiscal.SelectedItem = direccion; // Seleccionar la nueva dirección en el ComboBox
                }
                catch (Exception ex)
                {
                    // Manejo de errores...
                    MessageBox.Show("Error al insertar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

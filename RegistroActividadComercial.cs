using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static WindowsFormsApp15.iniarSesion;

namespace WindowsFormsApp15
{
    public partial class RegistroActividadComercial : Form
    {
        private string NombreActivCom;
        private int guardarCodiActi;
        public int GuardarCodigoActividad { get { return guardarCodiActi; } }
        public string NombreActividadComercial { get { return NombreActivCom; } }

        public RegistroActividadComercial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnGuarActi.Visible = false;
        }

        public RegistroActividadComercial(ref string NombreActividad, int guardaCodActi)
        {
            InitializeComponent();
            // Inicializa el DataGridView
            dataGridView1.AutoGenerateColumns = true;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            NombreActivCom = NombreActividad;
            guardarCodiActi = guardaCodActi;
            this.FormClosed += RegistrarCodigoActividad_FormClosed;
        }
        private void RegistrarCodigoActividad_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verificar si se seleccionó una dirección y si el formulario se cerró de forma aceptada (OK)
            if (guardarCodiActi != -1)
            {
                // Actualizar el valor de DireCodDir en el formulario RegistroNIC
                RegistroNIC formularioRegistroNIC = Application.OpenForms.OfType<RegistroNIC>().FirstOrDefault();
                if (formularioRegistroNIC != null)
                {
                    formularioRegistroNIC.guardaCodActi = guardarCodiActi;
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Verificar si es la fila de encabezados (HeaderCell) y si es la primera fila
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // Nombre de la columna actual
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                // Formatear el nombre de la columna "ACTI_P_inCODACT" a "CÓDIGO"
                if (columnName == "ACTI_P_inCODACT")
                {
                    e.PaintBackground(e.CellBounds, true);
                    e.Graphics.DrawString("CÓDIGO", e.CellStyle.Font, Brushes.Black, e.CellBounds, StringFormat.GenericDefault);
                    e.Handled = true; // Indicar que se ha pintado el encabezado
                }

                // Formatear el nombre de la columna "ACTI_chDESACT" a "ACTIVIDAD"
                if (columnName == "ACTI_chDESACT")
                {
                    e.PaintBackground(e.CellBounds, true);
                    e.Graphics.DrawString("ACTIVIDAD", e.CellStyle.Font, Brushes.Black, e.CellBounds, StringFormat.GenericDefault);
                    e.Handled = true; // Indicar que se ha pintado el encabezado
                }

                // Formatear el nombre de la columna "SEGU_chUSULOG" a "USUARIO"
                if (columnName == "SEGU_chUSULOG")
                {
                    e.PaintBackground(e.CellBounds, true);
                    e.Graphics.DrawString("USUARIO", e.CellStyle.Font, Brushes.Black, e.CellBounds, StringFormat.GenericDefault);
                    e.Handled = true; // Indicar que se ha pintado el encabezado
                }

                // Formatear el nombre de la columna "SEGU_chUSUMAQ" a "MAQUINA"
                if (columnName == "SEGU_chUSUMAQ")
                {
                    e.PaintBackground(e.CellBounds, true);
                    e.Graphics.DrawString("MAQUINA", e.CellStyle.Font, Brushes.Black, e.CellBounds, StringFormat.GenericDefault);
                    e.Handled = true; // Indicar que se ha pintado el encabezado
                }
            }
        }

        private void btnBuscarAct(object sender, EventArgs e)
        {
            try
            {
                // Obtener el texto ingresado en el cuadro de texto txtActiviCom
                string actividadComercialBuscada = txtActivCom.Text.Trim();

                // Verificar si el cuadro de texto está vacío
                /*if (string.IsNullOrEmpty(actividadComercialBuscada))
                {
                    MessageBox.Show("Debes ingresar el nombre de la actividad comercial a buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }*/

                // Consulta para buscar la actividad comercial en la base de datos con estado 1
                string query = "SELECT ACTI_P_inCODACT, ACTI_chDESACT, SEGU_chUSULOG, SEGU_chUSUMAQ FROM M_ACTI WHERE ACTI_chDESACT LIKE @ActividadComercialBuscada AND ESTADO = 1";

                using (SqlConnection con = new SqlConnection("Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$"))
                {
                    con.Open();

                    // Ejecutar la consulta y obtener los resultados en un DataTable
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ActividadComercialBuscada", "%" + actividadComercialBuscada + "%");
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        // Llenar el DataGridView con los resultados de la consulta
                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoResizeColumns();

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Se encontraron actividades comerciales.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Si no se encontró ninguna actividad comercial, mostrar un mensaje
                            MessageBox.Show("No se encontraron actividades comerciales con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void dataGridFomat(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Implementa el formato que desees para las celdas del DataGridView
            if (e.ColumnIndex == dataGridView1.Columns["ACTI_chDESACT"].Index && e.Value != null)
            {
                e.Value = FormatearTexto(e.Value.ToString());
                e.FormattingApplied = true;
            }
        }

        // Función para aplicar formato al texto de la celda
        private string FormatearTexto(string texto)
        {
            // Implementa el formato que desees para el texto
            return texto.ToUpper();
        }

        private void btnGuardActClick(object sender, EventArgs e)
        {
            // Verificar si hay filas seleccionadas en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el nombre de la actividad comercial de la fila seleccionada
                NombreActivCom = dataGridView1.SelectedRows[0].Cells["ACTI_chDESACT"].Value.ToString();

                // Obtener el valor del código de la actividad comercial de la fila seleccionada
                object codigoActividad = dataGridView1.SelectedRows[0].Cells["ACTI_P_inCODACT"].Value;
                if (codigoActividad != null && int.TryParse(codigoActividad.ToString(), out int codigo))
                {
                    guardarCodiActi = codigo;
                }
                else
                {
                    // Manejar el caso en que no se pueda obtener el código de la actividad comercial
                    MessageBox.Show("No se pudo obtener el código de la actividad comercial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar el valor del código de la actividad comercial en un MessageBox
                // MessageBox.Show("Código de la actividad comercial: " + guardarCodiActi, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una actividad comercial.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CargarActividadesComerciales()
        {
            try
            {
                // Consulta para obtener solo las actividades comerciales con estado distinto de 0
                string query = "SELECT ACTI_P_inCODACT, ACTI_chDESACT, SEGU_chUSULOG, SEGU_chUSUMAQ FROM M_ACTI WHERE ESTADO <> 0";

                using (SqlConnection con = new SqlConnection("Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$"))
                {
                    con.Open();

                    // Ejecutar la consulta y obtener los resultados en un DataTable
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        // Llenar el DataGridView con los resultados de la consulta
                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoResizeColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de que ocurra un error, puedes manejarlo aquí
                // Por ejemplo, mostrar un mensaje de error o registrar el error en un archivo de log
                MessageBox.Show("Error al cargar las actividades comerciales desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAñadACTI_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para agregar una nueva actividad comercial
            FormNuevaActividadComercial formNuevaActividadComercial = new FormNuevaActividadComercial();
            string nombreUsuario = DatosCompartidos.Usuario;

            if (formNuevaActividadComercial.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$"))
                    {
                        con.Open();

                        using (SqlCommand cmdInsertActividad = new SqlCommand("s_i_M_ACTI", con))
                        {
                            cmdInsertActividad.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros de entrada al stored procedure
                            cmdInsertActividad.Parameters.AddWithValue("@iACTI_P_inCODACT", 0); // El valor 0 porque parece ser un parámetro de entrada
                            cmdInsertActividad.Parameters.AddWithValue("@iACTI_chDESACT", formNuevaActividadComercial.DescripcionActividad);
                            cmdInsertActividad.Parameters.AddWithValue("@iSEGU_chUSULOG", nombreUsuario);
                            cmdInsertActividad.Parameters.AddWithValue("@iSEGU_chUSUMAQ", Environment.MachineName);
                            cmdInsertActividad.Parameters.AddWithValue("@iSEGU_chUSUFEC", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

                            // Agregar el parámetro de salida al stored procedure
                            SqlParameter outputParameter = new SqlParameter("@oRESULT", SqlDbType.VarChar, 10);
                            outputParameter.Direction = ParameterDirection.Output;
                            cmdInsertActividad.Parameters.Add(outputParameter);

                            // Ejecutar el stored procedure
                            cmdInsertActividad.ExecuteNonQuery();

                            // Obtener el valor de retorno del procedimiento
                            string resultado = outputParameter.Value.ToString();

                            // Verificar el valor de resultado según tu lógica de negocio
                            if (resultado == "0")
                            {
                                // Mostrar mensaje de éxito
                                MessageBox.Show("Error al guardar la actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                // Actualizar el DataGridView con las actividades comerciales
                                CargarActividadesComerciales();
                            }
                            else
                            {
                                // Manejar el resultado en caso de error
                                MessageBox.Show("La actividad se ha guardado correctamente." + resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores...
                    MessageBox.Show("Error al insertar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnEditarActiClick(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la descripción actual de la actividad comercial seleccionada
                string descripcionActual = dataGridView1.SelectedRows[0].Cells["ACTI_chDESACT"].Value.ToString();

                // Mostrar un cuadro de diálogo para que el usuario ingrese la nueva descripción
                string nuevaDescripcion = Interaction.InputBox("Ingrese la nueva descripción de la actividad:", "Editar actividad comercial", descripcionActual);

                string nombrePC = Environment.MachineName;
                string nombreUsuario = DatosCompartidos.Usuario;
                // Verificar si se ingresó una nueva descripción
                if (!string.IsNullOrEmpty(nuevaDescripcion))
                {
                    // Obtener el código de la actividad comercial seleccionada
                    int codigoActividad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ACTI_P_inCODACT"].Value);

                    // Realizar el UPDATE en la base de datos para modificar la descripción de la actividad comercial
                    try
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$"))
                        {
                            con.Open();

                            // Consulta para actualizar la descripción de la actividad comercial
                            string queryUpdateActividad = "UPDATE M_ACTI SET ACTI_chDESACT = @NuevaDescripcion, SEGU_chUSULOG = @Usuario, SEGU_chUSUMAQ = @Maquina, SEGU_chUSUFEC = @Fecha WHERE ACTI_P_inCODACT = @CodigoActividad";

                            using (SqlCommand cmdUpdateActividad = new SqlCommand(queryUpdateActividad, con))
                            {
                                // Agregar los parámetros a la consulta para realizar la actualización
                                cmdUpdateActividad.Parameters.AddWithValue("@NuevaDescripcion", nuevaDescripcion);
                                cmdUpdateActividad.Parameters.AddWithValue("@Usuario", nombreUsuario); // Reemplaza "TEST" por el valor adecuado
                                cmdUpdateActividad.Parameters.AddWithValue("@Maquina", nombrePC); // Reemplaza "TU PC TEST" por el valor adecuado
                                cmdUpdateActividad.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                                cmdUpdateActividad.Parameters.AddWithValue("@CodigoActividad", codigoActividad);

                                // Ejecutar el comando de actualización en la tabla M_ACTI
                                cmdUpdateActividad.ExecuteNonQuery();
                            }
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Descripción de la actividad comercial actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el DataGridView con las actividades comerciales
                        CargarActividadesComerciales();
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores...
                        MessageBox.Show("Error al actualizar la descripción en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una actividad comercial para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnElimActi_Click(object sender, EventArgs e)
        {
            string nombrePC = Environment.MachineName;
            string nombreUsuario = DatosCompartidos.Usuario;
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el código de la actividad comercial seleccionada
                int codigoActividad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ACTI_P_inCODACT"].Value);

                // Mostrar un cuadro de diálogo para confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta actividad comercial?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Realizar el UPDATE en la base de datos para cambiar el estado de la actividad comercial
                    try
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$"))
                        {
                            con.Open();

                            // Consulta para actualizar el estado de la actividad comercial a 0 (inactivo)
                            string queryUpdateEstado = "UPDATE M_ACTI SET ESTADO = 0, SEGU_chUSULOG = @Usuario, SEGU_chUSUMAQ = @Maquina, SEGU_chUSUFEC = @Fecha WHERE ACTI_P_inCODACT = @CodigoActividad";

                            using (SqlCommand cmdUpdateEstado = new SqlCommand(queryUpdateEstado, con))
                            {
                                // Agregar los parámetros a la consulta para realizar la actualización
                                cmdUpdateEstado.Parameters.AddWithValue("@Usuario", nombreUsuario); // Reemplaza "TEST" por el valor adecuado
                                cmdUpdateEstado.Parameters.AddWithValue("@Maquina", nombrePC); // Reemplaza "TU PC TEST" por el valor adecuado
                                cmdUpdateEstado.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString());
                                cmdUpdateEstado.Parameters.AddWithValue("@CodigoActividad", codigoActividad);

                                // Ejecutar el comando de actualización en la tabla M_ACTI
                                cmdUpdateEstado.ExecuteNonQuery();
                            }
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show("La actividad comercial ha sido eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el DataGridView con las actividades comerciales
                        CargarActividadesComerciales();
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores...
                        MessageBox.Show("Error al eliminar la actividad comercial en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una actividad comercial para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

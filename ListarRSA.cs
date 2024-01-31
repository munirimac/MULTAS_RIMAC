using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class ListarRSA : Form
    {
        public ListarRSA()
        {
            InitializeComponent();
            comboBoxIngresos.Items.Add("SUB GERENCIA DE CONTROL Y SANCIONES");
            comboBoxIngresos.Items.Add("SUB GERENCIA DE SEGURIDAD VIAL Y TRANSPORTES");

        }

        private SqlConnection GetConnection()
        {
            string connectionString = "Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$";
            return new SqlConnection(connectionString);
        }
        private void BuscarIngresos(object sender, EventArgs e)
        {
            // Obtiene las fechas seleccionadas
            DateTime fechaInicio = dateTimePicker1.Value;
            DateTime fechaFin = dateTimePicker2.Value;

            // Obtiene la subgerencia seleccionada en el ComboBox
            string subgerenciaSeleccionada = comboBoxIngresos.SelectedItem as string;

            // Verifica que se haya seleccionado una subgerencia
            if (subgerenciaSeleccionada != null)
            {
                // Obtiene el código de subgerencia según la selección
                int codigoSubgerencia = subgerenciaSeleccionada == "SUB GERENCIA DE CONTROL Y SANCIONES" ? 2 : 3;

                // Abre la conexión
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Crea la consulta SQL con las fechas y el código de subgerencia
                    string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_5");
                    string decryptedQuery = Decrypt(encryptedQuery);

                    // Crea un objeto SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asigna los parámetros de la consulta
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", fechaFin);
                        command.Parameters.AddWithValue("@CodigoSubgerencia", codigoSubgerencia);

                        // Crea un objeto SqlDataAdapter para ejecutar la consulta y llenar un DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Muestra los resultados en el dataGridView1
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una subgerencia antes de buscar.");
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Datos");

                // Agregar encabezados de columnas
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                }

                // Agregar datos de las filas
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        object cellValue = dataGridView1.Rows[i].Cells[j].Value;
                        string cellText = cellValue != null ? cellValue.ToString() : "";
                        IXLCell cell = worksheet.Cell(i + 2, j + 1);
                        cell.Value = cellText;

                        // Establecer estilo de altura de la celda
                        cell.Style.Alignment.WrapText = true; // Asegura que el texto se ajuste en la celda
                        cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Top; // Alinea el texto en la parte superior
                    }
                }

                // Ajustar el ancho de las columnas automáticamente según el contenido
                worksheet.ColumnsUsed().AdjustToContents();

                // Ruta del archivo temporal
                string tempFilePath = System.IO.Path.GetTempFileName() + ".xlsx";

                workbook.SaveAs(tempFilePath);

                // Abrir el archivo con la aplicación predeterminada
                Process.Start(tempFilePath);
            }

            MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

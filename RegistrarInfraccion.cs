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

namespace WindowsFormsApp15
{
    public partial class RegistrarInfraccion : Form
    {
        private string DireccionGuardada; // Variable para almacenar el ID de la dirección seleccionada
        private int DireCodDir;
        public int DireCodDireccion { get { return DireCodDir; } }
        public string DireccionSeleccionada
        {
            get { return DireccionGuardada; }
        }
        public RegistrarInfraccion()
        {
            InitializeComponent();
        }
        public RegistrarInfraccion(ref string NombreInfraccion, int CodDir)
        {
            InitializeComponent();
            dataGridView_Infrac.AutoGenerateColumns = true;
            DireCodDir = CodDir;
            DireccionGuardada = NombreInfraccion;
            foreach (DataGridViewColumn column in dataGridView_Infrac.Columns)
            {
                column.ReadOnly = true;
            }
            dataGridView_Infrac.CellPainting += dataGridView_Infrac_CellPainting; // Agrega solo este evento
            this.FormClosed += RegistrarInfraccion_FormClosed;
        }


        private void RegistrarInfraccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verificar si se seleccionó una dirección y si el formulario se cerró de forma aceptada (OK)
            if (DireCodDir != -1)
            {
                // Actualizar el valor de DireCodDir en el formulario RegistroNIC
                RegistroNIC formularioRegistroNIC = Application.OpenForms.OfType<RegistroNIC>().FirstOrDefault();
                if (formularioRegistroNIC != null)
                {
                    formularioRegistroNIC.CodDir = DireCodDir;
                }
            }
        }



        // Agrega este evento al formulario
        private void dataGridView_Infrac_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Verificar si es la fila de encabezados (HeaderCell) y si es la primera fila
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // Nombre de la columna actual
                string columnName = dataGridView_Infrac.Columns[e.ColumnIndex].Name;

                // Formatear el nombre de la columna "DIRE_P_inCODDIR" a "Código"
                if (columnName == "DIRE_P_inCODDIR")
                {
                    e.PaintBackground(e.CellBounds, true);
                    e.Graphics.DrawString("CÓDIGO", e.CellStyle.Font, Brushes.Black, e.CellBounds, StringFormat.GenericDefault);
                    e.Handled = true; // Indicar que se ha pintado el encabezado
                }

                // Formatear el nombre de la columna "DIRE_chDESDIR" a "Dirección"
                if (columnName == "DIRE_chDESDIR")
                {
                    e.PaintBackground(e.CellBounds, true);
                    e.Graphics.DrawString("DIRECCIÓN", e.CellStyle.Font, Brushes.Black, e.CellBounds, StringFormat.GenericDefault);
                    e.Handled = true; // Indicar que se ha pintado el encabezado
                }

                if (columnName == "RENU_chVALNUM")
                {
                    e.PaintBackground(e.CellBounds, true);
                    e.Graphics.DrawString("VALOR", e.CellStyle.Font, Brushes.Black, e.CellBounds, StringFormat.GenericDefault);
                    e.Handled = true; // Indicar que se ha pintado el encabezado
                }

                if (columnName == "PRED_P_inCODPRE")
                {
                    e.PaintBackground(e.CellBounds, true);
                    e.Graphics.DrawString("COD.DIRECCIÓN", e.CellStyle.Font, Brushes.Black, e.CellBounds, StringFormat.GenericDefault);
                    e.Handled = true; // Indicar que se ha pintado el encabezado
                }
                //RENU_chVALNUM
            }
        }
        private void btnBuscarDirecClick(object sender, EventArgs e)
        {
            try
            {
                string direccionBuscada = txtBuscarDirec.Text.Trim(); // Obtener el texto de búsqueda

                // Consulta para buscar la dirección en la base de datos
                string query = "SELECT DIRE_P_inCODDIR, DIRE_chDESDIR FROM M_DIRE WHERE DIRE_chDESDIR LIKE '%' + @DireccionBuscada + '%' AND DIRE_chDESDIR!=' ' AND DIRE_chDESDIR!='-'";

                using (SqlConnection con = new SqlConnection("Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$"))
                {
                    con.Open();

                    // Ejecutar la consulta y obtener los resultados en un DataTable
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DireccionBuscada", direccionBuscada);

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        // Llenar el DataGridView con los resultados de la consulta
                        dataGridView_Infrac.DataSource = dt;
                        dataGridView_Infrac.AutoResizeColumns();

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Se encontraron direcciones con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Si no se encontró ninguna dirección, mostrar un mensaje
                            MessageBox.Show("No se encontraron direcciones con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila válida en dataGridView_Infrac
            if (dataGridView_Infrac.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la dirección seleccionada (DIRE_P_inCODDIR)
                object codigoDireccion = dataGridView_Infrac.SelectedRows[0].Cells["DIRE_P_inCODDIR"].Value;
                if (codigoDireccion != null && int.TryParse(codigoDireccion.ToString(), out int codigoDir))
                {
                    DireCodDir = codigoDir;
                }
                else
                {
                    // Manejar el caso en que no se pueda obtener el código de la dirección
                    MessageBox.Show("No se pudo obtener el código de la dirección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el nombre de la dirección de la fila seleccionada
                DireccionGuardada = dataGridView_Infrac.SelectedRows[0].Cells["DIRE_chDESDIR"].Value.ToString();
                //MessageBox.Show("Valor de CodDir en RegistrarInfraccion: " + DireCodDir.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cambiar el valor de this.DialogResult a DialogResult.OK antes de cerrar el formulario
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una dirección.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}

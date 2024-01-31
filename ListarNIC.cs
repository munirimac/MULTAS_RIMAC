using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using OfficeOpenXml;
using System.Collections;
using System.Diagnostics;
using static WindowsFormsApp15.iniarSesion;
using C5;
using System.Text.RegularExpressions;

namespace WindowsFormsApp15
{
    public partial class ListarNIC : Form
    {
        private DataTable dataTable;
        private DataColumn fechaHoraColumn;
        public int ESRM_P_inCODEST { get; set; }
        public ListarNIC()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataTable = new DataTable(); // Crear una nueva instancia de DataTable
            button2.Visible = false;
        }

        private void ClearDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
        }

        private void ConfigureDataGridView_MULTAS()
        {
            this.SuspendLayout();

            // Verificar si el DataTable contiene datosc
            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = dataTable;
                // Configurar las columnas del DataGridView
                //Concatenar fecha y hora 
                if (fechaHoraColumn == null)
                {
                    fechaHoraColumn = new DataColumn("FECHA Y HORA", typeof(string));
                    fechaHoraColumn.Expression = "NOTC_chFECNOT + ' ' + NOTC_chHORNOT";
                    dataTable.Columns.Add(fechaHoraColumn);
                }
                dataGridView1.Columns.Remove("NOTC_chFECNOT");
                dataGridView1.Columns.Remove("NOTC_chHORNOT");

                if (dataGridView1.Columns.Contains("NOTC_chNRONOT"))
                    dataGridView1.Columns.Remove("NOTC_chNRONOT");

                if (dataGridView1.Columns.Contains("SEGU_chUSULOG"))
                    dataGridView1.Columns.Remove("SEGU_chUSULOG");

                if (dataGridView1.Columns.Contains("SEGU_chUSUMAQ"))
                    dataGridView1.Columns.Remove("SEGU_chUSUMAQ");

                if (dataGridView1.Columns.Contains("SEGU_chUSUFEC"))
                    dataGridView1.Columns.Remove("SEGU_chUSUFEC");
                if (dataGridView1.Columns.Contains("ESMA_P_inCODEST"))
                    dataGridView1.Columns.Remove("ESMA_P_inCODEST");
                //ANIO_P_chCODANO
                dataGridView1.Columns["PERS_chNOMCOM"].DisplayIndex = 0;
                dataGridView1.Columns["ANIO_P_chCODANO"].DisplayIndex = 1;
                dataGridView1.Columns["MULC_chNROMUL"].DisplayIndex = 2;
                dataGridView1.Columns["NOTD_deMONINF"].DisplayIndex = 3;
                dataGridView1.Columns["INMA_chCODINF"].DisplayIndex = 4;
                dataGridView1.Columns["INMA_chDESINF"].DisplayIndex = 5;
                dataGridView1.Columns["DIRECCION_INFRACCION"].DisplayIndex = 6;
                dataGridView1.Columns["DIRECCION_FISCAL"].DisplayIndex = 7;
                dataGridView1.Columns["ACTI_chDESACT"].DisplayIndex = 8;
                dataGridView1.Columns["INMA_chMEDCOM"].DisplayIndex = 9;
                dataGridView1.Columns["ESMA_chDESEST"].DisplayIndex = 10;
                dataGridView1.Columns["FECHA Y HORA"].DisplayIndex = 11;

                dataGridView1.Columns["PERS_chNOMCOM"].HeaderText = "NOMBRE COMPLETO";
                dataGridView1.Columns["ANIO_P_chCODANO"].HeaderText = "AÑO";
                dataGridView1.Columns["MULC_chNROMUL"].HeaderText = "NÚMERO MULTA";
                dataGridView1.Columns["NOTD_deMONINF"].HeaderText = "MULTA";
                dataGridView1.Columns["INMA_chCODINF"].HeaderText = "CÓDIGO-INFRACCIÓN";
                dataGridView1.Columns["INMA_chDESINF"].HeaderText = "DESCRIPCIÓN INFRACCIÓN";
                dataGridView1.Columns["DIRECCION_INFRACCION"].HeaderText = "DIRECCIÓN INFRACCIÓN";
                dataGridView1.Columns["DIRECCION_FISCAL"].HeaderText = "DIRECCIÓN FISCAL";
                dataGridView1.Columns["FECHA Y HORA"].HeaderText = "FECHA Y HORA";
                dataGridView1.Columns["ACTI_chDESACT"].HeaderText = "ACTIVIDAD";
                dataGridView1.Columns["INMA_chMEDCOM"].HeaderText = "MEDIDA PROVISIONAL";
                dataGridView1.Columns["ESMA_chDESEST"].HeaderText = "ESTADO";


                // Ajustar automáticamente las columnas al ancho del contenedor
                dataGridView1.Columns["PERS_chNOMCOM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["ANIO_P_chCODANO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["MULC_chNROMUL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["NOTD_deMONINF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["INMA_chCODINF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["INMA_chDESINF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["DIRECCION_INFRACCION"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["DIRECCION_FISCAL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["FECHA Y HORA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["ACTI_chDESACT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["INMA_chMEDCOM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["ESMA_chDESEST"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                // Peso de relleno para las columnas
                dataGridView1.Columns["PERS_chNOMCOM"].FillWeight = 50;
                dataGridView1.Columns["ANIO_P_chCODANO"].FillWeight = 30;
                dataGridView1.Columns["MULC_chNROMUL"].FillWeight = 30;
                dataGridView1.Columns["NOTD_deMONINF"].FillWeight = 30;
                dataGridView1.Columns["INMA_chCODINF"].FillWeight = 30;
                dataGridView1.Columns["INMA_chDESINF"].FillWeight = 50;
                dataGridView1.Columns["DIRECCION_INFRACCION"].FillWeight = 15;
                dataGridView1.Columns["DIRECCION_FISCAL"].FillWeight = 15;
                dataGridView1.Columns["FECHA Y HORA"].FillWeight = 30;
                dataGridView1.Columns["ACTI_chDESACT"].FillWeight = 30;
                dataGridView1.Columns["INMA_chMEDCOM"].FillWeight = 30;
                dataGridView1.Columns["ESMA_chDESEST"].FillWeight = 15;


                dataGridView1.Columns["PERS_chNOMCOM"].MinimumWidth = 150;
                dataGridView1.Columns["ANIO_P_chCODANO"].MinimumWidth = 150;
                dataGridView1.Columns["MULC_chNROMUL"].MinimumWidth = 150;
                dataGridView1.Columns["NOTD_deMONINF"].MinimumWidth = 150;
                dataGridView1.Columns["INMA_chCODINF"].MinimumWidth = 150;
                dataGridView1.Columns["INMA_chDESINF"].MinimumWidth = 150;
                dataGridView1.Columns["DIRECCION_INFRACCION"].MinimumWidth = 150;
                dataGridView1.Columns["DIRECCION_FISCAL"].MinimumWidth = 150;
                dataGridView1.Columns["INMA_chMEDCOM"].MinimumWidth = 40;

                // Configurar el ajuste automático de altura de las filas
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Configurar el ajuste automático de contenido en las celdas   
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                // Asignar el DataTable como origen de datos
                dataGridView1.DataSource = dataTable;

            }
            else
            {
                // Si el DataTable no tiene datos, limpiamos el DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
            }
            this.ResumeLayout();
        }

        private SqlConnection GetConnection()
        {
            string connectionString = "Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$";
            return new SqlConnection(connectionString);
        }
        private void ConfigureDataGridView()
        {
            this.SuspendLayout();

            // Verificar si el DataTable contiene datos
            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = dataTable;
                // Configurar las columnas del DataGridView
                //Concatenar fecha y hora 
                if (fechaHoraColumn == null)
                {
                    fechaHoraColumn = new DataColumn("FECHA Y HORA", typeof(string));
                    fechaHoraColumn.Expression = "NOTC_chFECNOT + ' ' + NOTC_chHORNOT";
                    dataTable.Columns.Add(fechaHoraColumn);
                }

                if (dataGridView1.Columns.Contains("MULC_chNROMUL"))
                    dataGridView1.Columns.Remove("MULC_chNROMUL");

                dataGridView1.Columns.Remove("NOTC_chFECNOT");
                dataGridView1.Columns.Remove("NOTC_chHORNOT");

                if (dataGridView1.Columns.Contains("SEGU_chUSULOG"))
                    dataGridView1.Columns.Remove("SEGU_chUSULOG");

                if (dataGridView1.Columns.Contains("SEGU_chUSUMAQ"))
                    dataGridView1.Columns.Remove("SEGU_chUSUMAQ");

                if (dataGridView1.Columns.Contains("SEGU_chUSUFEC"))
                    dataGridView1.Columns.Remove("SEGU_chUSUFEC");
                if (dataGridView1.Columns.Contains("ESMA_P_inCODEST"))
                    dataGridView1.Columns.Remove("ESMA_P_inCODEST");
                //MULC_chNROMUL
                //Orden del datagridview
                //ANIO_P_chCODANO
                dataGridView1.Columns["PERS_chNOMCOM"].DisplayIndex = 0;
                dataGridView1.Columns["ANIO_P_chCODANO"].DisplayIndex = 1;
                dataGridView1.Columns["NOTC_chNRONOT"].DisplayIndex = 2;
                dataGridView1.Columns["NOTD_deMONINF"].DisplayIndex = 3;
                dataGridView1.Columns["INMA_chCODINF"].DisplayIndex = 4;
                dataGridView1.Columns["INMA_chDESINF"].DisplayIndex = 5;
                dataGridView1.Columns["DIRECCION_INFRACCION"].DisplayIndex = 6;
                dataGridView1.Columns["DIRECCION_FISCAL"].DisplayIndex = 7;
                dataGridView1.Columns["ACTI_chDESACT"].DisplayIndex = 8;
                dataGridView1.Columns["INMA_chMEDCOM"].DisplayIndex = 9;
                dataGridView1.Columns["ESMA_chDESEST"].DisplayIndex = 10;
                dataGridView1.Columns["FECHA Y HORA"].DisplayIndex = 11;


                dataGridView1.Columns["PERS_chNOMCOM"].HeaderText = "NOMBRE COMPLETO";
                dataGridView1.Columns["ANIO_P_chCODANO"].HeaderText = "AÑO";
                dataGridView1.Columns["NOTC_chNRONOT"].HeaderText = "NÚMERO NOTIFICACIÓN";
                dataGridView1.Columns["NOTD_deMONINF"].HeaderText = "MULTA";
                dataGridView1.Columns["INMA_chCODINF"].HeaderText = "CÓDIGO-INFRACCIÓN";
                dataGridView1.Columns["INMA_chDESINF"].HeaderText = "DESCRIPCIÓN INFRACCIÓN";
                dataGridView1.Columns["DIRECCION_INFRACCION"].HeaderText = "DIRECCIÓN INFRACCIÓN";
                dataGridView1.Columns["DIRECCION_FISCAL"].HeaderText = "DIRECCIÓN FISCAL";
                dataGridView1.Columns["FECHA Y HORA"].HeaderText = "FECHA Y HORA";
                dataGridView1.Columns["ACTI_chDESACT"].HeaderText = "ACTIVIDAD";
                dataGridView1.Columns["INMA_chMEDCOM"].HeaderText = "MEDIDA PROVISIONAL";
                dataGridView1.Columns["ESMA_chDESEST"].HeaderText = "ESTADO";


                // Ajustar automáticamente las columnas al ancho del contenedor
                dataGridView1.Columns["PERS_chNOMCOM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["ANIO_P_chCODANO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["NOTC_chNRONOT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["NOTD_deMONINF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["INMA_chCODINF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["INMA_chDESINF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["DIRECCION_INFRACCION"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["DIRECCION_FISCAL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["FECHA Y HORA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["ACTI_chDESACT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["INMA_chMEDCOM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["ESMA_chDESEST"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                // Peso de relleno para las columnas
                dataGridView1.Columns["PERS_chNOMCOM"].FillWeight = 50;
                dataGridView1.Columns["ANIO_P_chCODANO"].FillWeight = 30;
                dataGridView1.Columns["NOTC_chNRONOT"].FillWeight = 30;
                dataGridView1.Columns["NOTD_deMONINF"].FillWeight = 30;
                dataGridView1.Columns["INMA_chCODINF"].FillWeight = 30;
                dataGridView1.Columns["INMA_chDESINF"].FillWeight = 50;
                dataGridView1.Columns["DIRECCION_INFRACCION"].FillWeight = 15;
                dataGridView1.Columns["DIRECCION_FISCAL"].FillWeight = 15;
                dataGridView1.Columns["FECHA Y HORA"].FillWeight = 30;
                dataGridView1.Columns["ACTI_chDESACT"].FillWeight = 30;
                dataGridView1.Columns["INMA_chMEDCOM"].FillWeight = 30;
                dataGridView1.Columns["ESMA_chDESEST"].FillWeight = 15;


                dataGridView1.Columns["PERS_chNOMCOM"].MinimumWidth = 150;
                dataGridView1.Columns["ANIO_P_chCODANO"].MinimumWidth = 150;
                dataGridView1.Columns["NOTC_chNRONOT"].MinimumWidth = 150;
                dataGridView1.Columns["NOTD_deMONINF"].MinimumWidth = 150;
                dataGridView1.Columns["INMA_chCODINF"].MinimumWidth = 150;
                dataGridView1.Columns["INMA_chDESINF"].MinimumWidth = 150;
                dataGridView1.Columns["DIRECCION_INFRACCION"].MinimumWidth = 150;
                dataGridView1.Columns["DIRECCION_FISCAL"].MinimumWidth = 150;
                dataGridView1.Columns["INMA_chMEDCOM"].MinimumWidth = 40;
                dataGridView1.Columns["ESMA_chDESEST"].MinimumWidth = 15;

                // Configurar el ajuste automático de altura de las filas
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Configurar el ajuste automático de contenido en las celdas   
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                // Asignar el DataTable como origen de datos
                dataGridView1.DataSource = dataTable;

            }
            else
            {
                // Si el DataTable no tiene datos, limpiamos el DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
            }
            this.ResumeLayout();
        }


        private void ConfigureDataGridViewMostrarNICS()
        {
            //DIRE_chDESDIR
            //DIRE_P_inCODDIR
            //ACTI_chDESACT
            // Verificar si el DataTable contiene datos
            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dataTable;
                if (dataGridView1.Columns.Contains("MULC_chNROMUL"))
                    dataGridView1.Columns.Remove("MULC_chNROMUL");

                if (dataGridView1.Columns.Contains("INMA_chCODINF"))
                    dataGridView1.Columns.Remove("INMA_chCODINF");

                if (dataGridView1.Columns.Contains("NOTD_deMONINF"))
                    dataGridView1.Columns.Remove("NOTD_deMONINF");

                if (dataGridView1.Columns.Contains("INMA_chDESINF"))
                    dataGridView1.Columns.Remove("INMA_chDESINF");

                if (dataGridView1.Columns.Contains("DIRECCION_INFRACCION"))
                    dataGridView1.Columns.Remove("DIRECCION_INFRACCION");

                if (dataGridView1.Columns.Contains("ACTI_chDESACT"))
                    dataGridView1.Columns.Remove("ACTI_chDESACT");

                if (dataGridView1.Columns.Contains("DIRECCION_FISCAL"))
                    dataGridView1.Columns.Remove("DIRECCION_FISCAL");

                if (dataGridView1.Columns.Contains("FECHA Y HORA"))
                    dataGridView1.Columns.Remove("FECHA Y HORA");

                if (dataGridView1.Columns.Contains("NOTC_chFECNOT"))
                    dataGridView1.Columns.Remove("NOTC_chFECNOT");

                if (dataGridView1.Columns.Contains("NOTC_chHORNOT"))
                    dataGridView1.Columns.Remove("NOTC_chHORNOT");

                if (dataGridView1.Columns.Contains("INMA_chMEDCOM"))
                    dataGridView1.Columns.Remove("INMA_chMEDCOM");

                if (dataGridView1.Columns.Contains("ESMA_chDESEST"))
                    dataGridView1.Columns.Remove("ESMA_chDESEST");

                if (dataGridView1.Columns.Contains("ESMA_P_inCODEST"))
                    dataGridView1.Columns.Remove("ESMA_P_inCODEST");


                //Orden del datagridview
                dataGridView1.Columns["PERS_chNOMCOM"].DisplayIndex = 0;
                dataGridView1.Columns["NOTC_chNRONOT"].DisplayIndex = 1;
                dataGridView1.Columns["ANIO_P_chCODANO"].DisplayIndex = 2;
                dataGridView1.Columns["SEGU_chUSULOG"].DisplayIndex = 3;
                dataGridView1.Columns["SEGU_chUSUMAQ"].DisplayIndex = 4;
                dataGridView1.Columns["SEGU_chUSUFEC"].DisplayIndex = 5;
                // Configurar las columnas del DataGridView
                dataGridView1.Columns["PERS_chNOMCOM"].HeaderText = "NOMBRE COMPLETO";
                dataGridView1.Columns["NOTC_chNRONOT"].HeaderText = "NÚMERO NOTIFICACIÓN";
                dataGridView1.Columns["ANIO_P_chCODANO"].HeaderText = "AÑO";
                dataGridView1.Columns["SEGU_chUSULOG"].HeaderText = "USUARIO";
                dataGridView1.Columns["SEGU_chUSUMAQ"].HeaderText = "PC";
                dataGridView1.Columns["SEGU_chUSUFEC"].HeaderText = "FECHA";

                // Ajustar automáticamente las columnas al ancho del contenedor
                dataGridView1.Columns["PERS_chNOMCOM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["NOTC_chNRONOT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["ANIO_P_chCODANO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["SEGU_chUSULOG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["SEGU_chUSUMAQ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["SEGU_chUSUFEC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                // Peso de relleno para las columnas
                dataGridView1.Columns["PERS_chNOMCOM"].FillWeight = 50;
                dataGridView1.Columns["NOTC_chNRONOT"].FillWeight = 15;
                dataGridView1.Columns["ANIO_P_chCODANO"].FillWeight = 15;
                dataGridView1.Columns["SEGU_chUSULOG"].FillWeight = 15;
                dataGridView1.Columns["SEGU_chUSUMAQ"].FillWeight = 15;
                dataGridView1.Columns["SEGU_chUSUFEC"].FillWeight = 15;

            }
            else
            {
                // Si el DataTable no tiene datos, limpiamos el DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                string numeroNIC = txtNumeNIC.Text.Trim();

                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "SELECT PERS.PERS_chNOMCOM, NOTC.NOTC_chNRONOT, NOTC.ANIO_P_chCODANO,NOTC.SEGU_chUSULOG, NOTC.SEGU_chUSUMAQ, NOTC.SEGU_chUSUFEC " +
                                   "FROM M_NOTC NOTC " +
                                   "INNER JOIN M_PERS PERS ON NOTC.NOTC_inCODINF = PERS.PERS_P_inCODPER " +
                                   "WHERE NOTC.NOTC_chNRONOT = @NumeroNIC ";



                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroNIC", numeroNIC);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            dataGridView1.DataSource = null;
                            dataTable.Clear(); // Limpiar solo el DataTable
                            adapter.Fill(dataTable);
                        }
                    }

                    // Obtener el valor de PERS_chNOMCOM de la primera fila del DataTable, si hay filas
                    if (dataTable.Rows.Count > 0)
                    {
                        txtInfrac.Text = dataTable.Rows[0]["PERS_chNOMCOM"].ToString();
                    }
                    else
                    {
                        txtInfrac.Text = "No se encontró información para el número de NIC especificado.";
                    }
                    ClearDataGridView();
                    ConfigureDataGridViewMostrarNICS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private BTree<DateTime, List<DataRow>> fechaRowsIndex = new BTree<DateTime, List<DataRow>>();

        //btnBuscarTodos_Click

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value.AddDays(1);

            string fechaRecibidaFormateadaInicio = fechaInicio.ToString("yyyyMMdd");
            string fechaRecibidaFormateadaFin = fechaFin.ToString("yyyyMMdd");

            try
            {
                string nombreInfractor = txtInfrac.Text.Trim();

                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_3");
                    string decryptedQuery = Decrypt(encryptedQuery);

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NombreInfractor", nombreInfractor);
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaRecibidaFormateadaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaRecibidaFormateadaFin);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            dataGridView1.DataSource = null;
                            dataTable.Clear(); // Limpiar solo el DataTable
                            adapter.Fill(dataTable);
                        }
                    }
                    ClearDataGridView();
                    ConfigureDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Mostrar menú de opciones para seleccionar el campo a editar
                ContextMenuStrip fieldMenu = new ContextMenuStrip();

                Dictionary<string, string> fieldMappings = new Dictionary<string, string>
        {
            { "PERS_chNOMCOM", "NOMBRE COMPLETO" },
            { "NOTC_chNRONOT", "NÚMERO NOTIFICACIÓN" },
            { "NOTD_deMONINF", "MULTA" },
            { "INMA_chCODINF", "CÓDIGO-INFRACCIÓN" },
            { "DIRECCION_INFRACCION", "DIRECCIÓN INFRACCIÓN" },
            { "DIRECCION_FISCAL", "DIRECCION FISCAL"},
            { "FECHA Y HORA", "FECHA Y HORA" },
            { "ACTI_chDESACT", "ACTIVIDAD" }
        };
                foreach (var fieldMapping in fieldMappings)
                {
                    ToolStripMenuItem fieldItem = new ToolStripMenuItem(fieldMapping.Value);
                    fieldItem.Click += (s, ev) => EditFieldValue(selectedRow, fieldMapping.Key);
                    fieldMenu.Items.Add(fieldItem);
                }

                // Mostrar el menú de opciones
                fieldMenu.Show(Cursor.Position);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int ObtenerPersPInCODPER(string nombreCompleto)
        {
            int persPInCODPER = -1;

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "SELECT PERS_P_inCODPER FROM M_PERS WHERE PERS_chNOMCOM = @NombreCompleto";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            persPInCODPER = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener PERS_P_inCODPER: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return persPInCODPER;
        }

        private void ActualizarNOTC_inCODINF(string currentNIC, int newPersPInCODPER)
        {
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Construir la consulta SQL de actualización
                    string query = "UPDATE M_NOTC SET NOTC_inCODINF = @newPersPInCODPER WHERE NOTC_chNRONOT = @currentNIC";

                    // Crear el comando SQL
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@newPersPInCODPER", newPersPInCODPER);
                        command.Parameters.AddWithValue("@currentNIC", currentNIC);

                        // Ejecutar la consulta de actualización
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Campo NOTC_inCODINF actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el campo NOTC_inCODINF.", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el campo NOTC_inCODINF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteNICEnM_NOTC(string nic)
        {
            // Realizar la conexión a la base de datos y la consulta
            using (SqlConnection con = GetConnection())
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM M_NOTC WHERE NOTC_chNRONOT = @NIC";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@NIC", nic);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private void ActualizarNICEnM_NOTC(string currentNIC, string newNIC)
        {
            if (!ExisteNICEnM_NOTC(newNIC))
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "UPDATE M_NOTC SET NOTC_chNRONOT = @NewNIC WHERE NOTC_chNRONOT = @CurrentNIC";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@NewNIC", newNIC);
                        command.Parameters.AddWithValue("@CurrentNIC", currentNIC);

                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("El nuevo NIC ya existe en la tabla M_NOTC. Por favor, ingrese otro valor de NIC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarHORA(string currentNIC, string newNIC)
        {

            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "UPDATE M_NOTC SET NOTC_chHORNOT = @NewNIC WHERE NOTC_chNRONOT = @CurrentNIC";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@NewNIC", newNIC);
                        command.Parameters.AddWithValue("@CurrentNIC", currentNIC);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }


        private void EditFieldValue(DataGridViewRow selectedRow, string fieldName)
        {
            // Mostrar cuadro de diálogo para ingresar el nuevo valor
            string newValue = Interaction.InputBox("Ingrese el nuevo valor:", "Nuevo valor", selectedRow.Cells[fieldName].Value.ToString());
            if (string.IsNullOrWhiteSpace(newValue))
            {
                MessageBox.Show("Ingrese un valor válido para el número de multa.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validar que el valor sea numérico con puntos y guiones
            /*
            if (!Regex.IsMatch(newValue, @"^[0-9.-]+$"))
            {
                MessageBox.Show("Ingrese un valor numérico válido.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //FALTA CAMBIAR EL VALOR DE ACA 
            // Validar que el valor sea decimal
            if (!decimal.TryParse(newValue, out _))
            {
                MessageBox.Show("Ingrese un valor decimal válido.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            */
            // Verificar si se ingresó un nuevo valor
            if (!string.IsNullOrEmpty(newValue))
            {
                string currentName = selectedRow.Cells["PERS_chNOMCOM"].Value.ToString();

                // Obtener el persPInCODPER del nombre actual
                int currentCODPER = ObtenerPersPInCODPER(currentName);
                if (fieldName == "PERS_chNOMCOM")
                {
                    string currentNIC = selectedRow.Cells["NOTC_chNRONOT"].Value.ToString();
                    selectedRow.Cells[fieldName].Value = newValue;
                    // Obtener el persPInCODPER del nuevo nombre
                    int persPInCODPER = ObtenerPersPInCODPER_DOCU(newValue);
                    string nombreCompleto = obtenerNombreCompleto(newValue);
                    selectedRow.Cells[fieldName].Value = nombreCompleto;
                    // Verificar si el nuevo nombre existe en M_PERS
                    if (persPInCODPER == -1)
                    {
                        MessageBox.Show("El nuevo nombre no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // No se realiza ninguna act
                                // ualización
                    }

                    // Actualizar NOTC_inCODINF en M_NOTC si existe el NIC
                    if (!string.IsNullOrEmpty(currentNIC))
                    {
                        ActualizarNOTC_inCODINF(currentNIC, persPInCODPER);
                    }

                    // Refrescar el DataGridView para mostrar el cambio
                    dataGridView1.Refresh();
                }

                else if (fieldName == "NOTC_chNRONOT")
                {
                    if (newValue.Length > 6)
                    {
                        MessageBox.Show("El valor ingresado tiene más de 6 dígitos. No se permiten valores mayores a 6 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Verificar si el nuevo NIC ya existe en M_NOTC
                    if (ExisteNICEnM_NOTC(newValue))
                    {
                        MessageBox.Show("El NIC ya existe en la tabla M_NOTC. Ingrese otro valor de NIC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string currentNIC = selectedRow.Cells["NOTC_chNRONOT"].Value.ToString();
                        ActualizarNICEnM_NOTC(currentNIC, newValue);
                    }

                    // Actualizar el valor en el DataTable
                    selectedRow.Cells[fieldName].Value = newValue;
                }
                else if (fieldName == "NOTD_deMONINF")
                {
                    if (!string.IsNullOrEmpty(newValue))
                    {
                        // Obtener el valor ingresado
                        decimal nuevoValorMulta = decimal.Parse(newValue);

                        // Mostrar mensaje de registro de documento sustentatorio
                        DialogResult sustentatorioResult = MessageBox.Show("¿Se ha presentado un documento sustentatorio?", "Documento Sustentatorio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (sustentatorioResult == DialogResult.Yes)
                        {
                            string numeroNotificacion = selectedRow.Cells["NOTC_chNRONOT"].Value.ToString();
                            string estado = selectedRow.Cells["ESMA_chDESEST"].Value.ToString();
                            if (estado == "GENERADO")
                            {
                                // Obtener el valor NOTC_P_inCODNOT
                                int notcPInCODNOT = ObtenerNOTCPInCODNOT(numeroNotificacion);

                                // Crear una instancia del formulario "FormDocumentoResolucion" y pasar el valor
                                FormDocumentoResolucion formDocumentoResolucion = new FormDocumentoResolucion(ref notcPInCODNOT, ESRM_P_inCODEST);

                                // Mostrar el formulario como un diálogo modal
                                DialogResult formResult = formDocumentoResolucion.ShowDialog();
                                //MessageBox.Show("Se está usando VALOR DE OBRA. " + ESRM_P_inCODEST, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Si el formulario se cerró con el botón "Guardar"
                                //MessageBox.Show("Se está usando VALOR DE OBRA. " + notcPInCODNOT, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                {
                                    // Cambiar el estado a 5 en la tabla ESMA_P_inCODEST
                                    CambiarEstadoMulta(notcPInCODNOT, 5);

                                    // Actualizar el valor de la multa en la tabla M_MULC
                                    ActualizarValorMulta(notcPInCODNOT, nuevoValorMulta);
                                    int numeroMulta = obtenerNumMulta(notcPInCODNOT);
                                    string numeroMultaStr = Convert.ToString(numeroMulta);
                                    int CodigoMulta = obtenerCODIGOMULTA(numeroMultaStr, notcPInCODNOT);
                                    //MessageBox.Show("Se está usando CodigoMulta:  " + CodigoMulta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    int codigoOrigi = obtenerCCOR_P_inCODORI(CodigoMulta);
                                    //MessageBox.Show("Se está usando codigoOrigi: " + codigoOrigi, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    int codigoCTAC = obtenerCTAC_P_inCODCTA(codigoOrigi);
                                    //MessageBox.Show("Se está usando codigoCTAC:  " + codigoCTAC, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    ActualizarValorMultaCTAC(codigoCTAC, nuevoValorMulta);
                                    dataGridView1.Refresh();
                                }
                            }
                            else if (estado == "ACTIVO")
                            {
                                // Obtener el valor NOTC_P_inCODNOT
                                int notcPInCODNOT = ObtenerNOTCPInCODNOT(numeroNotificacion);

                                // Crear una instancia del formulario "FormDocumentoResolucion" y pasar el valor
                                FormDocumentoResolucion formDocumentoResolucion = new FormDocumentoResolucion(ref notcPInCODNOT, ESRM_P_inCODEST);

                                // Mostrar el formulario como un diálogo modal
                                DialogResult formResult = formDocumentoResolucion.ShowDialog();
                                //MessageBox.Show("Se está usando VALOR DE OBRA. " + ESRM_P_inCODEST, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Si el formulario se cerró con el botón "Guardar"
                                //MessageBox.Show("Se está usando VALOR DE OBRA. " + notcPInCODNOT, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                {
                                    // Cambiar el estado a 5 en la tabla ESMA_P_inCODEST
                                    CambiarEstadoMulta(notcPInCODNOT, 5);

                                    // Actualizar el valor de la multa en la tabla M_MULC
                                    ActualizarValorMulta(notcPInCODNOT, nuevoValorMulta);
                                    dataGridView1.Refresh();
                                }
                            }

                        }
                        else if (sustentatorioResult == DialogResult.No)
                        {
                            MessageBox.Show("Es necesario presentar un documento sustentatorio antes de cambiar la multa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                else if (fieldName == "ACTI_chDESACT")
                {
                    if (!string.IsNullOrEmpty(newValue))
                    {
                        Dictionary<string, int> actividadesSimilaresConCodigo = ObtenerActividadesSimilaresConCodigo(newValue);

                        if (actividadesSimilaresConCodigo.Count > 0)
                        {
                            string actividadSeleccionada = MostrarOpciones("Seleccione una actividad:", actividadesSimilaresConCodigo);

                            if (!string.IsNullOrEmpty(actividadSeleccionada) && actividadesSimilaresConCodigo.ContainsKey(actividadSeleccionada))
                            {
                                int codigoActividadSeleccionada = actividadesSimilaresConCodigo[actividadSeleccionada];

                                selectedRow.Cells[fieldName].Value = actividadSeleccionada;
                                dataGridView1.Refresh();

                                // Realizar el update en la tabla M_NOTC
                                int notcPInCODNOT = ObtenerNOTCPInCODNOT(selectedRow.Cells["NOTC_chNRONOT"].Value.ToString());
                                UpdateACTI_P_inCODACTInM_NOTC(codigoActividadSeleccionada, notcPInCODNOT);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron actividades similares.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (fieldName == "INMA_chCODINF")

                {
                    //string newInfraccionCode = Interaction.InputBox("Ingrese el nuevo código de infracción:", "Nuevo código", selectedRow.Cells[fieldName].Value.ToString());
                    // Verificar si se ingresó un nuevo código
                    string ordenanza = Interaction.InputBox("Ingrese el numero de ordenanza:", "Agregar Referencia", "");
                    if (!string.IsNullOrEmpty(newValue))
                    {
                        if (EsCodigoInfraccionValido(newValue))
                        {
                            (int nuevoIdentificador, string nuevaDescripcion, string nuevaMedida, int tipo_infracc, decimal porcentajeUIT, string otraOrdenanza) = ObtenerDescripcionInfraccion(newValue, ordenanza);

                            // Actualizar los valores en el DataGridView
                            selectedRow.Cells[fieldName].Value = newValue;
                            selectedRow.Cells["INMA_chDESINF"].Value = nuevaDescripcion;
                            selectedRow.Cells["INMA_chMEDCOM"].Value = nuevaMedida;

                            // Refrescar el DataGridView para mostrar el cambio
                            dataGridView1.Refresh();

                            // Obtener el NOTC_P_inCODNOT asociado a este INMA_P_inCODINF
                            int notcPInCODNOT = ObtenerNOTCPInCODNOT(selectedRow.Cells["NOTC_chNRONOT"].Value.ToString());

                            // Actualizar el campo INMA_P_inCODINF en la tabla V_NOTD
                            UpdateINMA_P_inCODINFInV_NOTD(nuevoIdentificador, notcPInCODNOT);

                            // Verificar si el tipo de infracción es 1 (PORCENTAJE)
                            if (tipo_infracc == 1)
                            {
                                // Obtener el año para obtener el valor de la UIT
                                string yearInput = Interaction.InputBox("Ingrese el año para obtener el valor de la UIT:", "Año");

                                // Obtener el valor de la UIT para el año seleccionado
                                decimal uitValue = ObtenerValorUIT(yearInput);

                                // Calcular la nueva multa
                                decimal nuevaMulta = uitValue * (porcentajeUIT / 100);

                                // Actualizar el valor en el DataGridView
                                selectedRow.Cells["NOTD_deMONINF"].Value = nuevaMulta;

                                using (SqlConnection con = GetConnection())
                                {
                                    con.Open();

                                    string updateNotdQuery = "UPDATE V_NOTD SET NOTD_deMONINF = @NuevoValor WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                                    using (SqlCommand updateNotdCmd = new SqlCommand(updateNotdQuery, con))
                                    {
                                        updateNotdCmd.Parameters.AddWithValue("@NuevoValor", nuevaMulta);
                                        updateNotdCmd.Parameters.AddWithValue("@NotcPInCODNOT", notcPInCODNOT);
                                        updateNotdCmd.ExecuteNonQuery();
                                    }
                                }


                                // Refrescar el DataGridView para mostrar el cambio
                                dataGridView1.Refresh();
                            }
                            else if (tipo_infracc == 2)
                            {
                                MessageBox.Show("Se está usando VALOR DE OBRA. " + tipo_infracc, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Obtener el año para obtener el valor de la UIT
                                string yearInput = Interaction.InputBox("Ingrese el año para obtener el valor de la UIT:", "Año");

                                // Obtener el valor de la UIT para el año seleccionado
                                decimal uitValue = ObtenerValorUIT(yearInput);

                                string valorObra = Interaction.InputBox("Ingrese el valor de la obra", "Obra");
                                if (!decimal.TryParse(valorObra, out decimal valorObraDecimal))
                                {
                                    MessageBox.Show("Valor de obra inválido. Ingrese un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                decimal nuevaMulta = uitValue * (porcentajeUIT / 100) * valorObraDecimal;

                                // Actualizar el valor en el DataGridView
                                selectedRow.Cells["NOTD_deMONINF"].Value = nuevaMulta;

                                using (SqlConnection con = GetConnection())
                                {
                                    con.Open();

                                    string updateNotdQuery = "UPDATE V_NOTD SET NOTD_deMONINF = @NuevoValor WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                                    using (SqlCommand updateNotdCmd = new SqlCommand(updateNotdQuery, con))
                                    {
                                        updateNotdCmd.Parameters.AddWithValue("@NuevoValor", nuevaMulta);
                                        updateNotdCmd.Parameters.AddWithValue("@NotcPInCODNOT", notcPInCODNOT);
                                        updateNotdCmd.ExecuteNonQuery();
                                    }
                                }

                                // Refrescar el DataGridView para mostrar el cambio
                                dataGridView1.Refresh();
                            }
                            else if (tipo_infracc == 3)
                            {
                                MessageBox.Show("Se está usando CANTIDAD. " + tipo_infracc, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Obtener el año para obtener el valor de la UIT
                                string yearInput = Interaction.InputBox("Ingrese el año para obtener el valor de la UIT:", "Año");

                                // Obtener el valor de la UIT para el año seleccionado
                                decimal uitValue = ObtenerValorUIT(yearInput);

                                string cantUITS = Interaction.InputBox("Ingrese la cantidad de UITS", "Cantidad");
                                if (!int.TryParse(cantUITS, out int cantUITSint))
                                {
                                    MessageBox.Show("Valor de obra inválido. Ingrese un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                decimal nuevaMulta = uitValue * (porcentajeUIT / 100) * cantUITSint;

                                // Actualizar el valor en el DataGridView
                                selectedRow.Cells["NOTD_deMONINF"].Value = nuevaMulta;

                                using (SqlConnection con = GetConnection())
                                {
                                    con.Open();

                                    string updateNotdQuery = "UPDATE V_NOTD SET NOTD_deMONINF = @NuevoValor WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                                    using (SqlCommand updateNotdCmd = new SqlCommand(updateNotdQuery, con))
                                    {
                                        updateNotdCmd.Parameters.AddWithValue("@NuevoValor", nuevaMulta);
                                        updateNotdCmd.Parameters.AddWithValue("@NotcPInCODNOT", notcPInCODNOT);
                                        updateNotdCmd.ExecuteNonQuery();
                                    }
                                }

                                // Refrescar el DataGridView para mostrar el cambio
                                dataGridView1.Refresh();
                            }
                            else if (tipo_infracc == 4)
                            {
                                MessageBox.Show("Se está usando FIJO. " + tipo_infracc, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (tipo_infracc == 5)
                            {
                                MessageBox.Show("Se está usando PORCENTAJE Y VALOR. " + tipo_infracc, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Código de infracción inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (fieldName == "DIRECCION_INFRACCION")
                {
                    if (!string.IsNullOrEmpty(newValue))
                    {
                        Dictionary<string, int> direccionesSimilares = ObtenerDireccionesSimilares(newValue);
                        Dictionary<string, int> miDiccionario = ObtenerDireccionesSimilares(newValue);
                        MostrarDiccionarioEnMessageBox(miDiccionario);

                        if (direccionesSimilares.Count > 0)
                        {
                            string direccionSeleccionada = MostrarOpcionesDirecciones("Seleccione una dirección:", direccionesSimilares);

                            if (!string.IsNullOrEmpty(direccionSeleccionada) && direccionesSimilares.ContainsKey(direccionSeleccionada))
                            {
                                int codigoDireccionSeleccionada = direccionesSimilares[direccionSeleccionada];

                                selectedRow.Cells[fieldName].Value = direccionSeleccionada;
                                int notcPinCodnot = ObtenerNOTCPInCODNOT(selectedRow.Cells["NOTC_chNRONOT"].Value.ToString());
                                UpdateNOTC_inCODDIRInM_NOTC(codigoDireccionSeleccionada, notcPinCodnot);

                                dataGridView1.Refresh();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron direcciones similares.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (fieldName == "DIRECCION_FISCAL")
                {
                    if (!string.IsNullOrEmpty(newValue))
                    {
                        Dictionary<string, int> direccionesSimilares = ObtenerDireccionesSimilares(newValue);
                        Dictionary<string, int> miDiccionario = ObtenerDireccionesSimilares(newValue);
                        MostrarDiccionarioEnMessageBox(miDiccionario);

                        if (direccionesSimilares.Count > 0)
                        {
                            string direccionSeleccionada = MostrarOpcionesDirecciones("Seleccione una dirección:", direccionesSimilares);

                            if (!string.IsNullOrEmpty(direccionSeleccionada) && direccionesSimilares.ContainsKey(direccionSeleccionada))
                            {
                                int codigoDireccionSeleccionada = direccionesSimilares[direccionSeleccionada];

                                selectedRow.Cells[fieldName].Value = direccionSeleccionada;
                                int notcPinCodnot = ObtenerNOTCPInCODNOT(selectedRow.Cells["NOTC_chNRONOT"].Value.ToString());
                                UpdateNOTC_inCODDnM_NOTC(codigoDireccionSeleccionada, notcPinCodnot);

                                dataGridView1.Refresh();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron direcciones similares.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (fieldName == "FECHA Y HORA")
                {
                    string currentNIC = selectedRow.Cells["NOTC_chNRONOT"].Value.ToString();
                    ActualizarHORA(currentNIC, newValue);
                }
                // Refrescar el DataGridView para mostrar el cambio
                dataGridView1.Refresh();
            }
        }


        private bool EsCodigoInfraccionValido(string codigoInfraccion)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM V_INFR_MADM WHERE INMA_chCODINF = @CodigoInfraccion";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CodigoInfraccion", codigoInfraccion);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        private int obtenerNumMulta(int notcPinCODNOT)
        {
            int numeroMulta = -1; // Valor predeterminado en caso de no encontrar el número de notificación

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener el NOTC_P_inCODNOT asociado al número de notificación
                    string query = "SELECT MULC_chNROMUL FROM M_MULC WHERE NOTC_P_inCODNOT = @notcPinCODNOT";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@notcPinCODNOT", notcPinCODNOT);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            numeroMulta = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el CODPER_DOCU: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return numeroMulta;
        }
        private void ActualizarValorMultaCTAC(int codigoCTAC, decimal nuevoValorMulta)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string queryActualizarMulta = "UPDATE M_CTAC SET CTAC_deMONINS = @NuevoValorMulta WHERE CTAC_P_inCODCTA = @codigoCTAC";

                    using (SqlCommand cmdActualizarMulta = new SqlCommand(queryActualizarMulta, con))
                    {
                        cmdActualizarMulta.Parameters.AddWithValue("@codigoCTAC", codigoCTAC);
                        cmdActualizarMulta.Parameters.AddWithValue("@NuevoValorMulta", nuevoValorMulta);

                        cmdActualizarMulta.ExecuteNonQuery();
                    }
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el valor de la multa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarValorMulta(int notcPInCODNOT, decimal nuevoValorMulta)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string queryActualizarMulta = "UPDATE V_NOTD SET NOTD_deMONINF = @NuevoValorMulta WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                    using (SqlCommand cmdActualizarMulta = new SqlCommand(queryActualizarMulta, con))
                    {
                        cmdActualizarMulta.Parameters.AddWithValue("@NuevoValorMulta", nuevoValorMulta);
                        cmdActualizarMulta.Parameters.AddWithValue("@NotcPInCODNOT", notcPInCODNOT);

                        cmdActualizarMulta.ExecuteNonQuery();
                    }
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el valor de la multa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CambiarEstadoNOTC(int codigoNotificacion, int nuevoEstado)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string queryUpdateEstado = "UPDATE M_NOTC SET ESMA_P_inCODEST = @NuevoEstado WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                    using (SqlCommand cmdUpdateEstado = new SqlCommand(queryUpdateEstado, con))
                    {
                        cmdUpdateEstado.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                        cmdUpdateEstado.Parameters.AddWithValue("@NotcPInCODNOT", codigoNotificacion); // Cambio aquí

                        // Ejecutar el comando de actualización
                        cmdUpdateEstado.ExecuteNonQuery();

                        MessageBox.Show("Estado de la notificacion actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                // Manejo de errores...
                MessageBox.Show("Error al actualizar el estado de la notificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CambiarEstadoMulta(int codigoNotificacion, int nuevoEstado)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string queryUpdateEstado = "UPDATE M_MULC SET ESMA_P_inCODEST = @NuevoEstado WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                    using (SqlCommand cmdUpdateEstado = new SqlCommand(queryUpdateEstado, con))
                    {
                        cmdUpdateEstado.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                        cmdUpdateEstado.Parameters.AddWithValue("@NotcPInCODNOT", codigoNotificacion); // Cambio aquí

                        // Ejecutar el comando de actualización
                        cmdUpdateEstado.ExecuteNonQuery();

                        MessageBox.Show("Estado de la multa actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                // Manejo de errores...
                MessageBox.Show("Error al actualizar el estado de la multa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateNOTC_inCODDnM_NOTC(int nuevoCodigoDireccion, int notcPInCODNOT)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string updateQuery = "UPDATE M_NOTC SET NOTC_inCODDIF = @NuevoCodigoDireccion WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@NuevoCodigoDireccion", nuevoCodigoDireccion);
                        updateCmd.Parameters.AddWithValue("@NotcPInCODNOT", notcPInCODNOT);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la dirección en M_NOTC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateNOTC_inCODDIRInM_NOTC(int nuevoCodigoDireccion, int notcPInCODNOT)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string updateQuery = "UPDATE M_NOTC SET NOTC_inCODDIR = @NuevoCodigoDireccion WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@NuevoCodigoDireccion", nuevoCodigoDireccion);
                        updateCmd.Parameters.AddWithValue("@NotcPInCODNOT", notcPInCODNOT);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la dirección en M_NOTC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private Dictionary<string, int> ObtenerDireccionesSimilares(string searchValue)
        {
            Dictionary<string, int> direccionesSimilares = new Dictionary<string, int>();

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "SELECT TOP 30 DIRE_chDESDIR, DIRE_P_inCODDIR FROM M_DIRE WHERE DIRE_chDESDIR LIKE @SearchValue";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string direccion = reader["DIRE_chDESDIR"].ToString();
                                int codigoDireccion = Convert.ToInt32(reader["DIRE_P_inCODDIR"]);
                                direccionesSimilares[direccion] = codigoDireccion;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener direcciones similares: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return direccionesSimilares;
        }

        private string MostrarOpcionesDirecciones(string mensaje, Dictionary<string, int> opciones)
        {
            Form form = new Form();
            form.Width = 600;
            form.Height = 250;
            form.Text = mensaje;

            ListBox listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;

            foreach (var opcion in opciones.Keys)
            {
                listBox.Items.Add(opcion);
            }

            listBox.DoubleClick += (sender, e) => form.Close();  // Usar DoubleClick en lugar de SelectedIndexChanged

            form.Controls.Add(listBox);
            form.ShowDialog();

            if (listBox.SelectedItem != null)
            {
                return listBox.SelectedItem.ToString();
            }

            return null;
        }
        private void MostrarDiccionarioEnMessageBox(Dictionary<string, int> diccionario)
        {
            if (diccionario.Count > 0)
            {
                string contenido = "Contenido del diccionario:\n";

                foreach (var kvp in diccionario)
                {
                    contenido += $"Clave: {kvp.Key}, Valor: {kvp.Value}\n";
                }

                //MessageBox.Show(contenido, "Diccionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El diccionario está vacío.", "Diccionario Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateACTI_P_inCODACTInM_NOTC(int nuevoCodigoActividad, int notcPInCODNOT)
        {
            try
            {
                MessageBox.Show("Se está usando FIJO. " + nuevoCodigoActividad, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string updateQuery = "UPDATE M_NOTC SET ACTI_P_inCODACT = @NuevoCodigoActividad WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@NuevoCodigoActividad", nuevoCodigoActividad);
                        cmd.Parameters.AddWithValue("@NotcPInCODNOT", notcPInCODNOT);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el código de actividad en la tabla M_NOTC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string MostrarOpciones(string mensaje, Dictionary<string, int> opciones)
        {
            Form form = new Form();
            form.Width = 300;
            form.Height = 200;
            form.Text = mensaje;

            ListBox listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;

            foreach (var opcion in opciones.Keys)
            {
                listBox.Items.Add(opcion);
            }

            listBox.DoubleClick += (sender, e) => form.Close();  // Usar DoubleClick en lugar de SelectedIndexChanged

            form.Controls.Add(listBox);
            form.ShowDialog();

            if (listBox.SelectedItem != null)
            {
                return listBox.SelectedItem.ToString();
            }

            return null;
        }



        private Dictionary<string, int> ObtenerActividadesSimilaresConCodigo(string searchValue)
        {
            Dictionary<string, int> similarActivitiesWithCode = new Dictionary<string, int>();

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "SELECT ACTI_P_inCODACT, ACTI_chDESACT FROM M_ACTI WHERE ACTI_chDESACT LIKE @SearchValue";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int codigoActividad = (int)reader["ACTI_P_inCODACT"];
                                string actividad = reader["ACTI_chDESACT"].ToString();

                                if (!similarActivitiesWithCode.ContainsKey(actividad))
                                {
                                    similarActivitiesWithCode.Add(actividad, codigoActividad);
                                }
                                else
                                {
                                    // Clave duplicada: Agregar sufijo numérico para hacerla única
                                    int counter = 2;
                                    while (similarActivitiesWithCode.ContainsKey(actividad + counter))
                                    {
                                        counter++;
                                    }
                                    similarActivitiesWithCode.Add(actividad + counter, codigoActividad);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener actividades similares: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return similarActivitiesWithCode;
        }




        private decimal ObtenerValorUIT(string year)
        {
            decimal uitValue = 0;

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "SELECT ANIO_deVALUIT FROM M_ANIO WHERE ANIO_P_chCODANO = @AnioSeleccionado";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AnioSeleccionado", year);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            uitValue = Convert.ToDecimal(result);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el valor de la UIT para el año seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el valor de la UIT: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return uitValue;
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

        private int ObtenerPersPInCODPER_DOCU(string numDocumento)
        {
            int CODPER_DOCU = -1; // Valor predeterminado en caso de no encontrar el número de notificación

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener el NOTC_P_inCODNOT asociado al número de notificación
                    string query = "SELECT PERS_P_inCODPER FROM V_RELA_DOCU WHERE REDO_chNUMRED = @numDOCU";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@numDOCU", numDocumento);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            CODPER_DOCU = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el CODPER_DOCU: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return CODPER_DOCU;
        }
        private string obtenerNombreCompleto(string numeroDocumento)
        {
            string nombreCompleto = " ";
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener el NOMBRE DE LA PERSONA
                    string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_2");
                    string decryptedQuery = Decrypt(encryptedQuery);

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CodigoPersona", numeroDocumento);

                        object result = cmd.ExecuteScalar();

                        nombreCompleto = Convert.ToString(result);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el NOMBRE COMPLETO: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nombreCompleto;
        }

        private int ObtenerPERS_P_inCODPER(string numeroNotificacion)
        {
            int PERS_P_inCODPER = -1;
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener el NOTC_P_inCODNOT asociado al número de notificación
                    string query = "SELECT NOTC_inCODINF FROM M_NOTC WHERE NOTC_chNRONOT = @NumeroNotificacion";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroNotificacion", numeroNotificacion);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            PERS_P_inCODPER = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el NOTC_P_inCODNOT: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return PERS_P_inCODPER;
        }

        private int Obtener_codRDO(string numeroNotificacion)
        {
            int Rdocod = -1;
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener el NOTC_P_inCODNOT asociado al número de notificación
                    string query = "SELECT REDO_P_inCODRDO FROM M_NOTC WHERE NOTC_chNRONOT = @NumeroNotificacion";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroNotificacion", numeroNotificacion);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            Rdocod = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el NOTC_P_inCODNOT: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Rdocod;
        }

        private int ObtenerP_inCODANO(string numeroNotificacion, int notc_codnot)
        {
            int CODANO = -1;
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener el NOTC_P_inCODNOT asociado al número de notificación
                    string query = "SELECT ANIO_P_chCODANO FROM M_NOTC WHERE NOTC_chNRONOT =@NumeroNotificacion  AND NOTC_P_inCODNOT=@notc_codnot";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroNotificacion", numeroNotificacion);
                        cmd.Parameters.AddWithValue("@notc_codnot", notc_codnot);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            CODANO = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el NOTC_P_inCODNOT: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return CODANO;
        }

        private int obtenerCODIGOMULTA(string numMulta, int notc_P_codnot)
        {
            int codigMulta = 0;
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener el NOTC_P_inCODNOT asociado al número de notificación
                    string query = "SELECT MULC_P_inCODMUL FROM M_MULC WHERE MULC_chNROMUL = @NumeroMulta AND NOTC_P_inCODNOT=@NOTC_P_inCOD";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroMulta", numMulta);

                        cmd.Parameters.AddWithValue("@NOTC_P_inCOD", notc_P_codnot);

                        object result = cmd.ExecuteScalar();

                        codigMulta = Convert.ToInt32(result);
                        //MessageBox.Show("El codigoMulta es: ." + codigMulta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el NOTC_P_inCODNOT: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return codigMulta;
        }
        private int obtenerCODIGONOTD(int codigoNOTC)
        {
            int codiNOTD = -1;

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "SELECT NOTD_P_inCODNOT FROM V_NOTD WHERE NOTC_P_inCODNOT = @CodigoNOTC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CodigoNOTC", codigoNOTC);

                        object result = cmd.ExecuteScalar();


                        if (result != null && result != DBNull.Value)
                        {
                            codiNOTD = Convert.ToInt32(result);
                        }

                        //MessageBox.Show("El CCOR_P_inCODORI es: " + CCOR_P_inCODORI, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el CCOR_P_inCODORI: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return codiNOTD;
        }
        private int obtenerCTAC_P_inCODCTA(int ctacPinCODCTA)
        {
            int codiCTAC = -1;

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "SELECT CTAC_P_inCODCTA FROM M_CTAC WHERE CCOR_P_inCODORI = @CodigoCODCTA";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CodigoCODCTA", ctacPinCODCTA);

                        object result = cmd.ExecuteScalar();


                        if (result != null && result != DBNull.Value)
                        {
                            codiCTAC = Convert.ToInt32(result);
                        }

                        //MessageBox.Show("El CCOR_P_inCODORI es: " + CCOR_P_inCODORI, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el CCOR_P_inCODORI: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return codiCTAC;
        }
        private int obtenerCCOR_P_inCODORI(int codCodori)
        {
            int CCOR_P_inCODORI = -1;
            //MessageBox.Show("El CCOR_P_inCODORI es: " + codCodori, "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Consulta para obtener el CCOR_P_inCODORI asociado al número de multa
                    string query = "SELECT CCOR_P_inCODORI FROM M_CTAC_ORIG WHERE MULC_P_inCODMUL = @CodigoMulta";
                    //MessageBox.Show("Query: " + query, "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CodigoMulta", codCodori);

                        object result = cmd.ExecuteScalar();


                        if (result != null && result != DBNull.Value)
                        {
                            CCOR_P_inCODORI = Convert.ToInt32(result);
                        }

                        //MessageBox.Show("El CCOR_P_inCODORI es: " + CCOR_P_inCODORI, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener el CCOR_P_inCODORI: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return CCOR_P_inCODORI;
        }




        private void UpdateINMA_P_inCODINFInV_NOTD(int nuevoIdentificador, int notcPInCODNOT)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    // Actualizar el campo INMA_P_inCODINF en la tabla V_NOTD
                    string updateQuery = "UPDATE V_NOTD SET INMA_P_inCODINF = @NuevoIdentificador WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@NuevoIdentificador", nuevoIdentificador);
                        cmd.Parameters.AddWithValue("@NotcPInCODNOT", notcPInCODNOT);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al actualizar la tabla V_NOTD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private (int, string, string, int, decimal, string) ObtenerDescripcionInfraccion(string codigoInfraccion, string ordenanza)
        {
            int identificador = 0;
            string descripcion = "";
            string medida = "";
            decimal valorUIT = 0;
            int tipo_infracc = 0;
            string ordenanzaCodigo = ordenanza;

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = @"SELECT INFR.INMA_P_inCODINF, ORDE.ORDE_chNOMORD, ORDE.ORDE_chNROORD, INFR.INMA_chCODINF,
                            INFR.INMA_chDESINF, INFR.INMA_dePORUIT, TIPO_INFRA.TAMA_chDESTIP, INFR.INMA_chMEDCOM,INFR.TAMA_P_inCODTIP
                            FROM V_INFR_MADM INFR 
                            INNER JOIN M_ORDE ORDE ON INFR.ORDE_P_inCODORD = ORDE.ORDE_P_inCODORD
                            INNER JOIN M_TIPO_APLI_MADM TIPO_INFRA ON INFR.TAMA_P_inCODTIP = TIPO_INFRA.TAMA_P_inCODTIP
                            WHERE INFR.INMA_chCODINF = @CodigoInfraccionBuscado AND ORDE.ORDE_chNROORD = @CodInfraccion";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CodigoInfraccionBuscado", codigoInfraccion);
                        cmd.Parameters.AddWithValue("@CodInfraccion", ordenanzaCodigo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                identificador = Convert.ToInt32(reader["INMA_P_inCODINF"]);
                                descripcion = reader["INMA_chDESINF"].ToString();
                                medida = reader["INMA_chMEDCOM"].ToString();
                                tipo_infracc = Convert.ToInt32(reader["TAMA_P_inCODTIP"]);
                                valorUIT = Convert.ToDecimal(reader["INMA_dePORUIT"]);
                                ordenanzaCodigo = reader["ORDE_chNROORD"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como mejor consideres
                MessageBox.Show("Error al obtener la información de la infracción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (identificador, descripcion, medida, tipo_infracc, valorUIT, ordenanzaCodigo);
        }



        private void btnBuscarNotis_Click(object sender, EventArgs e)
        {

            //DateTime fechaInicio = dateTimePickerInicio.Value;
            //DateTime fechaFin = dateTimePickerFin.Value;

            string nombreInfractor = txtInfrac.Text.Trim();

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    string query = "SELECT PERS.PERS_chNOMCOM, NOTC.NOTC_chNRONOT, NOTC.ANIO_P_chCODANO, NOTC.SEGU_chUSULOG, NOTC.SEGU_chUSUMAQ, NOTC.SEGU_chUSUFEC " +
                                    "FROM M_NOTC NOTC " +
                                    "INNER JOIN M_PERS PERS ON NOTC.NOTC_inCODINF = PERS.PERS_P_inCODPER " +
                                    "LEFT JOIN V_NOTD NOTD ON NOTC.NOTC_P_inCODNOT = NOTD.NOTC_P_inCODNOT " +
                                    "WHERE PERS.PERS_chNOMCOM = @NombreInfractor ";


                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NombreInfractor", nombreInfractor);


                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            dataGridView1.DataSource = null;
                            dataTable.Clear(); // Limpiar solo el DataTable
                            adapter.Fill(dataTable);
                        }
                    }
                    ClearDataGridView();
                    // Configurar el DataGridView con los datos obtenidos
                    ConfigureDataGridViewMostrarNICS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el valor de la celda "NOTC_chNRONOT" de la fila seleccionada
                string numeroNotificacion = dataGridView1.SelectedRows[0].Cells["NOTC_chNRONOT"].Value.ToString();

                // Actualizar el estado en la tabla M_NOTC
                if (ActualizarEstadoM_NOTC(numeroNotificacion))
                {
                    MessageBox.Show("RECUERDA QUE CADA DESHABILITACIÓN ESTÁ AUDITORADA Y HACERLO SIN UN SUSTENTO ES UN DELITO INFORMÁTICO.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult sustentatorioResult = MessageBox.Show("¿Se ha presentado un documento sustentatorio?", "Documento Sustentatorio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verificar la respuesta al documento sustentatorio
                    if (sustentatorioResult == DialogResult.Yes)
                    {
                        // Crear una instancia del formulario "FormDocumentoResolucion" y pasar el valor
                        DeshabilitarMulta formDeshabilitarMulta = new DeshabilitarMulta(numeroNotificacion);
                        DialogResult formResult = formDeshabilitarMulta.ShowDialog();

                        // Actualizar el estado en la tabla V_NOTD (si existe)
                        ActualizarEstadoV_NOTD(numeroNotificacion);
                        ActualizaEstadorM_NOTC(numeroNotificacion);
                        int NOTC_P_inCODNOTDESHA = ObtenerNOTCPInCODNOT(numeroNotificacion);
                        int numMulta = obtenerNumeroMulta(NOTC_P_inCODNOTDESHA);
                        ActualizarM_MULC(NOTC_P_inCODNOTDESHA);
                        ActualizarM_CTAC_ORIGI(numMulta);
                        int CODORI = obtenerCODIRI(numMulta);
                        ActualizarM_CTAC(CODORI);
                        dataGridView1.Refresh();
                        // Actualizar el DataGridView para reflejar los cambios
                    }
                    else if (sustentatorioResult == DialogResult.No)
                    {
                        MessageBox.Show("NO SE SELECCIONÓ NADA ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para deshabilitar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void ActualizarM_CTAC_ORIGI(int codMulta)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "UPDATE M_CTAC_ORIG SET estado = 0 WHERE MULC_P_inCODMUL =@codMulta";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CodMulta", codMulta);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado en V_NOTD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void actualizarM_NOTC(int numeroNotificacion)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "UPDATE M_NOTC SET estado = 0 WHERE NOTC_P_inCODNOT =@NumeroNotificacion";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroNotificacion", numeroNotificacion);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado en V_NOTD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private bool ActualizarEstadoM_NOTC(string numeroNotificacion)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "UPDATE M_NOTC SET estado = 0 WHERE NOTC_chNRONOT = @NumeroNotificacion";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroNotificacion", numeroNotificacion);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Devuelve true si se afectó al menos una fila (es decir, se encontró el registro a deshabilitar)
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado en M_NOTC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ActualizarEstadoV_NOTD(string numeroNotificacion)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "UPDATE V_NOTD SET estado = 0 WHERE NOTC_P_inCODNOT = (SELECT NOTC_P_inCODNOT FROM M_NOTC WHERE NOTC_chNRONOT = @NumeroNotificacion)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroNotificacion", numeroNotificacion);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado en V_NOTD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizaEstadorM_NOTC(string numeroNotificacion)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "UPDATE M_NOTC SET estado = 0 WHERE NOTC_P_inCODNOT = (SELECT NOTC_P_inCODNOT FROM M_NOTC WHERE NOTC_chNRONOT = @NumeroNotificacion)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroNotificacion", numeroNotificacion);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado en V_NOTD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarM_MULC(int NOTC_P_inCODNOT)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "UPDATE M_MULC SET estado = 0 WHERE NOTC_P_inCODNOT=@NOTC_PinCODNOTDES";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NOTC_PinCODNOTDES", NOTC_P_inCODNOT);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado en V_NOTD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarM_CTAC(int codDiri)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "UPDATE M_CTAC SET estado = 0 WHERE CCOR_P_inCODORI=@CodCTAC AND TRIB_P_inCODTRI='6'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CodCTAC", codDiri);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado en V_NOTD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateEstadoInM_NOTC(int nuevoCodigoEstado, int notcPInCODNOT)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string updateQuery = "UPDATE M_NOTC SET ESMA_P_inCODEST = @NuevoCodigoEstado WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@NuevoCodigoEstado", nuevoCodigoEstado);
                        updateCmd.Parameters.AddWithValue("@NotcPInCODNOT", notcPInCODNOT);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado en M_NOTC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Dictionary<string, int> ObtenerEstadosMap()
        {
            Dictionary<string, int> estadosMap = new Dictionary<string, int>();

            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string query = "SELECT ESMA_chDESEST, ESMA_P_inCODEST FROM M_ESTA_MADM";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string estado = reader["ESMA_chDESEST"].ToString();
                                int codigoEstado = Convert.ToInt32(reader["ESMA_P_inCODEST"]);
                                estadosMap[estado] = codigoEstado;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener estados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estadosMap;
        }

        private string MostrarEstados(string mensaje, Dictionary<string, int> estados)
        {
            Form form = new Form();
            form.Width = 300;
            form.Height = 200;
            form.Text = mensaje;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;

            ListBox listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;

            foreach (var estado in estados.Keys)
            {
                listBox.Items.Add(estado);
            }

            listBox.SelectedIndexChanged += (sender, e) => form.Close();

            form.Controls.Add(listBox);
            form.ShowDialog();

            if (listBox.SelectedItem != null)
            {
                return listBox.SelectedItem.ToString();
            }

            return null;
        }


        private DateTime CalcularFechaHabil(DateTime fechaInicial, int diasHabiles)
        {
            int diasContados = 0;
            DateTime fechaActual = fechaInicial;

            while (diasContados < diasHabiles)
            {
                fechaActual = fechaActual.AddDays(1);

                if (fechaActual.DayOfWeek != DayOfWeek.Saturday && fechaActual.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasContados++;
                }
            }

            return fechaActual;
        }
        private void EjecutarProcedimientoAlmacenadoM_CTAC(int PERS_P_inCODPER, int ANIO_P_inCODANO, decimal valorMultaDecimal, int codigoOrigi)
        {

            string nombreUsuario = DatosCompartidos.Usuario;
            DateTime fechaEmision = DateTime.Now; // Cambia esto a la fecha correcta
            int mesEmision = fechaEmision.Month;
            //MessageBox.Show("EL VALOR DE LA MULTA ES: " + valorMultaDecimal, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("s_i_M_CTAC", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@iCTAC_P_inCODCTA", 0);
                        cmd.Parameters.AddWithValue("@iPERS_P_inCODPER", PERS_P_inCODPER);
                        cmd.Parameters.AddWithValue("@iCCPR_P_inCODPRO", 2);
                        cmd.Parameters.AddWithValue("@iCCOR_P_inCODORI", codigoOrigi);
                        cmd.Parameters.AddWithValue("@iCTAC_chESTCTA", "A");
                        cmd.Parameters.AddWithValue("@iCOSE_P_inCODSEC", 1);
                        cmd.Parameters.AddWithValue("@iANIO_P_chCODANO", ANIO_P_inCODANO.ToString());
                        cmd.Parameters.AddWithValue("@iCTAC_chPERCTA", mesEmision.ToString("D2"));
                        DateTime fechaVencimiento = CalcularFechaHabil(fechaEmision, 10);
                        cmd.Parameters.AddWithValue("@iTRIB_P_inCODTRI", 6);
                        cmd.Parameters.AddWithValue("@iCTAC_chFECEMI", DateTime.Now.ToString("yyyyMMdd"));
                        cmd.Parameters.AddWithValue("@iCTAC_chFECVEN", fechaVencimiento.ToString("yyyyMMdd"));
                        cmd.Parameters.AddWithValue("@iCTAC_chFECPAG", " ");
                        cmd.Parameters.AddWithValue("@iCTAC_deMONINS", valorMultaDecimal);
                        cmd.Parameters.AddWithValue("@iCTAC_deMONIND", 0);
                        cmd.Parameters.AddWithValue("@iCTAC_deMONEMI", 0);
                        cmd.Parameters.AddWithValue("@iCTAC_deMONEMD", 0);
                        cmd.Parameters.AddWithValue("@iCTAC_deMONREA", 0);
                        cmd.Parameters.AddWithValue("@iCTAC_deMONIAC", 0);
                        cmd.Parameters.AddWithValue("@iCTAC_deMONINT", 0);
                        cmd.Parameters.AddWithValue("@iCTAC_deMONOTR", 0);
                        cmd.Parameters.AddWithValue("@iCTAC_deMONDSC", 0);
                        cmd.Parameters.AddWithValue("@iCTAC_deMONTOT", 0);
                        cmd.Parameters.AddWithValue("@iCTAC_chDOCREF", "Referencia");
                        cmd.Parameters.AddWithValue("@iSEGU_chUSULOG", nombreUsuario);
                        cmd.Parameters.AddWithValue("@iSEGU_chUSUMAQ", Environment.MachineName);
                        cmd.Parameters.AddWithValue("@iSEGU_chUSUFEC", DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));
                        cmd.Parameters.Add("@oRESULT", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        string resultado = cmd.Parameters["@oRESULT"].Value.ToString();
                        //MessageBox.Show("Procedimiento almacenado ejecutado correctamente. " + resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (resultado == "0")
                        {
                            MessageBox.Show("Error al ejecutar el procedimiento EjecutarProcedimientoAlmacenadoM_CTAC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //MessageBox.Show("EjecutarProcedimientoAlmacenadoM_CTAC almacenado ejecutado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el procedimiento EjecutarProcedimientoAlmacenadoM_CTAC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EjecutarProcedimientoAlmacenadoV_MULD(int mulcPinCODMUL, int notcPinCODNOT, int ctacPinCODCTA)
        {
            string nombreUsuario = DatosCompartidos.Usuario;
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("s_i_V_MULD", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@iMULD_P_inCODMUL", 0);
                        cmd.Parameters.AddWithValue("@iMULC_P_inCODMUL", mulcPinCODMUL);
                        cmd.Parameters.AddWithValue("@iNOTD_P_inCODNOT", notcPinCODNOT);
                        cmd.Parameters.AddWithValue("@iCTAC_P_inCODCTA", ctacPinCODCTA);
                        cmd.Parameters.AddWithValue("@iMULD_chINFEST", " ");
                        cmd.Parameters.AddWithValue("@iMULD_chINFFEC", " ");
                        cmd.Parameters.AddWithValue("@iMULD_chINFOBS", " ");
                        cmd.Parameters.AddWithValue("@iSEGU_chUSULOG", nombreUsuario);
                        cmd.Parameters.AddWithValue("@iSEGU_chUSUMAQ", Environment.MachineName);
                        cmd.Parameters.AddWithValue("@iSEGU_chUSUFEC", DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));
                        cmd.Parameters.Add("@oRESULT", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        string resultado = cmd.Parameters["@oRESULT"].Value.ToString();
                        //MessageBox.Show("Procedimiento almacenado ejecutado correctamente." + resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (resultado == "0")
                        {
                            MessageBox.Show("Error al ejecutar el procedimiento EjecutarProcedimientoAlmacenadoV_MULD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //MessageBox.Show("ProcedimientoAlmacenadoV_MULD almacenado ejecutado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el procedimiento almacenado_ERROR_2: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EjecutarProcedimientoAlmacenadoM_MULC(int notcPInCODNOT, string numeroMulta, string multaMedidad, int codigoRDO, int ANIO_P_inCODANO)
        {
            string nombreUsuario = DatosCompartidos.Usuario;
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("s_i_M_MULC", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@iMULC_P_inCODMUL", 0);
                        cmd.Parameters.AddWithValue("@iANIO_P_chCODANO", "2024");
                        cmd.Parameters.AddWithValue("@iMULC_chNROMUL", numeroMulta);
                        cmd.Parameters.AddWithValue("@iMULC_chAUXMUL", "");
                        cmd.Parameters.AddWithValue("@iMULC_chFECMUL", DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@iESMA_P_inCODEST", 1);
                        cmd.Parameters.AddWithValue("@iNOTC_P_inCODNOT", notcPInCODNOT);
                        cmd.Parameters.AddWithValue("@iMULC_chCOMMUL", multaMedidad);
                        cmd.Parameters.AddWithValue("@iMULC_chOBSMUL", "");
                        cmd.Parameters.AddWithValue("@iREDO_P_inCODRDO", codigoRDO);
                        cmd.Parameters.AddWithValue("@iMULC_chEXIFEC", "");
                        cmd.Parameters.AddWithValue("@iMULC_chEXINRO", "");
                        cmd.Parameters.AddWithValue("@iMULC_chEXIINF", "");
                        cmd.Parameters.AddWithValue("@iMULC_chEXICON", "");
                        cmd.Parameters.AddWithValue("@iMULC_chMANIFI", "");
                        cmd.Parameters.AddWithValue("@iMULC_chANALIS", "");
                        cmd.Parameters.AddWithValue("@iMULC_chCONINF", "");
                        cmd.Parameters.AddWithValue("@iMULC_chMANTER", "");
                        cmd.Parameters.AddWithValue("@iMULC_inESTURB", 0);
                        cmd.Parameters.AddWithValue("@iMULC_chARTOPC", "");
                        cmd.Parameters.AddWithValue("@iSEGU_chUSULOG", nombreUsuario);
                        cmd.Parameters.AddWithValue("@iSEGU_chUSUMAQ", Environment.MachineName);
                        cmd.Parameters.AddWithValue("@iSEGU_chUSUFEC", DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));
                        cmd.Parameters.Add("@oRESULT", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        string resultado = cmd.Parameters["@oRESULT"].Value.ToString();
                        //MessageBox.Show("Procedimiento almacenado ejecutado correctamente." + resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (resultado == "0")
                        {
                            MessageBox.Show("Error al ejecutar el procedimiento EjecutarProcedimientoAlmacenadoM_MULC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //MessageBox.Show("ProcedimientoAlmacenadoM_MULC almacenado ejecutado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el procedimiento almacenado_ERROR_2: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void EjecutarProcedimientoAlmacenadoM_CTAC_ORIG(int numeroMulta, string numeroNotificacion, int ANIO_P_inCODANO)
        {
            string nombreUsuario = DatosCompartidos.Usuario;
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("s_i_M_CTAC_ORIG", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@iCCOR_P_inCODORI", 0);
                        cmd.Parameters.AddWithValue("@iHORE_P_inCODHOJ", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iPRUN_P_inCODPRE", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iFRAC_P_inCODFRA", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iLIQC_P_inCODLIQ", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iMULC_P_inCODMUL", numeroMulta);//PENDIENTE numeroMulta
                        cmd.Parameters.AddWithValue("@iPAPE_P_inCODPAP", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iALCA_P_inCODALC", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iVEHI_P_inCODVEH", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iLICA_P_inCODLIC", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iMTRI_P_inCODMTR", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iEXPC_P_inCODEXP", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iCDIE_P_inCODDEC", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iCOAM_P_inCODCOM", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iMECO_P_inCODMER", DBNull.Value);
                        cmd.Parameters.AddWithValue("@iCCOR_chDESORI", "MULTAS ADMINISTRATIVAS");
                        cmd.Parameters.AddWithValue("@iCCOR_chDETORI", numeroNotificacion + ANIO_P_inCODANO.ToString());//PENDIENTE
                        cmd.Parameters.AddWithValue("@iSEGU_chUSULOG", nombreUsuario);
                        cmd.Parameters.AddWithValue("@iSEGU_chUSUMAQ", Environment.MachineName);
                        cmd.Parameters.AddWithValue("@iSEGU_chUSUFEC", DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));
                        cmd.Parameters.Add("@oRESULT", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        string resultado = cmd.Parameters["@oRESULT"].Value.ToString();
                        //MessageBox.Show("Procedimiento almacenado s_i_M_CTAC_ORIG ejecutado correctamente: " + resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (resultado == "0")
                        {
                            MessageBox.Show("Error al ejecutar el procedimiento almacenado s_i_M_CTAC_ORIG.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //MessageBox.Show("Procedimiento almacenado s_i_M_CTAC_ORIG ejecutado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el procedimiento almacenado s_i_M_CTAC_ORIG: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void UpdateEstadoESMA_P_inCODESTInM_NOTC(int nuevoEstado, int notcPInCODNOT)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string updateQuery = "UPDATE M_NOTC SET ESMA_P_inCODEST = @NuevoEstado WHERE NOTC_P_inCODNOT = @NotcPInCODNOT";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                        updateCmd.Parameters.AddWithValue("@NotcPInCODNOT", notcPInCODNOT);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado en M_NOTC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckStatus(string numeroMultaValidar)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();

                    string selectQuery = "SELECT COUNT(*) FROM M_MULC WHERE ANIO_P_chCODANO='2024' AND MULC_chNROMUL=@numeroMultaValidar";

                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                    {
                        selectCmd.Parameters.AddWithValue("@numeroMultaValidar", numeroMultaValidar);

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


        private void btnGenerarMulta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                DialogResult optionResult = MessageBox.Show("¿Deseas GENERAR MULTA (SI) o CAMBIAR EL ESTADO(NO)?", "Opción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (optionResult == DialogResult.Yes)
                {
                    // Verificar si el usuario ya tiene una multa generada
                    if (selectedRow.Cells["ESMA_chDESEST"].Value.ToString() == "GENERADO")
                    {
                        MessageBox.Show("EL USUARIO YA TIENE MULTA GENERADA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Salir de la función porque no se puede generar otra multa.
                    }
                    string numeroMulta = Interaction.InputBox("Ingrese el número de multa:", "Número de Multa", "");

                    if (CheckStatus(numeroMulta))
                    {
                        MessageBox.Show($"LA MULTA {numeroMulta} YA EXISTE PARA EL AÑO 2024.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrEmpty(numeroMulta))
                    {
                        MessageBox.Show("INGRESE UN VALOR VALIDO", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(numeroMulta))
                    {
                        MessageBox.Show("INGRESE UN VALOR VALIDO PARA EL NUMERO DE MULTA ", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!Regex.IsMatch(numeroMulta, @"^[0-9]+$"))
                    {
                        MessageBox.Show("INGRESE UN VALOR VALIDO NUMERICO PARA EL NUMERO DE MULTA.", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (numeroMulta.Length < 6)
                    {
                        MessageBox.Show("EL NUMERO DE MULTA DEBE CONTENER 6 DIGITOS", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Dictionary<string, int> estadosMap = ObtenerEstadosMap();
                    if (estadosMap.Count > 0)
                    {
                        string estadoSeleccionado = MostrarEstados("Seleccione un estado:", estadosMap);

                        if (!string.IsNullOrEmpty(estadoSeleccionado) && estadosMap.ContainsKey(estadoSeleccionado))
                        {
                            int codigoEstadoSeleccionado = estadosMap[estadoSeleccionado];

                            DialogResult confirmResult = MessageBox.Show("¿Seguro que quiere cambiar el estado de esta notificación a '" + estadoSeleccionado + "'?", "Confirmar Cambio de Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (confirmResult == DialogResult.Yes)
                            {

                                using (SqlConnection connection = new SqlConnection("Data Source=171.15.10.9;Initial Catalog=SATMUNXP;User ID=sa;Password=averigualo2050$"))
                                {
                                    connection.Open();
                                    SqlTransaction transaction = connection.BeginTransaction();
                                    int notcPInCODNOT = ObtenerNOTCPInCODNOT(selectedRow.Cells["NOTC_chNRONOT"].Value.ToString());
                                    UpdateEstadoInM_NOTC(codigoEstadoSeleccionado, notcPInCODNOT);
                                    int PERS_P_inCODPER = ObtenerPERS_P_inCODPER(selectedRow.Cells["NOTC_chNRONOT"].Value.ToString());
                                    int ANIO_P_inCODANO = ObtenerP_inCODANO(selectedRow.Cells["NOTC_chNRONOT"].Value.ToString(), notcPInCODNOT);
                                    string VALOR_MULTA = selectedRow.Cells["NOTD_deMONINF"].Value.ToString();
                                    string numeroNotificacion = selectedRow.Cells["NOTC_chNRONOT"].Value.ToString();
                                    string multaMedidad = selectedRow.Cells["INMA_chMEDCOM"].Value.ToString();
                                    int codRDO = Obtener_codRDO(selectedRow.Cells["NOTC_chNRONOT"].Value.ToString());

                                    if (!int.TryParse(numeroMulta, out int numeroMultaint))
                                    {
                                        MessageBox.Show("Valor de obra inválido. Ingrese un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if (Decimal.TryParse(VALOR_MULTA, out decimal valorMultaDecimal))
                                    {
                                        //NO HAY NADA ES SOLO PARA VALIDAR
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo convertir el valor a decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    try
                                    {
                                        EjecutarProcedimientoAlmacenadoM_MULC(notcPInCODNOT, numeroMulta, multaMedidad, codRDO, ANIO_P_inCODANO);
                                        // Después de realizar el procedimiento almacenado y la actualización en M_MULC
                                        UpdateEstadoESMA_P_inCODESTInM_NOTC(3, notcPInCODNOT);
                                        int CodigoMulta = obtenerCODIGOMULTA(numeroMulta, notcPInCODNOT);
                                        //MessageBox.Show("El codigoOrigi(numeroMulta) es :." + numeroMulta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        EjecutarProcedimientoAlmacenadoM_CTAC_ORIG(CodigoMulta, numeroNotificacion, ANIO_P_inCODANO);
                                        //MessageBox.Show("El codigoOrigi(numeroMulta) es :." + numeroMulta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        int codigoOrigi = obtenerCCOR_P_inCODORI(CodigoMulta);
                                        //MessageBox.Show("EL VALOR DE LA MULTA ES: " + valorMultaDecimal, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        EjecutarProcedimientoAlmacenadoM_CTAC(PERS_P_inCODPER, ANIO_P_inCODANO, valorMultaDecimal, codigoOrigi);
                                        int codigoCTAC = obtenerCTAC_P_inCODCTA(codigoOrigi);
                                        int codigoNOTD = obtenerCODIGONOTD(notcPInCODNOT);
                                        //MessageBox.Show("El codigoOrigi(numeroMulta) es :." + codigoOrigi, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        EjecutarProcedimientoAlmacenadoV_MULD(CodigoMulta, codigoNOTD, codigoCTAC);
                                        selectedRow.Cells["ESMA_chDESEST"].Value = estadoSeleccionado;
                                        MessageBox.Show("SE HA GENERADO CORRECTAMENTE LA MULTA: " + numeroMulta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dataGridView1.Refresh();

                                    }
                                    catch (Exception ex)
                                    {
                                        // Si ocurre un error, realiza un rollback
                                        transaction.Rollback();

                                        MessageBox.Show("Error al realizar la operación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron estados disponibles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (selectedRow.Cells["ESMA_chDESEST"].Value.ToString() == "ACTIVO")
                    {
                        MessageBox.Show("GENERA LA MULTA ANTES DE HACER CAMBIOS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Salir de la función porque no se puede generar otra multa.
                    }
                    // El usuario eligió "Cambiar Estado"
                    string numeroNoti = selectedRow.Cells["NOTC_chNRONOT"].Value.ToString();
                    int notcPInCODNOT = ObtenerNOTCPInCODNOT(numeroNoti);
                    string estadoSeleccionado = Interaction.InputBox("Ingrese el estado (ANULADO, RECONSIDERADO o APELACION):", "Cambiar Estado", "");

                    switch (estadoSeleccionado.ToUpper())
                    {
                        case "ANULADO":
                            FormDocumentoResolucion formDocumentoResolucionAnulado = new FormDocumentoResolucion(ref notcPInCODNOT, ESRM_P_inCODEST);
                            DialogResult formResultAnulado = formDocumentoResolucionAnulado.ShowDialog();
                            CambiarEstadoMulta(notcPInCODNOT, 5);
                            CambiarEstadoNOTC(notcPInCODNOT, 5);
                            int NOTC_P_inCODNOTDESHA = ObtenerNOTCPInCODNOT(numeroNoti);
                            int numMulta = obtenerNumeroMulta(NOTC_P_inCODNOTDESHA);
                            ActualizarM_MULC(NOTC_P_inCODNOTDESHA);
                            ActualizarM_CTAC_ORIGI(numMulta);
                            int CODORI = obtenerCODIRI(numMulta);
                            actualizarM_NOTC(notcPInCODNOT);
                            ActualizarM_CTAC(CODORI);

                            dataGridView1.Refresh();
                            break;

                        case "RECONSIDERADO":
                            FormDocumentoResolucion formDocumentoResolucionReconsiderado = new FormDocumentoResolucion(ref notcPInCODNOT, ESRM_P_inCODEST);
                            DialogResult formResultReconsiderado = formDocumentoResolucionReconsiderado.ShowDialog();
                            CambiarEstadoMulta(notcPInCODNOT, 6);
                            dataGridView1.Refresh();
                            break;

                        case "APELACION":
                            FormDocumentoResolucion formDocumentoResolucionApelacion = new FormDocumentoResolucion(ref notcPInCODNOT, ESRM_P_inCODEST);
                            DialogResult formResultApelacion = formDocumentoResolucionApelacion.ShowDialog();
                            CambiarEstadoMulta(notcPInCODNOT, 7);
                            dataGridView1.Refresh();
                            break;

                        default:
                            MessageBox.Show("Estado no válido. Debe ser ANULADO, RECONSIDERADO o APELACION.", "Estado no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para generar la multa o cambiar el estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnBuscarMul(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;
            try
            {
                string numeroMulta = txtNumMulta.Text.Trim();

                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_4");
                    string decryptedQuery = Decrypt(encryptedQuery);

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroMulta", numeroMulta);
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            dataGridView1.DataSource = null;
                            dataTable.Clear(); // Limpiar solo el DataTable
                            adapter.Fill(dataTable);
                        }
                    }
                    ClearDataGridView();
                    ConfigureDataGridView_MULTAS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnExportExc(object sender, EventArgs e)
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

        private void btnBuscarInfractor_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;
            try
            {
                string nombreInfractor = txtInfrac.Text.Trim();

                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_1");
                    string decryptedQuery = Decrypt(encryptedQuery);

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NombreInfractor", nombreInfractor);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            dataGridView1.DataSource = null;
                            dataTable.Clear(); // Limpiar solo el DataTable
                            adapter.Fill(dataTable);
                        }
                    }
                    ClearDataGridView();
                    ConfigureDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBusqueDoc_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumDoc.ToString()))
            {
                MessageBox.Show("El campo documento no puede estar en blanco.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string numDocInfractor = txtNumDoc.Text.Trim();

                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_2");
                    string decryptedQuery = Decrypt(encryptedQuery);

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumDoC", numDocInfractor);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            dataGridView1.DataSource = null;
                            dataTable.Clear(); // Limpiar solo el DataTable
                            adapter.Fill(dataTable);
                        }
                    }

                    ClearDataGridView();
                    ConfigureDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //-----------------------------------------------------------------------------------------------------------------------------------------

        //INDEX CON UN ARBOL B LAS FECHAS, PARA AGILIZAR LAS BUSQUEDAS
        //EN CONSTRUCCIÓN
        //-------------------------------------------------------------------------------------------------------------------------

    }

}

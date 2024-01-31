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
    public partial class RegistroRSA : Form
    {
        public RegistroRSA()
        {
            InitializeComponent();
            txtNombre.ReadOnly = true;
            txtCodInfracc.ReadOnly = true;
            txtLugarInfracc.ReadOnly= true;
            txtActiv.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtMediProvi.ReadOnly = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=171.15.10.2;Initial Catalog=SATMUNXP;User ID=sa;Password=12345"))
                {
                    con.Open();

                    string encryptedQuery = Environment.GetEnvironmentVariable("QUERY_12");
                    string decryptedQuery = Decrypt(encryptedQuery);

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NumeroNIC", txtNumNIC.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNombre.Text = reader["PERS_chNOMCOM"].ToString();
                                txtCodInfracc.Text = reader["INMA_chCODINF"].ToString();
                                txtLugarInfracc.Text = reader["DIRECCION_INFRACCION"].ToString();
                                txtActiv.Text = reader["ACTI_chDESACT"].ToString();
                                txtDireccion.Text = reader["DIRECCION_FISCAL"].ToString();
                                txtMediProvi.Text = reader["INMA_chMEDCOM"].ToString();
                                // Agregar otros campos según sea necesario
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron registros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

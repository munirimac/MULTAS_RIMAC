using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class FormNuevaActividadComercial : Form
    {
        public string DescripcionActividad { get; private set; }
        public FormNuevaActividadComercial()
        {
            InitializeComponent();
        }

        private void btnAñadirACTI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAñadirActi.Text))
            {
                MessageBox.Show("Debes ingresar una descripción para la nueva actividad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la descripción de la nueva actividad ingresada por el usuario
            DescripcionActividad = txtAñadirActi.Text;

            // Indicar que el formulario se cerró de forma aceptada (OK)
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}


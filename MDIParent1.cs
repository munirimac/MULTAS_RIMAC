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
    public partial class MDIParent1 : Form
    {
       // private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void rEGISTRONICToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEGISTRONICToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroNIC FormRegistroNIC = new RegistroNIC();
            FormRegistroNIC.ShowDialog();
        }



        private void bUSQUEDANICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarNIC FormListarNIC = new ListarNIC();
            FormListarNIC.MdiParent = this.MdiParent;
            FormListarNIC.ShowDialog();
        }

        private void rEGISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroInfractor FormRegistroInfractor = new RegistroInfractor();
            FormRegistroInfractor.MdiParent = this.MdiParent;
            FormRegistroInfractor.ShowDialog();
        }

        private void bUSCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarInfractor FormBuscarInfractor = new BuscarInfractor();
            FormBuscarInfractor.MdiParent = this.MdiParent;
            FormBuscarInfractor.ShowDialog();
        }

        private void iNSPECTORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarInspector FormRegistroInspector = new RegistrarInspector();
            FormRegistroInspector.MdiParent = this.MdiParent;
            FormRegistroInspector.ShowDialog();
        }

        private void aCTIVIDADCOMERCIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroActividadComercial FormRegistroActividadComercial = new RegistroActividadComercial();
            FormRegistroActividadComercial.MdiParent = this.MdiParent;
            FormRegistroActividadComercial.ShowDialog();
        }

        private void rEGISTRORSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroRSA FormRegsitroRSA = new RegistroRSA();
            FormRegsitroRSA.MdiParent = this.MdiParent;
            FormRegsitroRSA.ShowDialog();
        }

        private void bUSQUEDARSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarRSA FormListarRSA = new ListarRSA();  
            FormListarRSA.MdiParent = this.MdiParent;
            FormListarRSA.ShowDialog();
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

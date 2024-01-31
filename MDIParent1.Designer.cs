
namespace WindowsFormsApp15
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.rEGISTRONICToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRONICToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bUSQUEDANICToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRORSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUSQUEDARSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOPORTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUSCARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSPECTORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTIVIDADCOMERCIALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRONICToolStripMenuItem,
            this.rSAToolStripMenuItem,
            this.sOPORTEToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1204, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // rEGISTRONICToolStripMenuItem
            // 
            this.rEGISTRONICToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRONICToolStripMenuItem1,
            this.bUSQUEDANICToolStripMenuItem});
            this.rEGISTRONICToolStripMenuItem.Name = "rEGISTRONICToolStripMenuItem";
            this.rEGISTRONICToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.rEGISTRONICToolStripMenuItem.Text = "N.I.C. - R.S.A";
            this.rEGISTRONICToolStripMenuItem.Click += new System.EventHandler(this.rEGISTRONICToolStripMenuItem_Click);
            // 
            // rEGISTRONICToolStripMenuItem1
            // 
            this.rEGISTRONICToolStripMenuItem1.Name = "rEGISTRONICToolStripMenuItem1";
            this.rEGISTRONICToolStripMenuItem1.Size = new System.Drawing.Size(249, 26);
            this.rEGISTRONICToolStripMenuItem1.Text = "REGISTRO N.I.C.";
            this.rEGISTRONICToolStripMenuItem1.Click += new System.EventHandler(this.rEGISTRONICToolStripMenuItem1_Click);
            // 
            // bUSQUEDANICToolStripMenuItem
            // 
            this.bUSQUEDANICToolStripMenuItem.Name = "bUSQUEDANICToolStripMenuItem";
            this.bUSQUEDANICToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.bUSQUEDANICToolStripMenuItem.Text = "BUSQUEDA N.I.C. Y RSA";
            this.bUSQUEDANICToolStripMenuItem.Click += new System.EventHandler(this.bUSQUEDANICToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRORSAToolStripMenuItem,
            this.bUSQUEDARSAToolStripMenuItem});
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.rSAToolStripMenuItem.Text = "INGRESOS";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // rEGISTRORSAToolStripMenuItem
            // 
            this.rEGISTRORSAToolStripMenuItem.Name = "rEGISTRORSAToolStripMenuItem";
            this.rEGISTRORSAToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.rEGISTRORSAToolStripMenuItem.Text = "REGISTRO R.S.A.";
            this.rEGISTRORSAToolStripMenuItem.Visible = false;
            this.rEGISTRORSAToolStripMenuItem.Click += new System.EventHandler(this.rEGISTRORSAToolStripMenuItem_Click);
            // 
            // bUSQUEDARSAToolStripMenuItem
            // 
            this.bUSQUEDARSAToolStripMenuItem.Name = "bUSQUEDARSAToolStripMenuItem";
            this.bUSQUEDARSAToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.bUSQUEDARSAToolStripMenuItem.Text = "EXPORTAR";
            this.bUSQUEDARSAToolStripMenuItem.Click += new System.EventHandler(this.bUSQUEDARSAToolStripMenuItem_Click);
            // 
            // sOPORTEToolStripMenuItem
            // 
            this.sOPORTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERSONASToolStripMenuItem,
            this.iNSPECTORESToolStripMenuItem,
            this.aCTIVIDADCOMERCIALToolStripMenuItem});
            this.sOPORTEToolStripMenuItem.Name = "sOPORTEToolStripMenuItem";
            this.sOPORTEToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.sOPORTEToolStripMenuItem.Text = "MANTENIMIENTO";
            this.sOPORTEToolStripMenuItem.Visible = false;
            // 
            // pERSONASToolStripMenuItem
            // 
            this.pERSONASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRARToolStripMenuItem,
            this.bUSCARToolStripMenuItem});
            this.pERSONASToolStripMenuItem.Name = "pERSONASToolStripMenuItem";
            this.pERSONASToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.pERSONASToolStripMenuItem.Text = "PERSONAS";
            // 
            // rEGISTRARToolStripMenuItem
            // 
            this.rEGISTRARToolStripMenuItem.Name = "rEGISTRARToolStripMenuItem";
            this.rEGISTRARToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.rEGISTRARToolStripMenuItem.Text = "REGISTRAR";
            this.rEGISTRARToolStripMenuItem.Click += new System.EventHandler(this.rEGISTRARToolStripMenuItem_Click);
            // 
            // bUSCARToolStripMenuItem
            // 
            this.bUSCARToolStripMenuItem.Name = "bUSCARToolStripMenuItem";
            this.bUSCARToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.bUSCARToolStripMenuItem.Text = "BUSCAR";
            this.bUSCARToolStripMenuItem.Click += new System.EventHandler(this.bUSCARToolStripMenuItem_Click);
            // 
            // iNSPECTORESToolStripMenuItem
            // 
            this.iNSPECTORESToolStripMenuItem.Name = "iNSPECTORESToolStripMenuItem";
            this.iNSPECTORESToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.iNSPECTORESToolStripMenuItem.Text = "INSPECTORES";
            this.iNSPECTORESToolStripMenuItem.Click += new System.EventHandler(this.iNSPECTORESToolStripMenuItem_Click);
            // 
            // aCTIVIDADCOMERCIALToolStripMenuItem
            // 
            this.aCTIVIDADCOMERCIALToolStripMenuItem.Name = "aCTIVIDADCOMERCIALToolStripMenuItem";
            this.aCTIVIDADCOMERCIALToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.aCTIVIDADCOMERCIALToolStripMenuItem.Text = "ACTIVIDAD COMERCIAL";
            this.aCTIVIDADCOMERCIALToolStripMenuItem.Click += new System.EventHandler(this.aCTIVIDADCOMERCIALToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 709);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1204, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp15.Properties.Resources.muni_rimac_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1214, 675);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 735);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÓDULO DE SANCIONES";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRONICToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRONICToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bUSQUEDANICToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRORSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUSQUEDARSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOPORTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUSCARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSPECTORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCTIVIDADCOMERCIALToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}




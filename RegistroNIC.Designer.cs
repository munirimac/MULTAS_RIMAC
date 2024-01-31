
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    partial class RegistroNIC
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFecNic = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraNic = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboAnioNIC = new System.Windows.Forms.ComboBox();
            this.lblNombreInfractor = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRepresentanteLegal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPorcentajeObra = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.labelValorObraX = new System.Windows.Forms.Label();
            this.cboOrdenanza = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorObra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantUIT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipInfracc = new System.Windows.Forms.ComboBox();
            this.txtNumOrdenanza = new System.Windows.Forms.TextBox();
            this.textCodUniIfracc = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtValorInfraccion = new System.Windows.Forms.TextBox();
            this.txtPorcentajeInfraccion = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtValorUIT = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMotivoInfraccion = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtInfraccion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textDirecFiscal = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGuardarNOTIFIC = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.dtpFecRecp = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarInfrac = new System.Windows.Forms.Button();
            this.btnAñadirInfractor = new System.Windows.Forms.Button();
            this.btnAñadirActividadComercial = new System.Windows.Forms.Button();
            this.btnAñadirInspector = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarInfra = new System.Windows.Forms.Button();
            this.btnBuscarPersona = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE N.I.C";
            // 
            // txtNumNIC
            // 
            this.txtNumNIC.Location = new System.Drawing.Point(232, 129);
            this.txtNumNIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumNIC.Name = "txtNumNIC";
            this.txtNumNIC.Size = new System.Drawing.Size(132, 22);
            this.txtNumNIC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "NUMERO DE N.I.C.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "FECHA DE N.I.C.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "NOMB. INFRACTOR";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(643, 129);
            this.txtNumDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(192, 22);
            this.txtNumDoc.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "DIRECCION FISCAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "DIRECCION INFRACCIÓN";
            // 
            // dtpFecNic
            // 
            this.dtpFecNic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecNic.Location = new System.Drawing.Point(557, 102);
            this.dtpFecNic.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecNic.Name = "dtpFecNic";
            this.dtpFecNic.Size = new System.Drawing.Size(139, 22);
            this.dtpFecNic.TabIndex = 21;
            // 
            // dtpHoraNic
            // 
            this.dtpHoraNic.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraNic.Location = new System.Drawing.Point(769, 102);
            this.dtpHoraNic.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraNic.Name = "dtpHoraNic";
            this.dtpHoraNic.Size = new System.Drawing.Size(100, 22);
            this.dtpHoraNic.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(711, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "HORA :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 107);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "AÑO N.I.C.";
            // 
            // cboAnioNIC
            // 
            this.cboAnioNIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnioNIC.FormattingEnabled = true;
            this.cboAnioNIC.Items.AddRange(new object[] {
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.cboAnioNIC.Location = new System.Drawing.Point(232, 102);
            this.cboAnioNIC.Margin = new System.Windows.Forms.Padding(4);
            this.cboAnioNIC.Name = "cboAnioNIC";
            this.cboAnioNIC.Size = new System.Drawing.Size(132, 24);
            this.cboAnioNIC.TabIndex = 24;
            this.cboAnioNIC.SelectedIndexChanged += new System.EventHandler(this.cboAnioNIC_SelectedIndexChanged);
            // 
            // lblNombreInfractor
            // 
            this.lblNombreInfractor.AutoSize = true;
            this.lblNombreInfractor.Location = new System.Drawing.Point(554, 157);
            this.lblNombreInfractor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreInfractor.Name = "lblNombreInfractor";
            this.lblNombreInfractor.Size = new System.Drawing.Size(117, 16);
            this.lblNombreInfractor.TabIndex = 27;
            this.lblNombreInfractor.Text = "lblNombreInfractor";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(135, 238);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "INSPECTOR";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 271);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 16);
            this.label17.TabIndex = 33;
            this.label17.Text = "ACTIVIDAD COMERCIAL";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 304);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(173, 16);
            this.label18.TabIndex = 35;
            this.label18.Text = "REPRESENTANTE LEGAL";
            // 
            // txtRepresentanteLegal
            // 
            this.txtRepresentanteLegal.Location = new System.Drawing.Point(235, 300);
            this.txtRepresentanteLegal.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepresentanteLegal.Name = "txtRepresentanteLegal";
            this.txtRepresentanteLegal.Size = new System.Drawing.Size(421, 22);
            this.txtRepresentanteLegal.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPorcentajeObra);
            this.groupBox1.Controls.Add(this.txtPorcentaje);
            this.groupBox1.Controls.Add(this.labelValorObraX);
            this.groupBox1.Controls.Add(this.cboOrdenanza);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtValorObra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCantUIT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboTipInfracc);
            this.groupBox1.Controls.Add(this.txtNumOrdenanza);
            this.groupBox1.Controls.Add(this.textCodUniIfracc);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtValorInfraccion);
            this.groupBox1.Controls.Add(this.txtPorcentajeInfraccion);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtValorUIT);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtMotivoInfraccion);
            this.groupBox1.Controls.Add(this.btnBuscarInfra);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtInfraccion);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(44, 372);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(889, 250);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFRACCION";
            // 
            // txtPorcentajeObra
            // 
            this.txtPorcentajeObra.AutoSize = true;
            this.txtPorcentajeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeObra.Location = new System.Drawing.Point(644, 124);
            this.txtPorcentajeObra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPorcentajeObra.Name = "txtPorcentajeObra";
            this.txtPorcentajeObra.Size = new System.Drawing.Size(74, 13);
            this.txtPorcentajeObra.TabIndex = 65;
            this.txtPorcentajeObra.Text = "PORCENTAJE";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(647, 143);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(65, 22);
            this.txtPorcentaje.TabIndex = 63;
            // 
            // labelValorObraX
            // 
            this.labelValorObraX.AutoSize = true;
            this.labelValorObraX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorObraX.Location = new System.Drawing.Point(621, 145);
            this.labelValorObraX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorObraX.Name = "labelValorObraX";
            this.labelValorObraX.Size = new System.Drawing.Size(18, 17);
            this.labelValorObraX.TabIndex = 62;
            this.labelValorObraX.Text = "X";
            // 
            // cboOrdenanza
            // 
            this.cboOrdenanza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenanza.FormattingEnabled = true;
            this.cboOrdenanza.Items.AddRange(new object[] {
            "234",
            "432",
            "472",
            "283",
            "536",
            "556",
            "581",
            "583",
            "587",
            "588",
            "612"});
            this.cboOrdenanza.Location = new System.Drawing.Point(191, 34);
            this.cboOrdenanza.Margin = new System.Windows.Forms.Padding(4);
            this.cboOrdenanza.Name = "cboOrdenanza";
            this.cboOrdenanza.Size = new System.Drawing.Size(96, 24);
            this.cboOrdenanza.TabIndex = 53;
            this.cboOrdenanza.SelectedIndexChanged += new System.EventHandler(this.cboOrdenanza_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 124);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "VALOR DE LA OBRA";
            // 
            // txtValorObra
            // 
            this.txtValorObra.Location = new System.Drawing.Point(513, 143);
            this.txtValorObra.Name = "txtValorObra";
            this.txtValorObra.Size = new System.Drawing.Size(100, 22);
            this.txtValorObra.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(689, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "CANTIDAD DE UITS";
            // 
            // txtCantUIT
            // 
            this.txtCantUIT.Location = new System.Drawing.Point(835, 29);
            this.txtCantUIT.Name = "txtCantUIT";
            this.txtCantUIT.Size = new System.Drawing.Size(34, 22);
            this.txtCantUIT.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "TIPO DE INFRACCION";
            // 
            // cboTipInfracc
            // 
            this.cboTipInfracc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipInfracc.FormattingEnabled = true;
            this.cboTipInfracc.Items.AddRange(new object[] {
            "PORCENTAJE",
            "VALOR DE OBRA",
            "CANTIDAD"});
            this.cboTipInfracc.Location = new System.Drawing.Point(472, 29);
            this.cboTipInfracc.Name = "cboTipInfracc";
            this.cboTipInfracc.Size = new System.Drawing.Size(204, 24);
            this.cboTipInfracc.TabIndex = 56;
            this.cboTipInfracc.SelectedIndexChanged += new System.EventHandler(this.cboTipInfracc_SelectedIndexChanged_1);
            // 
            // txtNumOrdenanza
            // 
            this.txtNumOrdenanza.Location = new System.Drawing.Point(498, 98);
            this.txtNumOrdenanza.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumOrdenanza.Name = "txtNumOrdenanza";
            this.txtNumOrdenanza.Size = new System.Drawing.Size(98, 22);
            this.txtNumOrdenanza.TabIndex = 43;
            // 
            // textCodUniIfracc
            // 
            this.textCodUniIfracc.Location = new System.Drawing.Point(187, 64);
            this.textCodUniIfracc.Margin = new System.Windows.Forms.Padding(4);
            this.textCodUniIfracc.Name = "textCodUniIfracc";
            this.textCodUniIfracc.Size = new System.Drawing.Size(42, 22);
            this.textCodUniIfracc.TabIndex = 42;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(491, 190);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 29);
            this.label27.TabIndex = 41;
            this.label27.Text = "=";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(355, 198);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(18, 17);
            this.label26.TabIndex = 40;
            this.label26.Text = "X";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(535, 176);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 39;
            this.label25.Text = "VALOR S/";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(390, 178);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "PORCENTAJE";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(286, 178);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 13);
            this.label23.TabIndex = 37;
            this.label23.Text = "UIT";
            // 
            // txtValorInfraccion
            // 
            this.txtValorInfraccion.Location = new System.Drawing.Point(525, 193);
            this.txtValorInfraccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorInfraccion.Name = "txtValorInfraccion";
            this.txtValorInfraccion.Size = new System.Drawing.Size(88, 22);
            this.txtValorInfraccion.TabIndex = 36;
            // 
            // txtPorcentajeInfraccion
            // 
            this.txtPorcentajeInfraccion.Location = new System.Drawing.Point(378, 193);
            this.txtPorcentajeInfraccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorcentajeInfraccion.Name = "txtPorcentajeInfraccion";
            this.txtPorcentajeInfraccion.Size = new System.Drawing.Size(101, 22);
            this.txtPorcentajeInfraccion.TabIndex = 35;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(194, 197);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 16);
            this.label22.TabIndex = 34;
            this.label22.Text = "VALOR:";
            // 
            // txtValorUIT
            // 
            this.txtValorUIT.Location = new System.Drawing.Point(263, 193);
            this.txtValorUIT.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorUIT.Name = "txtValorUIT";
            this.txtValorUIT.Size = new System.Drawing.Size(88, 22);
            this.txtValorUIT.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(112, 101);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 16);
            this.label21.TabIndex = 32;
            this.label21.Text = "MOTIVO:";
            // 
            // txtMotivoInfraccion
            // 
            this.txtMotivoInfraccion.Location = new System.Drawing.Point(189, 97);
            this.txtMotivoInfraccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivoInfraccion.Multiline = true;
            this.txtMotivoInfraccion.Name = "txtMotivoInfraccion";
            this.txtMotivoInfraccion.Size = new System.Drawing.Size(300, 74);
            this.txtMotivoInfraccion.TabIndex = 30;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(51, 68);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 16);
            this.label20.TabIndex = 28;
            this.label20.Text = "COD INFRACCIÓN";
            // 
            // txtInfraccion
            // 
            this.txtInfraccion.Location = new System.Drawing.Point(233, 64);
            this.txtInfraccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfraccion.Name = "txtInfraccion";
            this.txtInfraccion.Size = new System.Drawing.Size(192, 22);
            this.txtInfraccion.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(81, 37);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 16);
            this.label19.TabIndex = 6;
            this.label19.Text = "ORDENANZA";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "RUC",
            "CE",
            "PTP",
            "PASAPORTE"});
            this.cboTipoDoc.Location = new System.Drawing.Point(556, 129);
            this.cboTipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(76, 24);
            this.cboTipoDoc.TabIndex = 37;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(0, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 23);
            this.label30.TabIndex = 47;
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Location = new System.Drawing.Point(556, 157);
            this.txtNombrePersona.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(279, 22);
            this.txtNombrePersona.TabIndex = 46;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 237);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 22);
            this.textBox1.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 265);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 22);
            this.textBox2.TabIndex = 49;
            // 
            // textDirecFiscal
            // 
            this.textDirecFiscal.Location = new System.Drawing.Point(232, 182);
            this.textDirecFiscal.Margin = new System.Windows.Forms.Padding(4);
            this.textDirecFiscal.Name = "textDirecFiscal";
            this.textDirecFiscal.Size = new System.Drawing.Size(424, 22);
            this.textDirecFiscal.TabIndex = 50;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(232, 209);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(423, 22);
            this.textBox3.TabIndex = 51;
            // 
            // btnGuardarNOTIFIC
            // 
            this.btnGuardarNOTIFIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNOTIFIC.Location = new System.Drawing.Point(348, 330);
            this.btnGuardarNOTIFIC.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarNOTIFIC.Name = "btnGuardarNOTIFIC";
            this.btnGuardarNOTIFIC.Size = new System.Drawing.Size(212, 51);
            this.btnGuardarNOTIFIC.TabIndex = 43;
            this.btnGuardarNOTIFIC.Text = "GUARDAR NOTIFICACIÓN";
            this.btnGuardarNOTIFIC.UseVisualStyleBackColor = true;
            this.btnGuardarNOTIFIC.Click += new System.EventHandler(this.btnGuardarNOTIFIC_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(665, 305);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 16);
            this.label29.TabIndex = 38;
            this.label29.Text = "FEC DE RECP:";
            // 
            // dtpFecRecp
            // 
            this.dtpFecRecp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecRecp.Location = new System.Drawing.Point(775, 300);
            this.dtpFecRecp.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecRecp.Name = "dtpFecRecp";
            this.dtpFecRecp.Size = new System.Drawing.Size(139, 22);
            this.dtpFecRecp.TabIndex = 39;
            // 
            // btnBuscarInfrac
            // 
            this.btnBuscarInfrac.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.logo_añadir;
            this.btnBuscarInfrac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarInfrac.Location = new System.Drawing.Point(663, 205);
            this.btnBuscarInfrac.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarInfrac.Name = "btnBuscarInfrac";
            this.btnBuscarInfrac.Size = new System.Drawing.Size(33, 31);
            this.btnBuscarInfrac.TabIndex = 52;
            this.btnBuscarInfrac.UseCompatibleTextRendering = true;
            this.btnBuscarInfrac.UseVisualStyleBackColor = true;
            this.btnBuscarInfrac.Click += new System.EventHandler(this.btnBuscInfrac);
            // 
            // btnAñadirInfractor
            // 
            this.btnAñadirInfractor.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.logo_añadir;
            this.btnAñadirInfractor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadirInfractor.Location = new System.Drawing.Point(873, 129);
            this.btnAñadirInfractor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirInfractor.Name = "btnAñadirInfractor";
            this.btnAñadirInfractor.Size = new System.Drawing.Size(33, 31);
            this.btnAñadirInfractor.TabIndex = 45;
            this.btnAñadirInfractor.UseCompatibleTextRendering = true;
            this.btnAñadirInfractor.UseVisualStyleBackColor = true;
            this.btnAñadirInfractor.Click += new System.EventHandler(this.btnAñadirInfractor_Click);
            // 
            // btnAñadirActividadComercial
            // 
            this.btnAñadirActividadComercial.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.logo_añadir;
            this.btnAñadirActividadComercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadirActividadComercial.Location = new System.Drawing.Point(516, 263);
            this.btnAñadirActividadComercial.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirActividadComercial.Name = "btnAñadirActividadComercial";
            this.btnAñadirActividadComercial.Size = new System.Drawing.Size(33, 31);
            this.btnAñadirActividadComercial.TabIndex = 44;
            this.btnAñadirActividadComercial.UseCompatibleTextRendering = true;
            this.btnAñadirActividadComercial.UseVisualStyleBackColor = true;
            this.btnAñadirActividadComercial.Click += new System.EventHandler(this.btnAñadirActividadComercial_Click);
            // 
            // btnAñadirInspector
            // 
            this.btnAñadirInspector.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.logo_añadir;
            this.btnAñadirInspector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadirInspector.Location = new System.Drawing.Point(516, 234);
            this.btnAñadirInspector.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirInspector.Name = "btnAñadirInspector";
            this.btnAñadirInspector.Size = new System.Drawing.Size(33, 31);
            this.btnAñadirInspector.TabIndex = 43;
            this.btnAñadirInspector.UseCompatibleTextRendering = true;
            this.btnAñadirInspector.UseVisualStyleBackColor = true;
            this.btnAñadirInspector.Click += new System.EventHandler(this.btnAñadirInspector_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Image = global::WindowsFormsApp15.Properties.Resources.guardar32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(690, 190);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(191, 51);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "GUARDAR     ";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscarInfra
            // 
            this.btnBuscarInfra.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.search;
            this.btnBuscarInfra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarInfra.Location = new System.Drawing.Point(433, 60);
            this.btnBuscarInfra.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarInfra.Name = "btnBuscarInfra";
            this.btnBuscarInfra.Size = new System.Drawing.Size(33, 31);
            this.btnBuscarInfra.TabIndex = 29;
            this.btnBuscarInfra.UseVisualStyleBackColor = true;
            this.btnBuscarInfra.Click += new System.EventHandler(this.btnBuscarInfra_Click);
            // 
            // btnBuscarPersona
            // 
            this.btnBuscarPersona.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.search;
            this.btnBuscarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPersona.Location = new System.Drawing.Point(840, 128);
            this.btnBuscarPersona.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPersona.Name = "btnBuscarPersona";
            this.btnBuscarPersona.Size = new System.Drawing.Size(33, 31);
            this.btnBuscarPersona.TabIndex = 26;
            this.btnBuscarPersona.UseVisualStyleBackColor = true;
            this.btnBuscarPersona.Click += new System.EventHandler(this.btnBuscarPersona_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp15.Properties.Resources.muni_rimac_logo;
            this.pictureBox1.Location = new System.Drawing.Point(864, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroNIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(988, 656);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardarNOTIFIC);
            this.Controls.Add(this.btnBuscarInfrac);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textDirecFiscal);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNombrePersona);
            this.Controls.Add(this.btnAñadirInfractor);
            this.Controls.Add(this.btnAñadirActividadComercial);
            this.Controls.Add(this.btnAñadirInspector);
            this.Controls.Add(this.dtpFecRecp);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtRepresentanteLegal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblNombreInfractor);
            this.Controls.Add(this.btnBuscarPersona);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboAnioNIC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpHoraNic);
            this.Controls.Add(this.dtpFecNic);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumNIC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroNIC";
            this.Text = "REGISTRO DE N.I.C.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFecNic;
        private System.Windows.Forms.DateTimePicker dtpHoraNic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboAnioNIC;
        private System.Windows.Forms.Button btnBuscarPersona;
        private System.Windows.Forms.Label lblNombreInfractor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRepresentanteLegal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtValorInfraccion;
        private System.Windows.Forms.TextBox txtPorcentajeInfraccion;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtValorUIT;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtMotivoInfraccion;
        private System.Windows.Forms.Button btnBuscarInfra;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtInfraccion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboTipoDoc;// TO DO RELA_1
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAñadirInspector;
        private System.Windows.Forms.Button btnAñadirActividadComercial;
        private System.Windows.Forms.Button btnAñadirInfractor;
        private System.Windows.Forms.TextBox txtNombrePersona;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textDirecFiscal;
        private TextBox textBox3;
        private Button btnBuscarInfrac;
        private TextBox textCodUniIfracc;
        private Button btnGuardarNOTIFIC;
        private TextBox txtNumOrdenanza;
        private Label label7;
        private ComboBox cboTipInfracc;
        private TextBox txtCantUIT;
        private Label label8;
        private TextBox txtValorObra;
        private Label label9;
        private ComboBox cboOrdenanza;
        private Label label29;
        private Label txtPorcentajeObra;
        private TextBox txtPorcentaje;
        private Label labelValorObraX;
        private DateTimePicker dtpFecRecp;
        private PictureBox pictureBox1;
    }
}


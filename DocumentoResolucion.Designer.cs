namespace WindowsFormsApp15
{
    partial class FormDocumentoResolucion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerRegis = new System.Windows.Forms.DateTimePicker();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataTimePickerFechDoc = new System.Windows.Forms.DateTimePicker();
            this.txtNroExp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResueltoDoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNoti = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRepresLegal = new System.Windows.Forms.TextBox();
            this.btnGuardarReso = new System.Windows.Forms.Button();
            this.cboDocuReso = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaExp = new System.Windows.Forms.DateTimePicker();
            this.txtAñoExp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMotivoInfraccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "DESCRIPCIÓN DE RECURSO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "FECHA DE REGISTRO";
            // 
            // dateTimePickerRegis
            // 
            this.dateTimePickerRegis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRegis.Location = new System.Drawing.Point(270, 58);
            this.dateTimePickerRegis.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerRegis.Name = "dateTimePickerRegis";
            this.dateTimePickerRegis.Size = new System.Drawing.Size(112, 22);
            this.dateTimePickerRegis.TabIndex = 19;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "RECONSIDERACIÓN",
            "APELACIÓN",
            "DEMANDA",
            "OTROS",
            "REGULARIZACION OM-018-2011"});
            this.cboEstado.Location = new System.Drawing.Point(270, 134);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(432, 24);
            this.cboEstado.TabIndex = 38;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "ESTADO DEL RECURSO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = " AÑO EXPEDIENTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "NRO. EXPEDIENTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "FECHA EXPEDIENTE";
            // 
            // dataTimePickerFechDoc
            // 
            this.dataTimePickerFechDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataTimePickerFechDoc.Location = new System.Drawing.Point(270, 348);
            this.dataTimePickerFechDoc.Margin = new System.Windows.Forms.Padding(4);
            this.dataTimePickerFechDoc.Name = "dataTimePickerFechDoc";
            this.dataTimePickerFechDoc.Size = new System.Drawing.Size(112, 22);
            this.dataTimePickerFechDoc.TabIndex = 43;
            // 
            // txtNroExp
            // 
            this.txtNroExp.Location = new System.Drawing.Point(349, 201);
            this.txtNroExp.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroExp.Name = "txtNroExp";
            this.txtNroExp.Size = new System.Drawing.Size(96, 22);
            this.txtNroExp.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = " RESUELTO C / DOCUMENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = " FECHA DEL DOCUMENTO";
            // 
            // txtResueltoDoc
            // 
            this.txtResueltoDoc.Location = new System.Drawing.Point(270, 311);
            this.txtResueltoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtResueltoDoc.Name = "txtResueltoDoc";
            this.txtResueltoDoc.Size = new System.Drawing.Size(432, 22);
            this.txtResueltoDoc.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 353);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "FECHA DE NOTIFICACIÓN";
            // 
            // dateTimePickerFechaNoti
            // 
            this.dateTimePickerFechaNoti.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaNoti.Location = new System.Drawing.Point(590, 348);
            this.dateTimePickerFechaNoti.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaNoti.Name = "dateTimePickerFechaNoti";
            this.dateTimePickerFechaNoti.Size = new System.Drawing.Size(112, 22);
            this.dateTimePickerFechaNoti.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 378);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = " REPRESENTANTE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 394);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 16);
            this.label11.TabIndex = 53;
            this.label11.Text = " LEGAL/TERCERO";
            // 
            // txtRepresLegal
            // 
            this.txtRepresLegal.Location = new System.Drawing.Point(273, 378);
            this.txtRepresLegal.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepresLegal.Name = "txtRepresLegal";
            this.txtRepresLegal.Size = new System.Drawing.Size(432, 22);
            this.txtRepresLegal.TabIndex = 54;
            // 
            // btnGuardarReso
            // 
            this.btnGuardarReso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarReso.Location = new System.Drawing.Point(375, 409);
            this.btnGuardarReso.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarReso.Name = "btnGuardarReso";
            this.btnGuardarReso.Size = new System.Drawing.Size(117, 28);
            this.btnGuardarReso.TabIndex = 55;
            this.btnGuardarReso.Text = "GUARDAR";
            this.btnGuardarReso.UseVisualStyleBackColor = true;
            this.btnGuardarReso.Click += new System.EventHandler(this.btnGuardarReso_Click);
            // 
            // cboDocuReso
            // 
            this.cboDocuReso.FormattingEnabled = true;
            this.cboDocuReso.Items.AddRange(new object[] {
            "FUNDADO",
            "IMPR. FALTA NUEVA PRUEBA",
            "INFUNDADO",
            "IMPR. EXTEMPORANEO",
            "IMPR. POR LEGITIMIDAD",
            "IMPR. POR PAGO"});
            this.cboDocuReso.Location = new System.Drawing.Point(270, 96);
            this.cboDocuReso.Margin = new System.Windows.Forms.Padding(4);
            this.cboDocuReso.Name = "cboDocuReso";
            this.cboDocuReso.Size = new System.Drawing.Size(432, 24);
            this.cboDocuReso.TabIndex = 56;
            this.cboDocuReso.SelectedIndexChanged += new System.EventHandler(this.cboDocuReso_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(229, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(391, 31);
            this.label12.TabIndex = 57;
            this.label12.Text = "RECURSO ADMINISTRATIVO";
            // 
            // dateTimePickerFechaExp
            // 
            this.dateTimePickerFechaExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaExp.Location = new System.Drawing.Point(511, 199);
            this.dateTimePickerFechaExp.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaExp.Name = "dateTimePickerFechaExp";
            this.dateTimePickerFechaExp.Size = new System.Drawing.Size(109, 22);
            this.dateTimePickerFechaExp.TabIndex = 49;
            // 
            // txtAñoExp
            // 
            this.txtAñoExp.Location = new System.Drawing.Point(200, 199);
            this.txtAñoExp.Margin = new System.Windows.Forms.Padding(4);
            this.txtAñoExp.Name = "txtAñoExp";
            this.txtAñoExp.Size = new System.Drawing.Size(96, 22);
            this.txtAñoExp.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(132, 255);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 16);
            this.label13.TabIndex = 59;
            this.label13.Text = "INFORME TÉCNICO";
            // 
            // txtMotivoInfraccion
            // 
            this.txtMotivoInfraccion.Location = new System.Drawing.Point(270, 229);
            this.txtMotivoInfraccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivoInfraccion.Multiline = true;
            this.txtMotivoInfraccion.Name = "txtMotivoInfraccion";
            this.txtMotivoInfraccion.Size = new System.Drawing.Size(435, 74);
            this.txtMotivoInfraccion.TabIndex = 60;
            // 
            // FormDocumentoResolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMotivoInfraccion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAñoExp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboDocuReso);
            this.Controls.Add(this.btnGuardarReso);
            this.Controls.Add(this.txtRepresLegal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickerFechaNoti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerFechaExp);
            this.Controls.Add(this.txtResueltoDoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNroExp);
            this.Controls.Add(this.dataTimePickerFechDoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.dateTimePickerRegis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDocumentoResolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESOLUCIÓN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegis;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dataTimePickerFechDoc;
        private System.Windows.Forms.TextBox txtNroExp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResueltoDoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNoti;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRepresLegal;
        private System.Windows.Forms.Button btnGuardarReso;
        private System.Windows.Forms.ComboBox cboDocuReso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaExp;
        private System.Windows.Forms.TextBox txtAñoExp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMotivoInfraccion;
    }
}
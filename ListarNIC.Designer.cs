
namespace WindowsFormsApp15
{
    partial class ListarNIC
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNumeNIC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfrac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Busqueda = new System.Windows.Forms.GroupBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBusqueDoc = new System.Windows.Forms.Button();
            this.btnBuscarInfractor = new System.Windows.Forms.Button();
            this.txtNumMulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenerarMulta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(785, 770);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 47);
            this.button2.TabIndex = 12;
            this.button2.Text = "DESHABILITAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // button3
            // 
            this.button3.Image = global::WindowsFormsApp15.Properties.Resources.grafico;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(981, 768);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "EXPORTAR EXCEL        ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnExportExc);
            // 
            // txtNumeNIC
            // 
            this.txtNumeNIC.Location = new System.Drawing.Point(130, 40);
            this.txtNumeNIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeNIC.Name = "txtNumeNIC";
            this.txtNumeNIC.Size = new System.Drawing.Size(160, 22);
            this.txtNumeNIC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "NUMERO N.I.C.";
            // 
            // txtInfrac
            // 
            this.txtInfrac.Location = new System.Drawing.Point(130, 72);
            this.txtInfrac.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfrac.Name = "txtInfrac";
            this.txtInfrac.Size = new System.Drawing.Size(317, 22);
            this.txtInfrac.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "INFRACTOR";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(298, 40);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 26);
            this.button4.TabIndex = 13;
            this.button4.Text = "BUSCAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "FECHA: ";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(130, 113);
            this.dateTimePickerInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(109, 22);
            this.dateTimePickerInicio.TabIndex = 18;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Checked = false;
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFin.Location = new System.Drawing.Point(338, 111);
            this.dateTimePickerFin.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(109, 22);
            this.dateTimePickerFin.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "HASTA";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(464, 109);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 26);
            this.button5.TabIndex = 21;
            this.button5.Text = "BUSCAR /FECHA ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(404, 39);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 26);
            this.button6.TabIndex = 22;
            this.button6.Text = "BUSCAR NICS (USUARIO Y PC)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnBuscarNotis_Click);
            // 
            // Busqueda
            // 
            this.Busqueda.Controls.Add(this.pictureBox1);
            this.Busqueda.Controls.Add(this.txtNumDoc);
            this.Busqueda.Controls.Add(this.label6);
            this.Busqueda.Controls.Add(this.button6);
            this.Busqueda.Controls.Add(this.btnBusqueDoc);
            this.Busqueda.Controls.Add(this.btnBuscarInfractor);
            this.Busqueda.Controls.Add(this.txtNumMulta);
            this.Busqueda.Controls.Add(this.label5);
            this.Busqueda.Controls.Add(this.button7);
            this.Busqueda.Controls.Add(this.button5);
            this.Busqueda.Controls.Add(this.label4);
            this.Busqueda.Controls.Add(this.dateTimePickerFin);
            this.Busqueda.Controls.Add(this.dateTimePickerInicio);
            this.Busqueda.Controls.Add(this.label3);
            this.Busqueda.Controls.Add(this.button4);
            this.Busqueda.Controls.Add(this.label2);
            this.Busqueda.Controls.Add(this.txtInfrac);
            this.Busqueda.Controls.Add(this.label1);
            this.Busqueda.Controls.Add(this.txtNumeNIC);
            this.Busqueda.Location = new System.Drawing.Point(13, 15);
            this.Busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Padding = new System.Windows.Forms.Padding(4);
            this.Busqueda.Size = new System.Drawing.Size(1189, 178);
            this.Busqueda.TabIndex = 4;
            this.Busqueda.TabStop = false;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(784, 78);
            this.txtNumDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(160, 22);
            this.txtNumDoc.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "NUMERO DOCUMENTO";
            // 
            // btnBusqueDoc
            // 
            this.btnBusqueDoc.Location = new System.Drawing.Point(966, 76);
            this.btnBusqueDoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusqueDoc.Name = "btnBusqueDoc";
            this.btnBusqueDoc.Size = new System.Drawing.Size(85, 26);
            this.btnBusqueDoc.TabIndex = 27;
            this.btnBusqueDoc.Text = "BUSCAR ";
            this.btnBusqueDoc.UseVisualStyleBackColor = true;
            this.btnBusqueDoc.Click += new System.EventHandler(this.btnBusqueDoc_Click_1);
            // 
            // btnBuscarInfractor
            // 
            this.btnBuscarInfractor.Location = new System.Drawing.Point(464, 68);
            this.btnBuscarInfractor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarInfractor.Name = "btnBuscarInfractor";
            this.btnBuscarInfractor.Size = new System.Drawing.Size(90, 29);
            this.btnBuscarInfractor.TabIndex = 26;
            this.btnBuscarInfractor.Text = "BUSCAR";
            this.btnBuscarInfractor.UseVisualStyleBackColor = true;
            this.btnBuscarInfractor.Click += new System.EventHandler(this.btnBuscarInfractor_Click);
            // 
            // txtNumMulta
            // 
            this.txtNumMulta.Location = new System.Drawing.Point(784, 41);
            this.txtNumMulta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumMulta.Name = "txtNumMulta";
            this.txtNumMulta.Size = new System.Drawing.Size(160, 22);
            this.txtNumMulta.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "NUMERO MULTA";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(966, 40);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 26);
            this.button7.TabIndex = 23;
            this.button7.Text = "BUSCAR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnBuscarMul);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 201);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 553);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGenerarMulta
            // 
            this.btnGenerarMulta.Image = global::WindowsFormsApp15.Properties.Resources.enviar32;
            this.btnGenerarMulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarMulta.Location = new System.Drawing.Point(244, 768);
            this.btnGenerarMulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarMulta.Name = "btnGenerarMulta";
            this.btnGenerarMulta.Size = new System.Drawing.Size(236, 53);
            this.btnGenerarMulta.TabIndex = 23;
            this.btnGenerarMulta.Text = "GENERAR MULTA            ";
            this.btnGenerarMulta.UseVisualStyleBackColor = true;
            this.btnGenerarMulta.Click += new System.EventHandler(this.btnGenerarMulta_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApp15.Properties.Resources.editar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(41, 768);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "EDITAR        ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp15.Properties.Resources.muni_rimac_logo;
            this.pictureBox1.Location = new System.Drawing.Point(1058, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // ListarNIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1229, 834);
            this.Controls.Add(this.btnGenerarMulta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarNIC";
            this.Text = "Busqueda y Generación(NIC,RSA)";
            this.Busqueda.ResumeLayout(false);
            this.Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNumeNIC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfrac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox Busqueda;
        private System.Windows.Forms.Button btnGenerarMulta;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtNumMulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscarInfractor;
        private System.Windows.Forms.Button btnBusqueDoc;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
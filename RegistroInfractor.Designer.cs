
namespace WindowsFormsApp15
{
    partial class RegistroInfractor
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRegisInfrac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboDireccionFiscal = new System.Windows.Forms.ComboBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarDireccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 169);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnRegisInfrac
            // 
            this.btnRegisInfrac.Location = new System.Drawing.Point(219, 323);
            this.btnRegisInfrac.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisInfrac.Name = "btnRegisInfrac";
            this.btnRegisInfrac.Size = new System.Drawing.Size(115, 28);
            this.btnRegisInfrac.TabIndex = 1;
            this.btnRegisInfrac.Text = "REGISTRAR";
            this.btnRegisInfrac.UseVisualStyleBackColor = true;
            this.btnRegisInfrac.Visible = false;
            this.btnRegisInfrac.Click += new System.EventHandler(this.btnRegisInfrac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "NUM DE DOCUMENTO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "TIPO DE DOCUMENTO :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DNI",
            "RUC",
            "CE",
            "PASAPORTE"});
            this.comboBox1.Location = new System.Drawing.Point(239, 141);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "SELECCIONE";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "NATURAL",
            "JURIDICA",
            "INST. PUBLICA",
            "SUSECION",
            "OTROS"});
            this.comboBox2.Location = new System.Drawing.Point(239, 82);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "TIPO DE PERSONA :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "NOMBRES :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 228);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "APELLIDO PATERNO :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(239, 253);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "APELLIDO MATERNO :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(239, 279);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 22);
            this.textBox4.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.comboBox3.Location = new System.Drawing.Point(239, 112);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(171, 24);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.Text = "SELECCIONE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "SEXO :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "REGISTRO DE PERSONAS";
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Image = global::WindowsFormsApp15.Properties.Resources.salvar16png;
            this.btnGuardarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDatos.Location = new System.Drawing.Point(354, 323);
            this.btnGuardarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(136, 28);
            this.btnGuardarDatos.TabIndex = 17;
            this.btnGuardarDatos.Text = "GUARDAR";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 206);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "DIRECCIÓN:";
            // 
            // cboDireccionFiscal
            // 
            this.cboDireccionFiscal.FormattingEnabled = true;
            this.cboDireccionFiscal.Location = new System.Drawing.Point(239, 196);
            this.cboDireccionFiscal.Margin = new System.Windows.Forms.Padding(4);
            this.cboDireccionFiscal.Name = "cboDireccionFiscal";
            this.cboDireccionFiscal.Size = new System.Drawing.Size(400, 24);
            this.cboDireccionFiscal.TabIndex = 20;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(688, 191);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(36, 31);
            this.btnAñadir.TabIndex = 28;
            this.btnAñadir.Text = "+";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(676, 159);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "AÑADIR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(679, 175);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "NUEVA";
            // 
            // btnBuscarDireccion
            // 
            this.btnBuscarDireccion.BackgroundImage = global::WindowsFormsApp15.Properties.Resources.search;
            this.btnBuscarDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarDireccion.Location = new System.Drawing.Point(647, 192);
            this.btnBuscarDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarDireccion.Name = "btnBuscarDireccion";
            this.btnBuscarDireccion.Size = new System.Drawing.Size(33, 31);
            this.btnBuscarDireccion.TabIndex = 27;
            this.btnBuscarDireccion.UseVisualStyleBackColor = true;
            this.btnBuscarDireccion.Click += new System.EventHandler(this.btnBuscarDireccion_Click);
            // 
            // RegistroInfractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(818, 388);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnBuscarDireccion);
            this.Controls.Add(this.cboDireccionFiscal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuardarDatos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisInfrac);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroInfractor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroInfractor";
            this.Load += new System.EventHandler(this.RegistroInfractor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRegisInfrac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboDireccionFiscal;
        private System.Windows.Forms.Button btnBuscarDireccion;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
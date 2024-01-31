
namespace WindowsFormsApp15
{
    partial class ListarRSA
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
            this.button3 = new System.Windows.Forms.Button();
            this.Busqueda = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxIngresos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buscarIngresosButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WindowsFormsApp15.Properties.Resources.grafico;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(788, 687);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 48);
            this.button3.TabIndex = 17;
            this.button3.Text = "EXPORTAR EXCEL";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // Busqueda
            // 
            this.Busqueda.Controls.Add(this.pictureBox1);
            this.Busqueda.Controls.Add(this.dateTimePicker2);
            this.Busqueda.Controls.Add(this.comboBoxIngresos);
            this.Busqueda.Controls.Add(this.label5);
            this.Busqueda.Controls.Add(this.label4);
            this.Busqueda.Controls.Add(this.dateTimePicker1);
            this.Busqueda.Controls.Add(this.buscarIngresosButton);
            this.Busqueda.Controls.Add(this.label3);
            this.Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busqueda.Location = new System.Drawing.Point(37, 48);
            this.Busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Padding = new System.Windows.Forms.Padding(4);
            this.Busqueda.Size = new System.Drawing.Size(992, 178);
            this.Busqueda.TabIndex = 15;
            this.Busqueda.TabStop = false;
            this.Busqueda.Text = "BUSQUEDA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp15.Properties.Resources.muni_rimac_logo;
            this.pictureBox1.Location = new System.Drawing.Point(858, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(365, 92);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 22);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // comboBoxIngresos
            // 
            this.comboBoxIngresos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIngresos.FormattingEnabled = true;
            this.comboBoxIngresos.Location = new System.Drawing.Point(149, 46);
            this.comboBoxIngresos.Name = "comboBoxIngresos";
            this.comboBoxIngresos.Size = new System.Drawing.Size(432, 24);
            this.comboBoxIngresos.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "INGRESOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "HASTA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 92);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // buscarIngresosButton
            // 
            this.buscarIngresosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarIngresosButton.Image = global::WindowsFormsApp15.Properties.Resources.lupa;
            this.buscarIngresosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarIngresosButton.Location = new System.Drawing.Point(660, 34);
            this.buscarIngresosButton.Margin = new System.Windows.Forms.Padding(4);
            this.buscarIngresosButton.Name = "buscarIngresosButton";
            this.buscarIngresosButton.Size = new System.Drawing.Size(161, 51);
            this.buscarIngresosButton.TabIndex = 13;
            this.buscarIngresosButton.Text = "BUSCAR";
            this.buscarIngresosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarIngresosButton.UseVisualStyleBackColor = true;
            this.buscarIngresosButton.Click += new System.EventHandler(this.BuscarIngresos);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "FECHA: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 222);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(992, 457);
            this.dataGridView1.TabIndex = 14;
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // ListarRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1070, 748);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListarRSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESOS POR MULTAS ADMINISTRATIVAS";
            this.Busqueda.ResumeLayout(false);
            this.Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox Busqueda;
        private System.Windows.Forms.Button buscarIngresosButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private System.Windows.Forms.ComboBox comboBoxIngresos;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
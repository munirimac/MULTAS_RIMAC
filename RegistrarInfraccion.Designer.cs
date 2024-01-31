namespace WindowsFormsApp15
{
    partial class RegistrarInfraccion
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Infrac = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtBuscarDirec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Infrac)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 31);
            this.label2.TabIndex = 52;
            this.label2.Text = "BUSCAR DIRECCIÓN INFRACCIÓN";
            // 
            // dataGridView_Infrac
            // 
            this.dataGridView_Infrac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Infrac.Location = new System.Drawing.Point(72, 140);
            this.dataGridView_Infrac.Name = "dataGridView_Infrac";
            this.dataGridView_Infrac.ReadOnly = true;
            this.dataGridView_Infrac.RowHeadersWidth = 51;
            this.dataGridView_Infrac.RowTemplate.Height = 24;
            this.dataGridView_Infrac.Size = new System.Drawing.Size(809, 349);
            this.dataGridView_Infrac.TabIndex = 53;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = global::WindowsFormsApp15.Properties.Resources.salvar16png;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.Location = new System.Drawing.Point(734, 515);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(147, 28);
            this.btnSeleccionar.TabIndex = 55;
            this.btnSeleccionar.Text = "GUARDAR";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtBuscarDirec
            // 
            this.txtBuscarDirec.Location = new System.Drawing.Point(214, 90);
            this.txtBuscarDirec.Name = "txtBuscarDirec";
            this.txtBuscarDirec.Size = new System.Drawing.Size(536, 22);
            this.txtBuscarDirec.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Dirección Infracción";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Image = global::WindowsFormsApp15.Properties.Resources.lupa16;
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadir.Location = new System.Drawing.Point(761, 87);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(120, 28);
            this.btnAñadir.TabIndex = 54;
            this.btnAñadir.Text = "BUSCAR";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnBuscarDirecClick);
            // 
            // RegistrarInfraccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(952, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarDirec);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dataGridView_Infrac);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarInfraccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Infracción";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Infrac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Infrac;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtBuscarDirec;
        private System.Windows.Forms.Label label1;
    }
}
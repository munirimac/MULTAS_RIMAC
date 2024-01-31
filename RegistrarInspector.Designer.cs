
namespace WindowsFormsApp15
{
    partial class RegistrarInspector
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
            this.label16 = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtCodNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(105, 90);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 16);
            this.label16.TabIndex = 45;
            this.label16.Text = "TIPO DE DOCUMENTO";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "RUC",
            "CE",
            "PTP",
            "PASAPORTE"});
            this.cboTipoDoc.Location = new System.Drawing.Point(277, 86);
            this.cboTipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(191, 24);
            this.cboTipoDoc.TabIndex = 48;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(276, 117);
            this.txtNumDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(192, 22);
            this.txtNumDoc.TabIndex = 47;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Image = global::WindowsFormsApp15.Properties.Resources.lupa16;
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadir.Location = new System.Drawing.Point(477, 114);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(115, 28);
            this.btnAñadir.TabIndex = 49;
            this.btnAñadir.Text = "BUSCAR";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "NUM DE DOCUMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "BÚSQUEDA DE INSPECTOR";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = global::WindowsFormsApp15.Properties.Resources.salvar16png;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.Location = new System.Drawing.Point(361, 177);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(140, 28);
            this.btnSeleccionar.TabIndex = 52;
            this.btnSeleccionar.Text = "GUARDAR";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnGuardarClick);
            // 
            // txtCodNom
            // 
            this.txtCodNom.Location = new System.Drawing.Point(276, 147);
            this.txtCodNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodNom.Name = "txtCodNom";
            this.txtCodNom.Size = new System.Drawing.Size(316, 22);
            this.txtCodNom.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "NOMBR. INSPECTOR";
            // 
            // RegistrarInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(770, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodNom);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarInspector";
            this.Text = "RegistrarInspector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtCodNom;
        private System.Windows.Forms.Label label3;
    }
}
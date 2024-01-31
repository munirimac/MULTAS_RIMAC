
namespace WindowsFormsApp15
{
    partial class DeshabilitarMulta
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
            this.txtNroExpediente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotivoInfraccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumResol = new System.Windows.Forms.TextBox();
            this.btnGuardarDoc = new System.Windows.Forms.Button();
            this.dptDiaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "NRO EXPEDIENTE";
            // 
            // txtNroExpediente
            // 
            this.txtNroExpediente.Location = new System.Drawing.Point(232, 61);
            this.txtNroExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroExpediente.Name = "txtNroExpediente";
            this.txtNroExpediente.Size = new System.Drawing.Size(435, 22);
            this.txtNroExpediente.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "RAZÓN";
            // 
            // txtMotivoInfraccion
            // 
            this.txtMotivoInfraccion.Location = new System.Drawing.Point(232, 157);
            this.txtMotivoInfraccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivoInfraccion.Multiline = true;
            this.txtMotivoInfraccion.Name = "txtMotivoInfraccion";
            this.txtMotivoInfraccion.Size = new System.Drawing.Size(435, 26);
            this.txtMotivoInfraccion.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "NRO RESOLUCIÓN";
            // 
            // txtNumResol
            // 
            this.txtNumResol.Location = new System.Drawing.Point(232, 116);
            this.txtNumResol.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumResol.Name = "txtNumResol";
            this.txtNumResol.Size = new System.Drawing.Size(435, 22);
            this.txtNumResol.TabIndex = 63;
            // 
            // btnGuardarDoc
            // 
            this.btnGuardarDoc.Location = new System.Drawing.Point(365, 217);
            this.btnGuardarDoc.Name = "btnGuardarDoc";
            this.btnGuardarDoc.Size = new System.Drawing.Size(123, 31);
            this.btnGuardarDoc.TabIndex = 64;
            this.btnGuardarDoc.Text = "GUARDAR";
            this.btnGuardarDoc.UseVisualStyleBackColor = true;
            this.btnGuardarDoc.Click += new System.EventHandler(this.btnGuardarDoc_Click);
            // 
            // dptDiaRecepcion
            // 
            this.dptDiaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptDiaRecepcion.Location = new System.Drawing.Point(232, 22);
            this.dptDiaRecepcion.Margin = new System.Windows.Forms.Padding(4);
            this.dptDiaRecepcion.Name = "dptDiaRecepcion";
            this.dptDiaRecepcion.Size = new System.Drawing.Size(125, 22);
            this.dptDiaRecepcion.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "FECHA RECEPCION";
            // 
            // DeshabilitarMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(775, 276);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dptDiaRecepcion);
            this.Controls.Add(this.btnGuardarDoc);
            this.Controls.Add(this.txtNumResol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMotivoInfraccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNroExpediente);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeshabilitarMulta";
            this.Text = "DESHABILITAR MULTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroExpediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotivoInfraccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumResol;
        private System.Windows.Forms.Button btnGuardarDoc;
        private System.Windows.Forms.DateTimePicker dptDiaRecepcion;
        private System.Windows.Forms.Label label4;
    }
}
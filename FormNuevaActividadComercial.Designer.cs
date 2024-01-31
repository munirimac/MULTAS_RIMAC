namespace WindowsFormsApp15
{
    partial class FormNuevaActividadComercial
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
            this.btnAñadirACTI = new System.Windows.Forms.Button();
            this.txtAñadirActi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "NUEVA ACTIVIDAD COMERCIAL";
            // 
            // btnAñadirACTI
            // 
            this.btnAñadirACTI.Image = global::WindowsFormsApp15.Properties.Resources.salvar16png;
            this.btnAñadirACTI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirACTI.Location = new System.Drawing.Point(258, 178);
            this.btnAñadirACTI.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirACTI.Name = "btnAñadirACTI";
            this.btnAñadirACTI.Size = new System.Drawing.Size(143, 28);
            this.btnAñadirACTI.TabIndex = 54;
            this.btnAñadirACTI.Text = "GUARDAR";
            this.btnAñadirACTI.UseVisualStyleBackColor = true;
            this.btnAñadirACTI.Click += new System.EventHandler(this.btnAñadirACTI_Click);
            // 
            // txtAñadirActi
            // 
            this.txtAñadirActi.Location = new System.Drawing.Point(185, 129);
            this.txtAñadirActi.Margin = new System.Windows.Forms.Padding(4);
            this.txtAñadirActi.Name = "txtAñadirActi";
            this.txtAñadirActi.Size = new System.Drawing.Size(386, 22);
            this.txtAñadirActi.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "NOMBRE ACTIVIDAD :";
            // 
            // FormNuevaActividadComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(606, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAñadirActi);
            this.Controls.Add(this.btnAñadirACTI);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNuevaActividadComercial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAñadirACTI;
        private System.Windows.Forms.TextBox txtAñadirActi;
        private System.Windows.Forms.Label label3;
    }
}